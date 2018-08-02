using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
    public interface IContactFactoryCollection : IFactoryCollection
    {
        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PersonModel" /> objects.
        /// </summary>
        Consensus.Contact.IPersonFactory Person
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:RoleModel" /> objects.
        /// </summary>
        Consensus.Contact.IRoleFactory Role
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:OrganisationModel" /> objects.
        /// </summary>
        Consensus.Contact.IOrganisationFactory Organisation
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:OrganisationAddressModel" /> objects.
        /// </summary>
        Consensus.Contact.IOrganisationAddressFactory OrganisationAddress
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:AddressModel" /> objects.
        /// </summary>
        Consensus.Contact.IAddressFactory Address
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:CountryModel" /> objects.
        /// </summary>
        Consensus.Contact.ICountryFactory Country
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:CustomerPackModel" /> objects.
        /// </summary>
        Consensus.Contact.ICustomerPackFactory CustomerPack
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:AssociateModel" /> objects.
        /// </summary>
        Consensus.Contact.IAssociateFactory Associate
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:OrganisationDepartmentModel" /> objects.
        /// </summary>
        Consensus.Contact.IOrganisationDepartmentFactory OrganisationDepartment
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:LocationModel" /> objects.
        /// </summary>
        Consensus.Contact.ILocationFactory Location
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:Communications_XrefModel" /> objects.
        /// </summary>
        Consensus.Contact.ICommunications_XrefFactory Communications_Xref
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:CommunicationsModel" /> objects.
        /// </summary>
        Consensus.Contact.ICommunicationsFactory Communications
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:AkaModel" /> objects.
        /// </summary>
        Consensus.Contact.IAkaFactory Aka
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:GiftaidModel" /> objects.
        /// </summary>
        Consensus.Contact.IGiftaidFactory Giftaid
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:TrainerModel" /> objects.
        /// </summary>
        Consensus.Contact.ITrainerFactory Trainer
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:TimeSpentModel" /> objects.
        /// </summary>
        Consensus.Contact.ITimeSpentFactory TimeSpent
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:TrainProdXrefModel" /> objects.
        /// </summary>
        Consensus.Contact.ITrainProdXrefFactory TrainProdXref
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:CommunicationsRoleModel" /> objects.
        /// </summary>
        Consensus.Contact.ICommunicationsRoleFactory CommunicationsRole
        {
            get;
        }
    }
}
