using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    public class LocalSearchModel : LocalModel, SearchModel
    {
        #region fields

        /// <summary>
        ///     The collection of parameters for the search.
        /// </summary>
        private List<LocalSearchParameter> _parameters;

        /// <summary>
        ///     The type of search to be performed.
        /// </summary>
        private SearchTypes _type;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the collection of parameters for the search.
        /// </summary>
        internal List<LocalSearchParameter> Parameters
        {
            get
            {
                if (_parameters == null)
                    _parameters = new List<LocalSearchParameter>();

                return _parameters;
            }
        }

        /// <summary>
        ///    Gets or sets the type of search to be performed.
        /// </summary>
        internal SearchTypes Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public override Boolean IsPersisted
        {
            get { return false; }
        }

        public override Boolean IsModified
        {
            get { return true; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalSearchModel" /> instance.
        /// </summary>
        public LocalSearchModel(LocalProvider provider) : base(provider)
        {

        }

        #endregion

        #region implementations
        
        SearchParameter[] SearchModel.Parameters
        {
            get { return this.Parameters.ToArray(); }
        }

        SearchTypes SearchModel.Type
        {
            get { return this.Type; }
        }

        ISearchParameterable ISearchParameterable.AddParameter(String parameterName, Object value)
        {
            return this.AddParameter(parameterName, value);
        }

        Dictionary<String, Object>[] ISearchesRunnable.Run()
        {
            return this.Run();
        }
        object IRunnable.Run()
        {
            return this.Run();
        }

        IDictionary<string, object> ISearchesRunnable.Serialize()
        {            
            return this.Serialize();
        }

        #endregion

        #region methods

        internal ISearchParameterable AddParameter(String parameterName, Object value)
        {
            LocalSearchParameter parameter = new LocalSearchParameter();
            parameter.Parameter = parameterName;
            parameter.Value = value;

            this.Parameters.Add(parameter);
            return this;
        }

        internal Dictionary<String, Object>[] Run()
        {
            String procedureName = String.Format("spConsensus{0}", this.Type);
            return this.Provider.DataProvider.ExecuteProcedure(procedureName, this.Parameters.ToDictionary(p => p.Parameter, p => p.Value));
        }

        public override void Save()
        {
            throw new NotSupportedException();
        }

        public override void Delete()
        {
            throw new NotSupportedException();
        }
        
        internal IDictionary<string, object> Serialize()
        {
            Dictionary<string, object> result = new Dictionary<string, object>();

            result.Add("Type", this.Type);
            //ArrayList parameters = new ArrayList();
            result.Add("Parameters", this.Parameters);

            return result;
        }
        #endregion
    }
}
