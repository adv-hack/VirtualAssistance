using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;

namespace Consensus.Common
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class ProfileTrainer : Proxy<IProfileTrainerModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Status" /> member.
        /// </summary>
        private Consensus.Common.Code _status;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Trainer" /> member.
        /// </summary>
        private Consensus.Contact.Trainer _trainer;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "PROF_KEY" field.
        /// </summary>
        public System.String Key
        {
            get { return this.Model.Key; }
            set { this.Model.Key = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_VALUE" field.
        /// </summary>
        public System.String Value
        {
            get { return this.Model.Value; }
            set { this.Model.Value = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_NOTES" field.
        /// </summary>
        public System.String Notes
        {
            get { return this.Model.Notes; }
            set { this.Model.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> Date
        {
            get { return this.Model.Date; }
            set { this.Model.Date = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_VALUE3" field.
        /// </summary>
        public System.String Value3
        {
            get { return this.Model.Value3; }
            set { this.Model.Value3 = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROF_STATUS" field.
        /// </summary>
        public Consensus.Common.Code Status
        {
            get
            {
                if (_status == null && this.Model.Status != null)
                    _status = new Consensus.Common.Code(this.Model.Status);
                if (_status == null)
                    _status = Consensus.Common.Code.Create();
                return _status;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_STATUS" field.
        /// </summary>
        public System.String StatusCode
        {
            get { return this.Model.StatusCode; }
            set { this.Model.StatusCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_VALUE2" field.
        /// </summary>
        public System.String Value2
        {
            get { return this.Model.Value2; }
            set { this.Model.Value2 = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROF_TRAIN_ID" field.
        /// </summary>
        public Consensus.Contact.Trainer Trainer
        {
            get
            {
                if (_trainer == null && this.Model.Trainer != null)
                    _trainer = new Consensus.Contact.Trainer(this.Model.Trainer);
                if (_trainer == null)
                    _trainer = Consensus.Contact.Trainer.Create();
                return _trainer;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_TRAIN_ID" field.
        /// </summary>
        public System.String TrainerId
        {
            get { return this.Model.TrainerId; }
            set { this.Model.TrainerId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal ProfileTrainer(IProfileTrainerModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:ProfileTrainerModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProfileTrainerModel" /> instance.
        /// </returns>
        public static Consensus.Common.ProfileTrainer Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfileTrainer.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ProfileTrainerModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProfileTrainerModel" /> instance.
        /// </returns>
        public static Consensus.Common.ProfileTrainer Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.IProfileTrainerModel model = provider.Common.ProfileTrainer.Create();
            return model == null ? null : new Consensus.Common.ProfileTrainer(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProfileTrainerModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProfileTrainerModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.ProfileTrainer> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfileTrainer.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProfileTrainerModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProfileTrainerModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.ProfileTrainer> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.IProfileTrainerModel> collection = provider.Common.ProfileTrainer.FetchAll();
            return collection.Select(model => new Consensus.Common.ProfileTrainer(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProfileTrainerModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProfileTrainerModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileTrainerModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.ProfileTrainer FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfileTrainer.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProfileTrainerModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProfileTrainerModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileTrainerModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.ProfileTrainer FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.IProfileTrainerModel model = provider.Common.ProfileTrainer.FetchById(id);
            return model == null ? null : new Consensus.Common.ProfileTrainer(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfileTrainer.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Common.ProfileTrainer.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProfileTrainerModel" /> instances.
        /// </summary>
        /// <param name="trainerId">
        ///     The value which identifies the <see cref="!:ProfileTrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileTrainerModel" /> instances that match the specified <paramref name="trainerId" />.
        /// </returns>
        public static IEnumerable<Consensus.Common.ProfileTrainer> FetchAllByTrainerId(System.String trainerId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ProfileTrainer.FetchAllByTrainerId(site,trainerId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProfileTrainerModel" /> instances.
        /// </summary>
        /// <param name="trainerId">
        ///     The value which identifies the <see cref="!:ProfileTrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileTrainerModel" /> instances that match the specified <paramref name="trainerId" />.
        /// </returns>
        public static IEnumerable<Consensus.Common.ProfileTrainer> FetchAllByTrainerId(ConsensusSite site, System.String trainerId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.IProfileTrainerModel> collection = provider.Common.ProfileTrainer.FetchAllByTrainerId(trainerId);
            return collection.Select(model => new Consensus.Common.ProfileTrainer(model));
        }

        #endregion
    }
}
