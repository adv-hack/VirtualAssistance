using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="CommunicationsRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalCommunicationsModel
    {
        /// <summary>
        ///     Gets the recognised type of the device.
        /// </summary>
        public String DeviceType
        {
            get { return this.DeviceCode.Value2; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_ACTIVE" field.
        /// </summary>
        public Boolean Active
        {
            get { return this.ModifiedData.Active == 1; }
            set { this.ModifiedData.Active = value ? 1 : 0; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_DEFAULT" field.
        /// </summary>
        public Boolean Default
        {
            get { return this.ModifiedData.Default == 1; }
            set { this.ModifiedData.Default = value ? 1 : 0; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_PREFERRED" field.
        /// </summary>
        public Boolean Preferred
        {
            get { return this.ModifiedData.Preferred == 1; }
            set { this.ModifiedData.Preferred = value ? 1 : 0; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_EX_DIRECTORY" field.
        /// </summary>
        public Boolean ExDirectory
        {
            get { return this.ModifiedData.ExDirectory == 1; }
            set { this.ModifiedData.ExDirectory = value ? 1 : 0; }
        }
    }
}
