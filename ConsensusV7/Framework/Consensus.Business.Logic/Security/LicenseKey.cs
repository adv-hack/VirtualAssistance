using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents the RSA key which is used to digitally sign a license or verify an existing digital signature.
    /// </summary>
    public class LicenseKey
    {
        #region fields

        /// <summary>
        ///     The PKCS1 encoded object identifier for RSA Encryption.
        /// </summary>
        private static readonly Byte[] RsaObjectIdentifier = { 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x01 };

        /// <summary>
        ///     The singleton instance of the public key.
        /// </summary>
        internal static readonly LicenseKey PublicKey = LicenseKey.GetFromAssembly("SigningKey.public.der");

        /// <summary>
        ///     The singleton instance of the private key.
        /// </summary>
        internal static readonly LicenseKey PrivateKey = LicenseKey.GetFromFile("SigningKey.private.der");
        
        /// <summary>
        ///     The parameters for the RSA algorithm.
        /// </summary>
        private readonly RSAParameters Parameters;

        #endregion

        #region properties

        /// <summary>
        ///     Indicates if a private license key is available.
        /// </summary>
        public static Boolean HasPrivateKey
        {
            get { return LicenseKey.PrivateKey != null; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new license key
        /// </summary>
        private LicenseKey(RSAParameters parameters)
        {
            this.Parameters = parameters;
        }

        #endregion

        #region instance methods

        /// <summary>
        ///     Saves the public and private elements of the license key.
        /// </summary>
        internal void Save(String filename, Boolean includePrivate)
        {
            Byte[] oidValue = LicenseKey.SetAsnData(0x06, LicenseKey.RsaObjectIdentifier);
            Byte[] oidNulls = LicenseKey.SetAsnData(0x05, new Byte[0]);
            Byte[] oidBlock = LicenseKey.SetAsnData(0x30, oidValue.Concat(oidNulls));
            Byte[] keyValue = LicenseKey.SetAsnData(0x02, this.Parameters.Modulus).Concat(LicenseKey.SetAsnData(0x02, this.Parameters.Exponent)).ToArray();
            if (includePrivate)
            {
                keyValue = keyValue.Concat(
                    LicenseKey.SetAsnData(0x02, this.Parameters.D)).Concat(
                    LicenseKey.SetAsnData(0x02, this.Parameters.P)).Concat(
                    LicenseKey.SetAsnData(0x02, this.Parameters.Q)).Concat(
                    LicenseKey.SetAsnData(0x02, this.Parameters.DP)).Concat(
                    LicenseKey.SetAsnData(0x02, this.Parameters.DQ)).Concat(
                    LicenseKey.SetAsnData(0x02, this.Parameters.InverseQ)).ToArray();
            }                
            Byte[] rsaValue = LicenseKey.SetAsnData(0x30, keyValue);
            Byte[] rsaBlock = LicenseKey.SetAsnData(0x03, rsaValue);
            Byte[] asnBlock = LicenseKey.SetAsnData(0x30, oidBlock.Concat(rsaBlock));

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("----- BEGIN " + (includePrivate ? "PRIVATE" : "PUBLIC") + " RSA KEY -----");
            builder.AppendLine();
            builder.AppendLine(Convert.ToBase64String(asnBlock, Base64FormattingOptions.InsertLineBreaks));
            builder.AppendLine();
            builder.AppendLine("----- END " + (includePrivate ? "PRIVATE" : "PUBLIC") + " RSA KEY -----");
            File.WriteAllText(filename, builder.ToString());
        }

        /// <summary>
        ///     Digitally signs the computed hash data.
        /// </summary>
        internal Boolean Verify(Byte[] hash, Byte[] signature)
        {
            Boolean result;
            using (RSACryptoServiceProvider provider = new RSACryptoServiceProvider())
            {
                provider.ImportParameters(this.Parameters);
                result = provider.VerifyHash(hash, "SHA512", signature);
            }
            return result;
        }

        /// <summary>
        ///     Digitally signs the computed hash data.
        /// </summary>
        internal Byte[] Sign(Byte[] hash)
        {
            Byte[] result;
            using (RSACryptoServiceProvider provider = new RSACryptoServiceProvider())
            {
                provider.ImportParameters(this.Parameters);
                result = provider.SignHash(hash, "SHA512");
            }
            return result;
        }

        #endregion

        #region static methods

        /// <summary>
        ///     Generates a new 4096-bit licensing key.
        /// </summary>
        internal static LicenseKey CreateNew()
        {
            LicenseKey result;
            using (RSACryptoServiceProvider provider = new RSACryptoServiceProvider(4096))
            {
                result = new LicenseKey(provider.ExportParameters(true));

                String asmbPath = Path.GetDirectoryName(LicenseKey.GetEntryAssembly().CodeBase.Substring(8));
                result.Save(Path.Combine(asmbPath, "consensus.key"), true);
                result.Save(Path.Combine(asmbPath, "consensus.lic"), false);
            }
            return result;
        }

        /// <summary>
        ///     Gets a license key from the specified file.
        /// </summary>
        private static LicenseKey GetFromAssembly(String filename)
        {
            LicenseKey result;

            Assembly assembly = LicenseKey.GetEntryAssembly();
            String resourceName = String.Format("{0}.{1}", assembly.GetName().Name, filename);
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
                result = LicenseKey.GetFromText(reader.ReadToEnd());

            return result;
        }

        /// <summary>
        ///     Gets a license key from the specified file.
        /// </summary>
        private static LicenseKey GetFromFile(String filename)
        {
            LicenseKey result = null;

            // Validate that the key exists
            String asmbPath = Path.GetDirectoryName(LicenseKey.GetEntryAssembly().CodeBase.Substring(8));
            String filePath = Path.Combine(asmbPath, filename);
            if (File.Exists(filePath))
                result = LicenseKey.GetFromText(File.ReadAllText(filePath));

            return result;            
        }

        /// <summary>
        ///     Gets a license key from the specified file.
        /// </summary>
        internal static LicenseKey GetFromText(String keyText)
        {
            LicenseKey result = null;

            if (!String.IsNullOrEmpty(keyText))
            {
                // Reconstruct the content of the ASN.1 formatted PEM, excluding blank lines and comments
                String stringData = String.Join("", keyText.Split('\r', '\n').Where(line => !String.IsNullOrEmpty(line) && !line.Trim().StartsWith("--")));
                Byte[] binaryPem = Convert.FromBase64String(stringData);
                if (binaryPem.Length != 0)
                {
                    // Extract the header from the PEM content
                    try
                    {
                        Byte[] asnBlock = LicenseKey.GetAsnData(0x30, ref binaryPem);
                        Byte[] oidBlock = LicenseKey.GetAsnData(0x30, ref asnBlock);
                        Byte[] oidValue = LicenseKey.GetAsnData(0x06, ref oidBlock);
                        if (oidValue.SequenceEqual(LicenseKey.RsaObjectIdentifier))
                        {
                            // Extract the RSA key from the PEM content
                            Byte[] rsaBlock = LicenseKey.GetAsnData(0x03, ref asnBlock);
                            Byte[] rsaValue = LicenseKey.GetAsnData(0x30, ref rsaBlock);

                            // Construct the RSA parameters
                            RSAParameters parameters = new RSAParameters();
                            parameters.Modulus = LicenseKey.GetAsnData(0x02, ref rsaValue);
                            parameters.Exponent = LicenseKey.GetAsnData(0x02, ref rsaValue);
                            if (rsaValue.Length > 0)
                            {
                                parameters.D = LicenseKey.GetAsnData(0x02, ref rsaValue);
                                parameters.P = LicenseKey.GetAsnData(0x02, ref rsaValue);
                                parameters.Q = LicenseKey.GetAsnData(0x02, ref rsaValue);
                                parameters.DP = LicenseKey.GetAsnData(0x02, ref rsaValue);
                                parameters.DQ = LicenseKey.GetAsnData(0x02, ref rsaValue);
                                parameters.InverseQ = LicenseKey.GetAsnData(0x02, ref rsaValue);
                            }

                            // Create the license key from the RSA
                            result = new LicenseKey(parameters);
                        }
                    }
                    catch
                    {

                    }
                }
            }
            return result;
        }

        /// <summary>
        ///     Gets the directory in which keys are stored.
        /// </summary>
        private static Assembly GetEntryAssembly()
        {
            // Return the reflected entry assembly.
            Assembly entryAssembly = Assembly.GetEntryAssembly();
            if (entryAssembly == null)
            {
                // If the application is an ASP.NET application, return the assembly of the application instance.
                if (HttpContext.Current != null && HttpContext.Current.ApplicationInstance != null)
                {
                    Type type = HttpContext.Current.ApplicationInstance.GetType();
                    while (type != null && String.Equals(type.Namespace, "ASP"))
                        type = type.BaseType;
                    entryAssembly = type.Assembly;
                }
            }
            return entryAssembly;
        }

        /// <summary>
        ///     Extracts the data from the ASN.1 formatted byte array.
        /// </summary>
        /// <param name="expectedType">
        ///     The type of data that is expected in the array.
        /// </param>
        /// <param name="data">
        ///     The binary data containing an ASN.1 formatted value.
        /// </param>
        /// <returns>
        ///     The content of the ASN.1 formatted binary value.
        /// </returns>
        private static Byte[] GetAsnData(Byte expectedType, ref Byte[] data)
        {
            Byte[] result;

            using (MemoryStream stream = new MemoryStream(data))
            using (BinaryReader reader = new BinaryReader(stream))
            {
                // Read the header from the binary stream
                Byte header = reader.ReadByte();
                Int32 length = reader.ReadByte();
                if (header != expectedType)
                    throw new CryptographicException("The specified value is not a valid RSA key");

                // Decode the length of the binary value
                if ((length & 128) == 128)
                {
                    Int32 lengthSize = length ^ 128;
                    Byte[] lengthData = reader.ReadBytes(lengthSize);
                    Byte[] lengthPadding = new Byte[4 - lengthData.Length];
                    length = BitConverter.ToInt32(lengthData.Concat(lengthPadding).ToArray(), 0);
                }

                // Read the requested data (accounting for the leading bit on bitstring types and positive integer types commencing with a high-order bit)
                result = reader.ReadBytes(length);
                if (expectedType == 0x03)
                    result = result.Skip(1).ToArray();
                if (expectedType == 0x02 && result.Length >= 2 && result[0] == 0x00 && (result[1] & 128) == 128)
                    result = result.Skip(1).ToArray();

                // Push the remaining data into the output
                data = reader.ReadBytes((Int32)stream.Length);
            }

            return result;
        }

        /// <summary>
        ///     Writes the specified data to an ASN.1 formatted stream.
        /// </summary>
        private static Byte[] SetAsnData(Byte type, IEnumerable<Byte> data)
        {
            Byte[] result;
            using (MemoryStream stream = new MemoryStream())
            using (BinaryWriter writer = new BinaryWriter(stream))
            {
                // Prefix the data with a leading zero 
                Byte[] content = data.ToArray();
                if (type == 0x03)
                    content = (new Byte[1]).Concat(data).ToArray();
                else if (type == 0x02 && content.Length >= 1 && (content[0] & 128) == 128)
                    content = (new Byte[1]).Concat(data).ToArray();

                // Determine whether the length needs to be encoded.
                if (content.LongLength >= 128)
                {
                    // Write the ASN formatted data using an encoded length
                    Byte[] length = BitConverter.GetBytes(content.LongLength).Reverse().SkipWhile(b => b == 0).Reverse().ToArray();
                    Byte[] prefix = { (Byte)(length.Length | 128) };
                    writer.Write(type);
                    writer.Write(prefix);
                    writer.Write(length);
                    writer.Write(content);
                }
                else
                {
                    // Write the ASN formatted data using an simple length
                    writer.Write(type);
                    writer.Write((Byte)content.LongLength);
                    writer.Write(content);
                }                
                result = stream.ToArray();
            }
            return result;
        }

        #endregion
    }
}
