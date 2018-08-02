using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     The repository collection which pertains to the Contact namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IContactRepositoryCollection : IRepositoryCollection
    {
        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.PersonRecord" /> data structure.
        /// </summary>
        Consensus.Contact.IPersonRepository Person
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.PersonRoleRecord" /> data structure.
        /// </summary>
        Consensus.Contact.IRoleRepository Role
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.OrganisationRecord" /> data structure.
        /// </summary>
        Consensus.Contact.IOrganisationRepository Organisation
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.AddressXrefRecord" /> data structure.
        /// </summary>
        Consensus.Contact.IOrganisationAddressRepository OrganisationAddress
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.AddressRecord" /> data structure.
        /// </summary>
        Consensus.Contact.IAddressRepository Address
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.CountryRecord" /> data structure.
        /// </summary>
        Consensus.Contact.ICountryRepository Country
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.CustomerPackRecord" /> data structure.
        /// </summary>
        Consensus.Contact.ICustomerPackRepository CustomerPack
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.AssociatesRecord" /> data structure.
        /// </summary>
        Consensus.Contact.IAssociateRepository Associate
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.DepartmentRecord" /> data structure.
        /// </summary>
        Consensus.Contact.IOrganisationDepartmentRepository OrganisationDepartment
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.LocationRecord" /> data structure.
        /// </summary>
        Consensus.Contact.ILocationRepository Location
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.CommunicationsXrefRecord" /> data structure.
        /// </summary>
        Consensus.Contact.ICommunications_XrefRepository Communications_Xref
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.CommunicationsRecord" /> data structure.
        /// </summary>
        Consensus.Contact.ICommunicationsRepository Communications
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.AkaRecord" /> data structure.
        /// </summary>
        Consensus.Contact.IAkaRepository Aka
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.GiftaidRecord" /> data structure.
        /// </summary>
        Consensus.Contact.IGiftaidRepository Giftaid
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.TrainerRecord" /> data structure.
        /// </summary>
        Consensus.Contact.ITrainerRepository Trainer
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.TimeSpentRecord" /> data structure.
        /// </summary>
        Consensus.Contact.ITimeSpentRepository TimeSpent
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Contact.TrainProdXrefRecord" /> data structure.
        /// </summary>
        Consensus.Contact.ITrainProdXrefRepository TrainProdXref
        {
            get;
        }
    }
}
