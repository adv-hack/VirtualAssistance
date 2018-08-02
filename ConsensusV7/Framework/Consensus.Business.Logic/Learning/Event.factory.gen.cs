using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="EventModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalEventFactory : LocalFactory<LocalEventModel, CourseRecord, String>, IEventFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='EventModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='EventModel' /> instance.
        /// </returns>
        public LocalEventModel Create()
        {
            return new LocalEventModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='EventModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='EventModel' /> instances.
        /// </returns>
        public IEnumerable<LocalEventModel> FetchAll()
        {
            IEnumerable<CourseRecord> recordCollection = this.Provider.DataProvider.Learning.Event.FetchAll();
            foreach (CourseRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalEventModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='EventModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='EventModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='EventModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalEventModel FetchById(String id)
        {
            CourseRecord record = this.Provider.DataProvider.Learning.Event.FetchById(id);
            if (record == null)
                return null;
            return new LocalEventModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Event/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Learning.Event.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='EventModel' /> instances.
        /// </summary>
        /// <param name="managerId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='EventModel' /> instances that match the specified <paramref name='managerId' />.
        /// </returns>
        public IEnumerable<LocalEventModel> FetchAllByManagerId(String managerId)
        {
            IEnumerable<CourseRecord> recordCollection = this.Provider.DataProvider.Learning.Event.FetchAllByPersonId(managerId);
            foreach (CourseRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalEventModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='EventModel' /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='EventModel' /> instances that match the specified <paramref name='productId' />.
        /// </returns>
        public IEnumerable<LocalEventModel> FetchAllByProductId(String productId)
        {
            IEnumerable<CourseRecord> recordCollection = this.Provider.DataProvider.Learning.Event.FetchAllByProductId(productId);
            foreach (CourseRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalEventModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='EventModel' /> instances.
        /// </summary>
        /// <param name="locationId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='EventModel' /> instances that match the specified <paramref name='locationId' />.
        /// </returns>
        public IEnumerable<LocalEventModel> FetchAllByLocationId(String locationId)
        {
            IEnumerable<CourseRecord> recordCollection = this.Provider.DataProvider.Learning.Event.FetchAllByLocId(locationId);
            foreach (CourseRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalEventModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='EventModel' /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='EventModel' /> instances that match the specified <paramref name='organisationId' />.
        /// </returns>
        public IEnumerable<LocalEventModel> FetchAllByOrganisationId(String organisationId)
        {
            IEnumerable<CourseRecord> recordCollection = this.Provider.DataProvider.Learning.Event.FetchAllByOrgId(organisationId);
            foreach (CourseRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalEventModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='EventModel' /> instances.
        /// </summary>
        /// <param name="notesId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='EventModel' /> instances that match the specified <paramref name='notesId' />.
        /// </returns>
        public IEnumerable<LocalEventModel> FetchAllByNotesId(String notesId)
        {
            IEnumerable<CourseRecord> recordCollection = this.Provider.DataProvider.Learning.Event.FetchAllByNotes(notesId);
            foreach (CourseRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalEventModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='EventModel' /> instances.
        /// </summary>
        /// <param name="commissionedId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='EventModel' /> instances that match the specified <paramref name='commissionedId' />.
        /// </returns>
        public IEnumerable<LocalEventModel> FetchAllByCommissionedId(String commissionedId)
        {
            IEnumerable<CourseRecord> recordCollection = this.Provider.DataProvider.Learning.Event.FetchAllBySupplierId(commissionedId);
            foreach (CourseRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalEventModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='EventModel' /> instances.
        /// </summary>
        /// <param name="opportunityId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='EventModel' /> instances that match the specified <paramref name='opportunityId' />.
        /// </returns>
        public IEnumerable<LocalEventModel> FetchAllByOpportunityId(String opportunityId)
        {
            IEnumerable<CourseRecord> recordCollection = this.Provider.DataProvider.Learning.Event.FetchAllByOppId(opportunityId);
            foreach (CourseRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalEventModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='EventModel' /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='EventModel' /> instances that match the specified <paramref name='addressId' />.
        /// </returns>
        public IEnumerable<LocalEventModel> FetchAllByAddressId(String addressId)
        {
            IEnumerable<CourseRecord> recordCollection = this.Provider.DataProvider.Learning.Event.FetchAllByAddId(addressId);
            foreach (CourseRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalEventModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='EventModel' /> instances.
        /// </summary>
        /// <param name="commissionedRoleId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='EventModel' /> instances that match the specified <paramref name='commissionedRoleId' />.
        /// </returns>
        public IEnumerable<LocalEventModel> FetchAllByCommissionedRoleId(String commissionedRoleId)
        {
            IEnumerable<CourseRecord> recordCollection = this.Provider.DataProvider.Learning.Event.FetchAllBySupRoleId(commissionedRoleId);
            foreach (CourseRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalEventModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='EventModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='EventModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalEventModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<CourseRecord> recordCollection = this.Provider.DataProvider.Learning.Event.FetchAllBySelcoSpId(sellingCompanyId);
            foreach (CourseRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalEventModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='EventModel' /> instances.
        /// </summary>
        /// <param name="bookingTermsId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='EventModel' /> instances that match the specified <paramref name='bookingTermsId' />.
        /// </returns>
        public IEnumerable<LocalEventModel> FetchAllByBookingTermsId(String bookingTermsId)
        {
            IEnumerable<CourseRecord> recordCollection = this.Provider.DataProvider.Learning.Event.FetchAllByBktId(bookingTermsId);
            foreach (CourseRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalEventModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='EventModel' /> instances.
        /// </summary>
        /// <param name="contactId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='EventModel' /> instances that match the specified <paramref name='contactId' />.
        /// </returns>
        public IEnumerable<LocalEventModel> FetchAllByContactId(String contactId)
        {
            IEnumerable<CourseRecord> recordCollection = this.Provider.DataProvider.Learning.Event.FetchAllByContprolId(contactId);
            foreach (CourseRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalEventModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='EventModel' /> instances.
        /// </summary>
        /// <param name="supplierOrgId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='EventModel' /> instances that match the specified <paramref name='supplierOrgId' />.
        /// </returns>
        public IEnumerable<LocalEventModel> FetchAllBySupplierOrgId(String supplierOrgId)
        {
            IEnumerable<CourseRecord> recordCollection = this.Provider.DataProvider.Learning.Event.FetchAllByProvOrgId(supplierOrgId);
            foreach (CourseRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalEventModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='EventModel' /> instances.
        /// </summary>
        /// <param name="supplierRoleId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='EventModel' /> instances that match the specified <paramref name='supplierRoleId' />.
        /// </returns>
        public IEnumerable<LocalEventModel> FetchAllBySupplierRoleId(String supplierRoleId)
        {
            IEnumerable<CourseRecord> recordCollection = this.Provider.DataProvider.Learning.Event.FetchAllByProvProleId(supplierRoleId);
            foreach (CourseRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalEventModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='EventModel' /> instances.
        /// </summary>
        /// <param name="fundingOrganisationId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='EventModel' /> instances that match the specified <paramref name='fundingOrganisationId' />.
        /// </returns>
        public IEnumerable<LocalEventModel> FetchAllByFundingOrganisationId(String fundingOrganisationId)
        {
            IEnumerable<CourseRecord> recordCollection = this.Provider.DataProvider.Learning.Event.FetchAllByFundedOrgId(fundingOrganisationId);
            foreach (CourseRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalEventModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='EventModel' /> instances.
        /// </summary>
        /// <param name="intNotesId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='EventModel' /> instances that match the specified <paramref name='intNotesId' />.
        /// </returns>
        public IEnumerable<LocalEventModel> FetchAllByIntNotesId(String intNotesId)
        {
            IEnumerable<CourseRecord> recordCollection = this.Provider.DataProvider.Learning.Event.FetchAllByIntNotes(intNotesId);
            foreach (CourseRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalEventModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='EventModel' /> instances.
        /// </summary>
        /// <param name="mainTrainerId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='EventModel' /> instances that match the specified <paramref name='mainTrainerId' />.
        /// </returns>
        public IEnumerable<LocalEventModel> FetchAllByMainTrainerId(String mainTrainerId)
        {
            IEnumerable<CourseRecord> recordCollection = this.Provider.DataProvider.Learning.Event.FetchAllByMtrProleId(mainTrainerId);
            foreach (CourseRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalEventModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='EventModel' /> instances.
        /// </summary>
        /// <param name="payScheduleHeaderId">
        ///     The value which identifies the <see cref='EventModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='EventModel' /> instances that match the specified <paramref name='payScheduleHeaderId' />.
        /// </returns>
        public IEnumerable<LocalEventModel> FetchAllByPayScheduleHeaderId(Int32? payScheduleHeaderId)
        {
            IEnumerable<CourseRecord> recordCollection = this.Provider.DataProvider.Learning.Event.FetchAllByPshId(payScheduleHeaderId);
            foreach (CourseRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalEventModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Retrieves a single <see cref="!:EventModel" /> instance.
        /// </summary>
        /// <param name="courseParentId">
        ///     The value which identifies the <see cref="!:EventModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instance that match the specified <paramref name="courseParentId" />.
        /// </returns>
        Consensus.Learning.IEventModel IEventFactory.FetchByCourseParentId(System.String courseParentId)
        {
            return this.FetchByCourseParentId(courseParentId);
        }

        void IEventFactory.CalculateCourseNumbers(System.String courseId)
        {
            this.CalculateCourseNumbers(courseId);
        }

        void IEventFactory.CalculateCourseStartEnd(System.String courseId)
        {
            this.CalculateCourseStartEnd(courseId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:EventModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:EventModel" /> instance.
        /// </returns>
        Consensus.Learning.IEventModel IEventFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:EventModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:EventModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> IEventFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:EventModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:EventModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.IEventModel IEventFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IEventFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="managerId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="managerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> IEventFactory.FetchAllByManagerId(System.String managerId)
        {
            return this.FetchAllByManagerId(managerId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> IEventFactory.FetchAllByProductId(System.String productId)
        {
            return this.FetchAllByProductId(productId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="locationId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="locationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> IEventFactory.FetchAllByLocationId(System.String locationId)
        {
            return this.FetchAllByLocationId(locationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> IEventFactory.FetchAllByOrganisationId(System.String organisationId)
        {
            return this.FetchAllByOrganisationId(organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="notesId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="notesId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> IEventFactory.FetchAllByNotesId(System.String notesId)
        {
            return this.FetchAllByNotesId(notesId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="commissionedId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="commissionedId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> IEventFactory.FetchAllByCommissionedId(System.String commissionedId)
        {
            return this.FetchAllByCommissionedId(commissionedId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="opportunityId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="opportunityId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> IEventFactory.FetchAllByOpportunityId(System.String opportunityId)
        {
            return this.FetchAllByOpportunityId(opportunityId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> IEventFactory.FetchAllByAddressId(System.String addressId)
        {
            return this.FetchAllByAddressId(addressId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="commissionedRoleId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="commissionedRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> IEventFactory.FetchAllByCommissionedRoleId(System.String commissionedRoleId)
        {
            return this.FetchAllByCommissionedRoleId(commissionedRoleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> IEventFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="bookingTermsId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="bookingTermsId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> IEventFactory.FetchAllByBookingTermsId(System.String bookingTermsId)
        {
            return this.FetchAllByBookingTermsId(bookingTermsId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="contactId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="contactId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> IEventFactory.FetchAllByContactId(System.String contactId)
        {
            return this.FetchAllByContactId(contactId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="supplierOrgId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="supplierOrgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> IEventFactory.FetchAllBySupplierOrgId(System.String supplierOrgId)
        {
            return this.FetchAllBySupplierOrgId(supplierOrgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="supplierRoleId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="supplierRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> IEventFactory.FetchAllBySupplierRoleId(System.String supplierRoleId)
        {
            return this.FetchAllBySupplierRoleId(supplierRoleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="fundingOrganisationId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="fundingOrganisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> IEventFactory.FetchAllByFundingOrganisationId(System.String fundingOrganisationId)
        {
            return this.FetchAllByFundingOrganisationId(fundingOrganisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="intNotesId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="intNotesId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> IEventFactory.FetchAllByIntNotesId(System.String intNotesId)
        {
            return this.FetchAllByIntNotesId(intNotesId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="mainTrainerId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="mainTrainerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> IEventFactory.FetchAllByMainTrainerId(System.String mainTrainerId)
        {
            return this.FetchAllByMainTrainerId(mainTrainerId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventModel> IEventFactory.FetchAllByPayScheduleHeaderId(System.Nullable<System.Int32> payScheduleHeaderId)
        {
            return this.FetchAllByPayScheduleHeaderId(payScheduleHeaderId);
        }

        #endregion
    }
}
