﻿using CodeGenerator.CodeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Consensus.Business
{
    /// <summary>
    ///     Generates the base model interface.
    /// </summary>
    public class GeneratedModelRemovable : TypeInterface
    {
        /// <summary>
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Supports the modification of the business model."; }
        }

        /// <summary>
        ///     Gets the access modifier for the type.
        /// </summary>
        public override CSharpModifier TypeModifier
        {
            get { return CSharpModifier.Public; }
        }

        /// <summary>
        ///     Gets the name of the type.
        /// </summary>
        public override String TypeName
        {
            get { return "ModelRemovable"; }
        }

        /// <summary>
        ///     Gets the interfaces that are implemented by the type
        /// </summary>
        public override IEnumerable<String> TypeInterfaces
        {
            get { yield return "Model"; }
        }

        /// <summary>
        ///     Gets the members included within this type.
        /// </summary>
        public override IEnumerable<Member> Members
        {
            get
            {
                yield return new MemberMethod(this)
                {
                    XmlSummary = "Deletes the business model.",
                    MemberType = "void",
                    MemberName = "Remove"
                };
            }
        }
    }
}
