using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="CommunicationsRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICommunicationsModel : IModel<Int64>
    {
        /// <summary>
        ///     Gets the recognised type of the device.
        /// </summary>
        System.String DeviceType
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_ACTIVE" field.
        /// </summary>
        System.Boolean Active
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_DEFAULT" field.
        /// </summary>
        System.Boolean Default
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_PREFERRED" field.
        /// </summary>
        System.Boolean Preferred
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_EX_DIRECTORY" field.
        /// </summary>
        System.Boolean ExDirectory
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COMM_DEVICE_CODE" field.
        /// </summary>
        Consensus.Common.ICodeModel DeviceCode
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COMM_DEVICE_CODE" field.
        /// </summary>
        System.String DeviceCodeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_DIALLING_CODE" field.
        /// </summary>
        System.String DiallingCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_STD_CODE" field.
        /// </summary>
        System.String StdCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_EXTENSION" field.
        /// </summary>
        System.String Extension
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_NOTES" field.
        /// </summary>
        System.String Notes
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_VALID_FROM" field.
        /// </summary>
        System.Nullable<System.DateTime> ValidFrom
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_DEVICE_VALUE" field.
        /// </summary>
        System.String DeviceValue
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_DEVICE_FULL_VALUE" field.
        /// </summary>
        System.String DeviceFullValue
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:Communications_XrefModel" /> instances that reference this <see cref="!:CommunicationsModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ICommunications_XrefModel> CommId
        {
            get;
        }
    }
}
