using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CodeGenerator.CodeModel
{
    public class MemberImplementor : Member
    {
        private readonly MemberInfo UnderlyingMember;

        /// <summary>
        ///     Gets or sets the returns section of the xml documentation.
        /// </summary>
        public String XmlReturns { get; set; }

        public MemberImplementor(Type parent, PropertyInfo property, XmlNode documentation) : base(parent)
        {
            this.XmlSummary = documentation == null || documentation.SelectSingleNode("summary") == null ? null : documentation.SelectSingleNode("summary").InnerXml.Trim().Trim('\r', '\n');
            this.UnderlyingMember = property;
        }

        public MemberImplementor(Type parent, MethodInfo method, XmlNode documentation) : base(parent)
        {
            this.XmlSummary = documentation == null || documentation.SelectSingleNode("summary") == null ? null : documentation.SelectSingleNode("summary").InnerXml.Trim().Trim('\r', '\n');
            this.XmlReturns = documentation == null || documentation.SelectSingleNode("returns") == null ? null : documentation.SelectSingleNode("returns").InnerXml.Trim().Trim('\r', '\n');
            this.UnderlyingMember = method;
        }

        public override void Generate(StringBuilder output)
        {
            // Add the xml header
            output.AppendLine("        /// <summary>");
            output.AppendLine("        ///     " + this.XmlSummary);
            output.AppendLine("        /// </summary>");
            if (!String.IsNullOrEmpty(this.XmlRemarks))
            {
                output.AppendLine("        /// <remarks>");
                output.AppendLine("        ///     " + this.XmlRemarks);
                output.AppendLine("        /// </remarks>");
            }

            // Add the property proxy
            if (this.UnderlyingMember is PropertyInfo)
            {
                PropertyInfo property = this.UnderlyingMember as PropertyInfo;
                System.Type absoluteType = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;

                output.Append("        ");
                output.Append(this.GetTypeName(property.PropertyType));
                output.Append(" ");
                output.Append(property.DeclaringType.Name);
                output.Append(".");
                output.Append(property.Name);
                output.AppendLine();
                output.AppendLine("        {");
                if (property.CanRead)
                    output.AppendLine("            get { return this." + property.Name + "; }");
                if (property.CanWrite)
                    output.AppendLine("             set { this." + property.Name + " = value; }");
                output.AppendLine("        }");
            }

            // Add the method proxy
            if (this.UnderlyingMember is MethodInfo)
            {
                MethodInfo method = this.UnderlyingMember as MethodInfo;
                System.Type absoluteType = Nullable.GetUnderlyingType(method.ReturnType) ?? method.ReturnType;
                System.Type[] genericTypes = method.GetGenericArguments();

                output.Append("        ");
                output.Append(this.GetTypeName(method.ReturnType));
                output.Append(" ");
                output.Append(method.DeclaringType.Name);
                output.Append(".");
                output.Append(method.Name);
                output.Append(genericTypes.Length == 0 ? "" : "<");
                output.Append(String.Join(",", genericTypes.Select(this.GetTypeName)));
                output.Append(genericTypes.Length == 0 ? "" : ">");
                output.Append("(");
                output.Append(String.Join(",", method.GetParameters().Select(this.GetSignature)));
                output.Append(")");
                output.AppendLine();
                output.AppendLine("        {");
                output.Append("            ");
                output.Append(method.ReturnType == typeof(void) ? "" : "return ");
                output.Append("this." + method.Name + "(");
                output.Append(String.Join(",", method.GetParameters().Select(param => param.Name)));
                output.Append(");");
                output.AppendLine();
                output.AppendLine("        }");
            }
        }

        private String GetTypeName(System.Type type)
        {
            System.Type nullableType = Nullable.GetUnderlyingType(type);
            if (nullableType != null)
                return nullableType.Name + "?";
            else
                return type.Name;
        }

        private String GetSignature(ParameterInfo parameter)
        {
            String signature = String.Empty;
            if (parameter.IsRetval)
                signature += "ref ";
            else if (parameter.IsOut)
                signature += "out ";
            if (parameter.GetCustomAttribute<ParamArrayAttribute>() != null)
                signature += "params ";

            signature += this.GetTypeName(parameter.ParameterType);
            signature += " ";
            signature += parameter.Name;
            return signature;
        }
    }
}
