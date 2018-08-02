using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="LiteratureRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ILiteratureModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "LIT_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_COST" field.
        /// </summary>
        System.Nullable<System.Double> Cost
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_TEMPLATE" field.
        /// </summary>
        System.String Template
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_EXAM" field.
        /// </summary>
        System.Nullable<System.Byte> Exam
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_ATTENDANCE" field.
        /// </summary>
        System.Nullable<System.Byte> Attendance
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_CURRENT" field.
        /// </summary>
        System.Nullable<System.Byte> Current
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "LIT_LT_ID" field.
        /// </summary>
        Consensus.Document.ILetterTemplateModel LtId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LIT_LT_ID" field.
        /// </summary>
        System.String LtIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_SEND_OVERRIDE" field.
        /// </summary>
        System.Nullable<System.Byte> SendOverride
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_EMAIL_ONLY" field.
        /// </summary>
        System.Byte EmailOnly
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_PRINT_ONLY" field.
        /// </summary>
        System.Byte PrintOnly
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_FILE_NAME" field.
        /// </summary>
        System.String FileName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackXrefModel" /> instances that reference this <see cref="!:LiteratureModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IPackXrefModel> LiteratureId
        {
            get;
        }
    }
}
