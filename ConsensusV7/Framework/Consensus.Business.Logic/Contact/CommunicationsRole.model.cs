using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents Comminication for the role.
    /// </summary>
    public partial class LocalCommunicationsRoleModel
    {
        protected internal override void Denormalise()
        {
            base.Denormalise();
            this.ModifiedData.TableName = "Person_Role";
        }
    }
}
