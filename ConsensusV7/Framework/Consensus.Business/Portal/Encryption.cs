using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTM
{
    /// <summary>
    ///     
    /// </summary>
    public abstract class Encryption
    {
        #region fields

        /// <summary>
        ///     The singleton instance of the PC1 algorithm, created by Alexander Pukall
        /// </summary>
        private static EncryptionPC1 _pc1;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the singleton instance of the PC1 algorithm, created by Alexander Pukall
        /// </summary>
        public static EncryptionPC1 PC1
        {
            get
            {
                if (_pc1 == null)
                    _pc1 = new EncryptionPC1();

                return _pc1;
            }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Encrypts a <see cref="System.String"/> value using the encryption algorithm implementation
        /// </summary>
        /// <param name="input">
        ///     The input value to be encrypted
        /// </param>
        /// <returns>
        ///     A <see cref="System.String"/> value, representing the encrypted value
        /// </returns>
        public abstract String Encrypt(String input);

        /// <summary>
        ///     Decrypts a <see cref="System.String"/> value using the encryption algorithm implementation
        /// </summary>
        /// <param name="input">
        ///     The input value to be decrypted
        /// </param>
        /// <returns>
        ///     A <see cref="System.String"/> value, decrypted from the input value
        /// </returns>
        public abstract String Decrypt(String input);

        #endregion
    }

    /// <summary>
    ///     The PC1 algorithm, created by Alexander Pukall
    /// </summary>
    public class EncryptionPC1 : Encryption
    {
        #region fields

        private const String PASSWORD = "dqfichvspy";

        private Int32[] cipherKey;
        private Int32[] cipherBlock;
        private Int32 ax, bx, cx, dx, si, c, i, inter, res, tmp, x1a2, cfc, cfd;

        #endregion

        #region methods

        /// <summary>
        ///     Encrypts a <see cref="System.String"/> value using the encryption algorithm implementation
        /// </summary>
        /// <param name="input">
        ///     The input value to be encrypted
        /// </param>
        /// <returns>
        ///     A <see cref="System.String"/> value, representing the encrypted value
        /// </returns>
        public override String Encrypt(String input)
        {
            Int32 temp, d, e;
            String result = "";

            // Reset state
            cipherBlock = new Int32[5];
            cipherKey = PASSWORD.Select(chr => (Int32)chr).ToArray();
            si = 0;
            x1a2 = 0;
            i = 0;
            
            // Perform encryption
            for (Int32 index = 0; index < input.Length; index++)
            {
                c = input[index];
                this.Assemble();

                cfc = (Int32)((((inter / 256D) * 256) - (inter % 256)) / 256);
                cfd = inter % 256;
                for (Int32 j = 0; j < cipherKey.Length; j++)
                    cipherKey[j] ^= c;

                temp = cfc ^ cfd;
                c ^= temp;
                d = (Int32)((((c / 16D) * 16) - (c % 16)) / 16);
                e = c % 16;
                result = result + ((Char)(97 + d)) + ((Char)(97 + e));
            }

            return result;
        }

        /// <summary>
        ///     Decrypts a <see cref="System.String"/> value using the encryption algorithm implementation
        /// </summary>
        /// <param name="input">
        ///     The input value to be decrypted
        /// </param>
        /// <returns>
        ///     A <see cref="System.String"/> value, decrypted from the input value
        /// </returns>
        public override String Decrypt(String input)
        {
            Int32 temp, d, e;
            String result = "";

            // Reset state
            cipherBlock = new Int32[5];
            cipherKey = PASSWORD.Select(chr => (Int32)chr).ToArray();
            si = 0;
            x1a2 = 0;
            i = 0;
            
            // Perform decryption
            for (Int32 index = 0; index < input.Length; index += 2)
            {
                d = input[index];
                e = input[index + 1];

                if (d >= 97)
                {
                    d -= 97;
                    if (d >= 0 && d <= 15)
                        d *= 16;
                }
                if (e >= 97)
                {
                    e -= 97;
                    if (e >= 0 && e <= 15)
                        c = d + e;
                }

                this.Assemble();
                cfc = (Int32)((((inter / 256D) * 256) - (inter % 256)) / 256);
                cfd = inter % 256;
                temp = cfc ^ cfd;
                c ^= temp;
                for (Int32 j = 0; j < cipherKey.Length; j++)
                    cipherKey[j] ^= c;

                result = result + ((Char)c);
            }

            return result;
        }

        /// <summary>
        ///     PC1 Assemble Function
        /// </summary>
        private void Assemble()
        {
            Int32 temp;

            cipherBlock[0] = ((cipherKey[0] << 8) + cipherKey[1]) % Int16.MaxValue;
            
            this.Code();
            inter = res;
            temp = (cipherKey[2] << 8) + cipherKey[3];
            cipherBlock[1] = cipherBlock[0] ^ temp;
            
            this.Code();
            inter ^= res;
            temp = (cipherKey[4] << 8) + cipherKey[5];
            cipherBlock[2] = cipherBlock[1] ^ temp;

            this.Code();
            inter ^= res;
            temp = (cipherKey[6] << 8) + cipherKey[7];
            cipherBlock[3] = cipherBlock[2] ^ temp;

            this.Code();
            inter ^= res;
            temp = (cipherKey[8] << 8) + cipherKey[9];
            cipherBlock[4] = cipherBlock[3] ^ temp;

            this.Code();
            inter ^= res;
            i = 0;
        }

        /// <summary>
        ///     PC1 Code Function
        /// </summary>
        private void Code()
        {
            dx = (x1a2 + i) % 65536;
            ax = cipherBlock[i];
            cx = 346;
            bx = 20021;
            tmp = ax;
            ax = si;
            si = tmp;
            tmp = ax;
            ax = dx;
            dx = tmp;
            if (ax != 0)
                ax = (ax * bx) % 65536;

            tmp = ax;
            ax = cx;
            cx = tmp;
            if (ax != 0)
            {
                ax = (ax * si) % 65536;
                cx = (ax + cx) % 65536;
            }
            
            tmp = ax;
            ax = si;
            si = tmp;
            ax = (ax * bx) % 65536;
            dx = (cx + dx) % 65536;
            ax = ax + 1;
            x1a2 = dx;
            cipherBlock[i] = ax;
            res = ax ^ dx;
            i = i + 1;
        }
        
        #endregion

    }
}
