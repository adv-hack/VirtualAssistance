using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Literature : Proxy<ILiteratureModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="LtId" /> member.
        /// </summary>
        private Consensus.Document.LetterTemplate _ltId;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="LiteratureId" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Document.PackXref, Consensus.Document.IPackXrefModel> _literatureId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "LIT_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_COST" field.
        /// </summary>
        public System.Nullable<System.Double> Cost
        {
            get { return this.Model.Cost; }
            set { this.Model.Cost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_TEMPLATE" field.
        /// </summary>
        public System.String Template
        {
            get { return this.Model.Template; }
            set { this.Model.Template = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_EXAM" field.
        /// </summary>
        public System.Nullable<System.Byte> Exam
        {
            get { return this.Model.Exam; }
            set { this.Model.Exam = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_ATTENDANCE" field.
        /// </summary>
        public System.Nullable<System.Byte> Attendance
        {
            get { return this.Model.Attendance; }
            set { this.Model.Attendance = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_TYPE" field.
        /// </summary>
        public System.Nullable<System.Byte> Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_CURRENT" field.
        /// </summary>
        public System.Nullable<System.Byte> Current
        {
            get { return this.Model.Current; }
            set { this.Model.Current = value; }
        }

        /// <summary>
        ///     Gets the The value of the "LIT_LT_ID" field.
        /// </summary>
        public Consensus.Document.LetterTemplate LtId
        {
            get
            {
                if (_ltId == null && this.Model.LtId != null)
                    _ltId = new Consensus.Document.LetterTemplate(this.Model.LtId);
                if (_ltId == null)
                    _ltId = Consensus.Document.LetterTemplate.Create();
                return _ltId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LIT_LT_ID" field.
        /// </summary>
        public System.String LtIdId
        {
            get { return this.Model.LtIdId; }
            set { this.Model.LtIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_SEND_OVERRIDE" field.
        /// </summary>
        public System.Nullable<System.Byte> SendOverride
        {
            get { return this.Model.SendOverride; }
            set { this.Model.SendOverride = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_EMAIL_ONLY" field.
        /// </summary>
        public System.Byte EmailOnly
        {
            get { return this.Model.EmailOnly; }
            set { this.Model.EmailOnly = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_PRINT_ONLY" field.
        /// </summary>
        public System.Byte PrintOnly
        {
            get { return this.Model.PrintOnly; }
            set { this.Model.PrintOnly = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIT_FILE_NAME" field.
        /// </summary>
        public System.String FileName
        {
            get { return this.Model.FileName; }
            set { this.Model.FileName = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackXrefModel" /> instances that reference this <see cref="!:LiteratureModel" />.
        /// </summary>
        public Collection<Consensus.Document.PackXref> LiteratureId
        {
            get
            {
                if (_literatureId == null)
                    _literatureId = new ProxyCollection<Consensus.Document.PackXref, Consensus.Document.IPackXrefModel>(this.Model.LiteratureId, model => new Consensus.Document.PackXref(model));
                return _literatureId;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Literature(ILiteratureModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:LiteratureModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LiteratureModel" /> instance.
        /// </returns>
        public static Consensus.Document.Literature Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Literature.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:LiteratureModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LiteratureModel" /> instance.
        /// </returns>
        public static Consensus.Document.Literature Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.ILiteratureModel model = provider.Document.Literature.Create();
            return model == null ? null : new Consensus.Document.Literature(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LiteratureModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LiteratureModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.Literature> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Literature.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LiteratureModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LiteratureModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.Literature> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.ILiteratureModel> collection = provider.Document.Literature.FetchAll();
            return collection.Select(model => new Consensus.Document.Literature(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LiteratureModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LiteratureModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LiteratureModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.Literature FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Literature.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LiteratureModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LiteratureModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LiteratureModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.Literature FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.ILiteratureModel model = provider.Document.Literature.FetchById(id);
            return model == null ? null : new Consensus.Document.Literature(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Literature.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Document.Literature.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LiteratureModel" /> instances.
        /// </summary>
        /// <param name="ltIdId">
        ///     The value which identifies the <see cref="!:LiteratureModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LiteratureModel" /> instances that match the specified <paramref name="ltIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.Literature> FetchAllByLtIdId(System.String ltIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Literature.FetchAllByLtIdId(site,ltIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LiteratureModel" /> instances.
        /// </summary>
        /// <param name="ltIdId">
        ///     The value which identifies the <see cref="!:LiteratureModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LiteratureModel" /> instances that match the specified <paramref name="ltIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Document.Literature> FetchAllByLtIdId(ConsensusSite site, System.String ltIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.ILiteratureModel> collection = provider.Document.Literature.FetchAllByLtIdId(ltIdId);
            return collection.Select(model => new Consensus.Document.Literature(model));
        }

        #endregion
    }
}
