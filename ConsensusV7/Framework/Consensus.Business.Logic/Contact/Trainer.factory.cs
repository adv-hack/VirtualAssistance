using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="TrainerModel" /> object.
    /// </summary>
    public partial class LocalTrainerFactory
    {

        /// <summary>
        /// Check if Person exist or not
        /// </summary>
        /// <param name="proleId">ProleId of Role</param>
        /// <param name="trainerId">Id of Trainer</param>
        /// <param name="syType">Determines whether person is associate or trainer</param>
        /// <returns>Whether Person exist or not</returns>
        public bool CheckIfPersonIsAssociatedWithTrainer(System.String proleId, System.String trainerId, System.String syType)
        {
            var trainers = this.FetchAll();
            var trainerList = trainers.Where(x => x.RoleId != null && x.RoleId.Trim().ToLower() == proleId.Trim().ToLower() && x.AinSyType == Convert.ToInt32(syType)).ToList();
            bool result = false;

            if (trainerList.Count > 0)
            {
                if (string.IsNullOrEmpty(trainerId))
                {
                    result = true;
                }
                else
                {
                    if (!trainerList.Any(x => x.Id == trainerId))
                    {
                        result = true;
                    }
                }
            }

            return result;
        }

    }
}
