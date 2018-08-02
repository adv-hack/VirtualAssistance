using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Marketing
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SaqFilterField : Proxy<ISaqFilterFieldModel, Int64>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SaqParameterFilterField" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.SaqParameter, Consensus.Marketing.ISaqParameterModel> _saqParameterFilterField;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "F_DISPLAY_ORDER" field.
        /// </summary>
        public System.Int16 DisplayOrder
        {
            get { return this.Model.DisplayOrder; }
            set { this.Model.DisplayOrder = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_DISPLAY" field.
        /// </summary>
        public System.Byte Display
        {
            get { return this.Model.Display; }
            set { this.Model.Display = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_TABLE_PREFIX" field.
        /// </summary>
        public System.String TablePrefix
        {
            get { return this.Model.TablePrefix; }
            set { this.Model.TablePrefix = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_TABLE_DESC" field.
        /// </summary>
        public System.String TableDesc
        {
            get { return this.Model.TableDesc; }
            set { this.Model.TableDesc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_COLUMN_NAME" field.
        /// </summary>
        public System.String ColumnName
        {
            get { return this.Model.ColumnName; }
            set { this.Model.ColumnName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_COLUMN_TYPE" field.
        /// </summary>
        public System.String ColumnType
        {
            get { return this.Model.ColumnType; }
            set { this.Model.ColumnType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_COLUMN_LENGTH" field.
        /// </summary>
        public System.Nullable<System.Int32> ColumnLength
        {
            get { return this.Model.ColumnLength; }
            set { this.Model.ColumnLength = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_COLUMN_DESC" field.
        /// </summary>
        public System.String ColumnDesc
        {
            get { return this.Model.ColumnDesc; }
            set { this.Model.ColumnDesc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_CODE_LOOKUP" field.
        /// </summary>
        public System.Byte CodeLookup
        {
            get { return this.Model.CodeLookup; }
            set { this.Model.CodeLookup = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_CODE_HEADER" field.
        /// </summary>
        public System.String CodeHeader
        {
            get { return this.Model.CodeHeader; }
            set { this.Model.CodeHeader = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_CODE_VAL" field.
        /// </summary>
        public System.Nullable<System.Byte> CodeVal
        {
            get { return this.Model.CodeVal; }
            set { this.Model.CodeVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_ID_IN_LOOKUP" field.
        /// </summary>
        public System.Byte IdInLookup
        {
            get { return this.Model.IdInLookup; }
            set { this.Model.IdInLookup = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "F_DEFAULT_OPERAND" field.
        /// </summary>
        public System.String DefaultOperand
        {
            get { return this.Model.DefaultOperand; }
            set { this.Model.DefaultOperand = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqParameterModel" /> instances that reference this <see cref="!:SaqFilterFieldModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.SaqParameter> SaqParameterFilterField
        {
            get
            {
                if (_saqParameterFilterField == null)
                    _saqParameterFilterField = new ProxyCollection<Consensus.Marketing.SaqParameter, Consensus.Marketing.ISaqParameterModel>(this.Model.SaqParameterFilterField, model => new Consensus.Marketing.SaqParameter(model));
                return _saqParameterFilterField;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal SaqFilterField(ISaqFilterFieldModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:SaqFilterFieldModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SaqFilterFieldModel" /> instance.
        /// </returns>
        public static Consensus.Marketing.SaqFilterField Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqFilterField.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:SaqFilterFieldModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SaqFilterFieldModel" /> instance.
        /// </returns>
        public static Consensus.Marketing.SaqFilterField Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Marketing.ISaqFilterFieldModel model = provider.Marketing.SaqFilterField.Create();
            return model == null ? null : new Consensus.Marketing.SaqFilterField(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SaqFilterFieldModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SaqFilterFieldModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqFilterField> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqFilterField.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SaqFilterFieldModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SaqFilterFieldModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqFilterField> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.ISaqFilterFieldModel> collection = provider.Marketing.SaqFilterField.FetchAll();
            return collection.Select(model => new Consensus.Marketing.SaqFilterField(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SaqFilterFieldModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SaqFilterFieldModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqFilterFieldModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Marketing.SaqFilterField FetchById(System.Int64 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqFilterField.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SaqFilterFieldModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SaqFilterFieldModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqFilterFieldModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Marketing.SaqFilterField FetchById(ConsensusSite site, System.Int64 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Marketing.ISaqFilterFieldModel model = provider.Marketing.SaqFilterField.FetchById(id);
            return model == null ? null : new Consensus.Marketing.SaqFilterField(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqFilterField.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Marketing.SaqFilterField.GetTableName();
        }

        #endregion
    }
}
