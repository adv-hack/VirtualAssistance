using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="LocationModel" /> object.
    /// </summary>
    public partial class LocalLocationFactory
    {
        /// <summary>
        /// Check if Location Reference exist or not
        /// </summary>
        /// <param name="reference">Location Reference</param>
        /// <param name="locationId">Id of Location</param>
        /// <returns>Whether loction exist or not</returns>
        public bool CheckIfLocationReferenceExist(System.String reference, System.String locationId)
        {
            var locations = this.FetchAll();
            var locationList = locations.Where(x => x.Ref != null && x.Ref.Trim().ToLower() == reference.Trim().ToLower()).ToList();
            bool result = false;

            if (locationList.Count > 0)
            {
                if (string.IsNullOrEmpty(locationId))
                {
                    result = true;
                }
                else
                {
                    if (!locationList.Any(x => x.Id == locationId))
                    {
                        result = true;
                    }
                }
            }

            return result;
        }
    }
}
