using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="MemberBomModel" /> object.
    /// </summary>
    public partial class LocalMemberBomFactory
    {
        /// <summary>
        /// Check if same grade already exist
        /// </summary>
        /// <param name="parentProdId">Parent product Id</param>
        /// <param name="gradeId">Existing Grade Id</param>
        /// <param name="MBomId">available Grade Id</param>
        /// <returns> returns true if same grade alraedy exists for memebershipProduct - parentProdId</returns>
        public bool CheckIfGradeExist(System.String parentProdId, System.String gradeId, string MBomId)
        {
            var memProdGrades = this.FetchAllByProdParentIdId(parentProdId);
            var GradesList = memProdGrades.Where(x => x.GradeProdId != null && x.GradeProdId.ToLower() == gradeId.ToLower()).ToList();
            bool result = false;

            if (GradesList.Count > 0)
            {
                if (string.IsNullOrEmpty(MBomId))
                {
                    result = true;
                }
                else
                {
                    if (!GradesList.Any(x => x.Id == MBomId))
                    {
                        result = true;
                    }
                }
            }

            return result;
        }
    }
}
