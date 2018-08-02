using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProfileCoursesModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalProfileCoursesFactory : LocalFactory<LocalProfileCoursesModel, ProfileRecord, String>, IProfileCoursesFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ProfileCoursesModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ProfileCoursesModel' /> instance.
        /// </returns>
        public LocalProfileCoursesModel Create()
        {
            return new LocalProfileCoursesModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ProfileCoursesModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ProfileCoursesModel' /> instances.
        /// </returns>
        public IEnumerable<LocalProfileCoursesModel> FetchAll()
        {
            IEnumerable<ProfileRecord> recordCollection = this.Provider.DataProvider.Common.Profile.FetchAll();
            foreach (ProfileRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProfileCoursesModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ProfileCoursesModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ProfileCoursesModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProfileCoursesModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalProfileCoursesModel FetchById(String id)
        {
            ProfileRecord record = this.Provider.DataProvider.Common.Profile.FetchById(id);
            if (record == null)
                return null;
            return new LocalProfileCoursesModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='ProfileCourses/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Common.Profile.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProfileCoursesModel' /> instances.
        /// </summary>
        /// <param name="coursesId">
        ///     The value which identifies the <see cref='ProfileCoursesModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProfileCoursesModel' /> instances that match the specified <paramref name='coursesId' />.
        /// </returns>
        public IEnumerable<LocalProfileCoursesModel> FetchAllByCoursesId(String coursesId)
        {
            IEnumerable<ProfileRecord> recordCollection = this.Provider.DataProvider.Common.Profile.FetchAllByCourseId(coursesId);
            foreach (ProfileRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProfileCoursesModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ProfileCoursesModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProfileCoursesModel" /> instance.
        /// </returns>
        Consensus.Common.IProfileCoursesModel IProfileCoursesFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProfileCoursesModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProfileCoursesModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IProfileCoursesModel> IProfileCoursesFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProfileCoursesModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProfileCoursesModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileCoursesModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.IProfileCoursesModel IProfileCoursesFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IProfileCoursesFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProfileCoursesModel" /> instances.
        /// </summary>
        /// <param name="coursesId">
        ///     The value which identifies the <see cref="!:ProfileCoursesModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileCoursesModel" /> instances that match the specified <paramref name="coursesId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IProfileCoursesModel> IProfileCoursesFactory.FetchAllByCoursesId(System.String coursesId)
        {
            return this.FetchAllByCoursesId(coursesId);
        }

        #endregion
    }
}
