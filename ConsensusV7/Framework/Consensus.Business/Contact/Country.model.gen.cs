using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="CountryRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICountryModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "CO_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_FORMAT" field.
        /// </summary>
        System.String Format
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_LANGUAGE" field.
        /// </summary>
        System.String Language
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_CURRENCY" field.
        /// </summary>
        System.String Currency
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_COUNTRY_CODE" field.
        /// </summary>
        System.String CountryCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_PCODE_LU" field.
        /// </summary>
        System.Nullable<System.Byte> PcodeLu
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_VAT_CODE" field.
        /// </summary>
        System.String VatCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_VAT_COUNTRY_CODE" field.
        /// </summary>
        System.String VatCountryCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CO_COUNTRY_CODE_2" field.
        /// </summary>
        System.String AltCountryCode
        {
            get;
            set;
        }
    }
}
