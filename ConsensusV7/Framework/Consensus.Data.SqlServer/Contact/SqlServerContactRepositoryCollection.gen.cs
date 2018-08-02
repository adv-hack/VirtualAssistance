using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Microsoft SQL Server repository collection which pertains to the Contact namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerContactRepositoryCollection : SqlServerRepositoryCollection, IContactRepositoryCollection
    {
        #region fields

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PersonRecord" /> data structure.
        /// </summary>
        private SqlServerPersonRepository _person;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PersonRoleRecord" /> data structure.
        /// </summary>
        private SqlServerRoleRepository _role;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="OrganisationRecord" /> data structure.
        /// </summary>
        private SqlServerOrganisationRepository _organisation;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="AddressXrefRecord" /> data structure.
        /// </summary>
        private SqlServerOrganisationAddressRepository _organisationAddress;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="AddressRecord" /> data structure.
        /// </summary>
        private SqlServerAddressRepository _address;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="CountryRecord" /> data structure.
        /// </summary>
        private SqlServerCountryRepository _country;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="CustomerPackRecord" /> data structure.
        /// </summary>
        private SqlServerCustomerPackRepository _customerPack;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="AssociatesRecord" /> data structure.
        /// </summary>
        private SqlServerAssociateRepository _associate;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="DepartmentRecord" /> data structure.
        /// </summary>
        private SqlServerOrganisationDepartmentRepository _organisationDepartment;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="LocationRecord" /> data structure.
        /// </summary>
        private SqlServerLocationRepository _location;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="CommunicationsXrefRecord" /> data structure.
        /// </summary>
        private SqlServerCommunications_XrefRepository _communications_Xref;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="CommunicationsRecord" /> data structure.
        /// </summary>
        private SqlServerCommunicationsRepository _communications;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="AkaRecord" /> data structure.
        /// </summary>
        private SqlServerAkaRepository _aka;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="GiftaidRecord" /> data structure.
        /// </summary>
        private SqlServerGiftaidRepository _giftaid;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="TrainerRecord" /> data structure.
        /// </summary>
        private SqlServerTrainerRepository _trainer;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="TimeSpentRecord" /> data structure.
        /// </summary>
        private SqlServerTimeSpentRepository _timeSpent;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="TrainProdXrefRecord" /> data structure.
        /// </summary>
        private SqlServerTrainProdXrefRepository _trainProdXref;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PersonRecord" /> data structure.
        /// </summary>
        public SqlServerPersonRepository Person
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerPersonRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _person);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PersonRoleRecord" /> data structure.
        /// </summary>
        public SqlServerRoleRepository Role
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerRoleRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _role);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="OrganisationRecord" /> data structure.
        /// </summary>
        public SqlServerOrganisationRepository Organisation
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerOrganisationRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _organisation);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="AddressXrefRecord" /> data structure.
        /// </summary>
        public SqlServerOrganisationAddressRepository OrganisationAddress
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerOrganisationAddressRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _organisationAddress);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="AddressRecord" /> data structure.
        /// </summary>
        public SqlServerAddressRepository Address
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerAddressRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _address);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="CountryRecord" /> data structure.
        /// </summary>
        public SqlServerCountryRepository Country
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerCountryRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _country);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="CustomerPackRecord" /> data structure.
        /// </summary>
        public SqlServerCustomerPackRepository CustomerPack
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerCustomerPackRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _customerPack);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="AssociatesRecord" /> data structure.
        /// </summary>
        public SqlServerAssociateRepository Associate
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerAssociateRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _associate);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="DepartmentRecord" /> data structure.
        /// </summary>
        public SqlServerOrganisationDepartmentRepository OrganisationDepartment
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerOrganisationDepartmentRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _organisationDepartment);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="LocationRecord" /> data structure.
        /// </summary>
        public SqlServerLocationRepository Location
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerLocationRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _location);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="CommunicationsXrefRecord" /> data structure.
        /// </summary>
        public SqlServerCommunications_XrefRepository Communications_Xref
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerCommunications_XrefRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _communications_Xref);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="CommunicationsRecord" /> data structure.
        /// </summary>
        public SqlServerCommunicationsRepository Communications
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerCommunicationsRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _communications);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="AkaRecord" /> data structure.
        /// </summary>
        public SqlServerAkaRepository Aka
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerAkaRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _aka);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="GiftaidRecord" /> data structure.
        /// </summary>
        public SqlServerGiftaidRepository Giftaid
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerGiftaidRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _giftaid);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="TrainerRecord" /> data structure.
        /// </summary>
        public SqlServerTrainerRepository Trainer
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerTrainerRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _trainer);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="TimeSpentRecord" /> data structure.
        /// </summary>
        public SqlServerTimeSpentRepository TimeSpent
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerTimeSpentRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _timeSpent);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="TrainProdXrefRecord" /> data structure.
        /// </summary>
        public SqlServerTrainProdXrefRepository TrainProdXref
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerTrainProdXrefRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _trainProdXref);
            }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Partial method that can be implemented elsewhere in the partial class to allow the provider to be amended for a particular instance.
        /// </summary>
        /// <param name="SqlServerDataRepositoryType">
        ///     The type of the SqlServerDataRepository instance being created.
        /// </param>
        /// <param name="provider">
        ///     The default provider. A new provider may be assigned to this parameter in an implementation, if required.
        /// </param>
        partial void OverrideProvider(Type SqlServerDataRepositoryType, ref SqlServerProvider provider);

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.PersonRecord" /> data structure.
        /// </summary>
        Consensus.Contact.IPersonRepository IContactRepositoryCollection.Person
        {
            get { return this.Person; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.PersonRoleRecord" /> data structure.
        /// </summary>
        Consensus.Contact.IRoleRepository IContactRepositoryCollection.Role
        {
            get { return this.Role; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.OrganisationRecord" /> data structure.
        /// </summary>
        Consensus.Contact.IOrganisationRepository IContactRepositoryCollection.Organisation
        {
            get { return this.Organisation; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.AddressXrefRecord" /> data structure.
        /// </summary>
        Consensus.Contact.IOrganisationAddressRepository IContactRepositoryCollection.OrganisationAddress
        {
            get { return this.OrganisationAddress; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.AddressRecord" /> data structure.
        /// </summary>
        Consensus.Contact.IAddressRepository IContactRepositoryCollection.Address
        {
            get { return this.Address; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.CountryRecord" /> data structure.
        /// </summary>
        Consensus.Contact.ICountryRepository IContactRepositoryCollection.Country
        {
            get { return this.Country; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.CustomerPackRecord" /> data structure.
        /// </summary>
        Consensus.Contact.ICustomerPackRepository IContactRepositoryCollection.CustomerPack
        {
            get { return this.CustomerPack; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.AssociatesRecord" /> data structure.
        /// </summary>
        Consensus.Contact.IAssociateRepository IContactRepositoryCollection.Associate
        {
            get { return this.Associate; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.DepartmentRecord" /> data structure.
        /// </summary>
        Consensus.Contact.IOrganisationDepartmentRepository IContactRepositoryCollection.OrganisationDepartment
        {
            get { return this.OrganisationDepartment; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.LocationRecord" /> data structure.
        /// </summary>
        Consensus.Contact.ILocationRepository IContactRepositoryCollection.Location
        {
            get { return this.Location; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.CommunicationsXrefRecord" /> data structure.
        /// </summary>
        Consensus.Contact.ICommunications_XrefRepository IContactRepositoryCollection.Communications_Xref
        {
            get { return this.Communications_Xref; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.CommunicationsRecord" /> data structure.
        /// </summary>
        Consensus.Contact.ICommunicationsRepository IContactRepositoryCollection.Communications
        {
            get { return this.Communications; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.AkaRecord" /> data structure.
        /// </summary>
        Consensus.Contact.IAkaRepository IContactRepositoryCollection.Aka
        {
            get { return this.Aka; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.GiftaidRecord" /> data structure.
        /// </summary>
        Consensus.Contact.IGiftaidRepository IContactRepositoryCollection.Giftaid
        {
            get { return this.Giftaid; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.TrainerRecord" /> data structure.
        /// </summary>
        Consensus.Contact.ITrainerRepository IContactRepositoryCollection.Trainer
        {
            get { return this.Trainer; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.TimeSpentRecord" /> data structure.
        /// </summary>
        Consensus.Contact.ITimeSpentRepository IContactRepositoryCollection.TimeSpent
        {
            get { return this.TimeSpent; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.TrainProdXrefRecord" /> data structure.
        /// </summary>
        Consensus.Contact.ITrainProdXrefRepository IContactRepositoryCollection.TrainProdXref
        {
            get { return this.TrainProdXref; }
        }

        #endregion
    }
}
