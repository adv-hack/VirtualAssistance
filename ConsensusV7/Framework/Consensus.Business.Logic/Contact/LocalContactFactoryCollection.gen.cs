using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents a collection of factory instances which are responsible for the instantiation of the business models in the Contact namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalContactFactoryCollection : LocalFactoryCollection, IContactFactoryCollection
    {
        #region fields

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="PersonModel" /> objects.
        /// </summary>
        private LocalPersonFactory _person;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="RoleModel" /> objects.
        /// </summary>
        private LocalRoleFactory _role;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="OrganisationModel" /> objects.
        /// </summary>
        private LocalOrganisationFactory _organisation;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="OrganisationAddressModel" /> objects.
        /// </summary>
        private LocalOrganisationAddressFactory _organisationAddress;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="AddressModel" /> objects.
        /// </summary>
        private LocalAddressFactory _address;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="CountryModel" /> objects.
        /// </summary>
        private LocalCountryFactory _country;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="CustomerPackModel" /> objects.
        /// </summary>
        private LocalCustomerPackFactory _customerPack;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="AssociateModel" /> objects.
        /// </summary>
        private LocalAssociateFactory _associate;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="OrganisationDepartmentModel" /> objects.
        /// </summary>
        private LocalOrganisationDepartmentFactory _organisationDepartment;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="LocationModel" /> objects.
        /// </summary>
        private LocalLocationFactory _location;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="Communications_XrefModel" /> objects.
        /// </summary>
        private LocalCommunications_XrefFactory _communications_Xref;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="CommunicationsModel" /> objects.
        /// </summary>
        private LocalCommunicationsFactory _communications;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="AkaModel" /> objects.
        /// </summary>
        private LocalAkaFactory _aka;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="GiftaidModel" /> objects.
        /// </summary>
        private LocalGiftaidFactory _giftaid;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="TrainerModel" /> objects.
        /// </summary>
        private LocalTrainerFactory _trainer;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="TimeSpentModel" /> objects.
        /// </summary>
        private LocalTimeSpentFactory _timeSpent;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="TrainProdXrefModel" /> objects.
        /// </summary>
        private LocalTrainProdXrefFactory _trainProdXref;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="CommunicationsRoleModel" /> objects.
        /// </summary>
        private LocalCommunicationsRoleFactory _communicationsRole;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="PersonModel" /> objects.
        /// </summary>
        public LocalPersonFactory Person
        {
            get { return LocalFactory.Create(this.Provider, ref _person); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="RoleModel" /> objects.
        /// </summary>
        public LocalRoleFactory Role
        {
            get { return LocalFactory.Create(this.Provider, ref _role); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="OrganisationModel" /> objects.
        /// </summary>
        public LocalOrganisationFactory Organisation
        {
            get { return LocalFactory.Create(this.Provider, ref _organisation); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="OrganisationAddressModel" /> objects.
        /// </summary>
        public LocalOrganisationAddressFactory OrganisationAddress
        {
            get { return LocalFactory.Create(this.Provider, ref _organisationAddress); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="AddressModel" /> objects.
        /// </summary>
        public LocalAddressFactory Address
        {
            get { return LocalFactory.Create(this.Provider, ref _address); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="CountryModel" /> objects.
        /// </summary>
        public LocalCountryFactory Country
        {
            get { return LocalFactory.Create(this.Provider, ref _country); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="CustomerPackModel" /> objects.
        /// </summary>
        public LocalCustomerPackFactory CustomerPack
        {
            get { return LocalFactory.Create(this.Provider, ref _customerPack); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="AssociateModel" /> objects.
        /// </summary>
        public LocalAssociateFactory Associate
        {
            get { return LocalFactory.Create(this.Provider, ref _associate); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="OrganisationDepartmentModel" /> objects.
        /// </summary>
        public LocalOrganisationDepartmentFactory OrganisationDepartment
        {
            get { return LocalFactory.Create(this.Provider, ref _organisationDepartment); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="LocationModel" /> objects.
        /// </summary>
        public LocalLocationFactory Location
        {
            get { return LocalFactory.Create(this.Provider, ref _location); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="Communications_XrefModel" /> objects.
        /// </summary>
        public LocalCommunications_XrefFactory Communications_Xref
        {
            get { return LocalFactory.Create(this.Provider, ref _communications_Xref); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="CommunicationsModel" /> objects.
        /// </summary>
        public LocalCommunicationsFactory Communications
        {
            get { return LocalFactory.Create(this.Provider, ref _communications); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="AkaModel" /> objects.
        /// </summary>
        public LocalAkaFactory Aka
        {
            get { return LocalFactory.Create(this.Provider, ref _aka); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="GiftaidModel" /> objects.
        /// </summary>
        public LocalGiftaidFactory Giftaid
        {
            get { return LocalFactory.Create(this.Provider, ref _giftaid); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="TrainerModel" /> objects.
        /// </summary>
        public LocalTrainerFactory Trainer
        {
            get { return LocalFactory.Create(this.Provider, ref _trainer); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="TimeSpentModel" /> objects.
        /// </summary>
        public LocalTimeSpentFactory TimeSpent
        {
            get { return LocalFactory.Create(this.Provider, ref _timeSpent); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="TrainProdXrefModel" /> objects.
        /// </summary>
        public LocalTrainProdXrefFactory TrainProdXref
        {
            get { return LocalFactory.Create(this.Provider, ref _trainProdXref); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="CommunicationsRoleModel" /> objects.
        /// </summary>
        public LocalCommunicationsRoleFactory CommunicationsRole
        {
            get { return LocalFactory.Create(this.Provider, ref _communicationsRole); }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PersonModel" /> objects.
        /// </summary>
        Consensus.Contact.IPersonFactory IContactFactoryCollection.Person
        {
            get { return this.Person; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:RoleModel" /> objects.
        /// </summary>
        Consensus.Contact.IRoleFactory IContactFactoryCollection.Role
        {
            get { return this.Role; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:OrganisationModel" /> objects.
        /// </summary>
        Consensus.Contact.IOrganisationFactory IContactFactoryCollection.Organisation
        {
            get { return this.Organisation; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:OrganisationAddressModel" /> objects.
        /// </summary>
        Consensus.Contact.IOrganisationAddressFactory IContactFactoryCollection.OrganisationAddress
        {
            get { return this.OrganisationAddress; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:AddressModel" /> objects.
        /// </summary>
        Consensus.Contact.IAddressFactory IContactFactoryCollection.Address
        {
            get { return this.Address; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:CountryModel" /> objects.
        /// </summary>
        Consensus.Contact.ICountryFactory IContactFactoryCollection.Country
        {
            get { return this.Country; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:CustomerPackModel" /> objects.
        /// </summary>
        Consensus.Contact.ICustomerPackFactory IContactFactoryCollection.CustomerPack
        {
            get { return this.CustomerPack; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:AssociateModel" /> objects.
        /// </summary>
        Consensus.Contact.IAssociateFactory IContactFactoryCollection.Associate
        {
            get { return this.Associate; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:OrganisationDepartmentModel" /> objects.
        /// </summary>
        Consensus.Contact.IOrganisationDepartmentFactory IContactFactoryCollection.OrganisationDepartment
        {
            get { return this.OrganisationDepartment; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:LocationModel" /> objects.
        /// </summary>
        Consensus.Contact.ILocationFactory IContactFactoryCollection.Location
        {
            get { return this.Location; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:Communications_XrefModel" /> objects.
        /// </summary>
        Consensus.Contact.ICommunications_XrefFactory IContactFactoryCollection.Communications_Xref
        {
            get { return this.Communications_Xref; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:CommunicationsModel" /> objects.
        /// </summary>
        Consensus.Contact.ICommunicationsFactory IContactFactoryCollection.Communications
        {
            get { return this.Communications; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:AkaModel" /> objects.
        /// </summary>
        Consensus.Contact.IAkaFactory IContactFactoryCollection.Aka
        {
            get { return this.Aka; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:GiftaidModel" /> objects.
        /// </summary>
        Consensus.Contact.IGiftaidFactory IContactFactoryCollection.Giftaid
        {
            get { return this.Giftaid; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:TrainerModel" /> objects.
        /// </summary>
        Consensus.Contact.ITrainerFactory IContactFactoryCollection.Trainer
        {
            get { return this.Trainer; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:TimeSpentModel" /> objects.
        /// </summary>
        Consensus.Contact.ITimeSpentFactory IContactFactoryCollection.TimeSpent
        {
            get { return this.TimeSpent; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:TrainProdXrefModel" /> objects.
        /// </summary>
        Consensus.Contact.ITrainProdXrefFactory IContactFactoryCollection.TrainProdXref
        {
            get { return this.TrainProdXref; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:CommunicationsRoleModel" /> objects.
        /// </summary>
        Consensus.Contact.ICommunicationsRoleFactory IContactFactoryCollection.CommunicationsRole
        {
            get { return this.CommunicationsRole; }
        }

        #endregion
    }
}
