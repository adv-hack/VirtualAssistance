﻿using CodeGenerator.CodeModel;
using CodeGenerator.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Consensus.Business
{
    public class BlankBusinessProvider : TypeInterface
    {
        /// <summary>
        ///     Gets the summary section of the xml documentation.
        /// </summary>
        public override String XmlSummary
        {
            get { return "Supports programmatic access to the factories which handle the business model instantiation."; }
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
            get { return "BusinessProvider"; }
        }
    }
}
