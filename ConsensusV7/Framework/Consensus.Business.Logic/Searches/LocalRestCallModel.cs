using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Consensus.Searches
{
    public class LocalRestCallModel : LocalModel, RestCallModel, IRestCallSerializable
    {
        #region fields

        /// <summary>
        ///     The collection of parameters for the search.
        /// </summary>
        private List<LocalRestCallParameter> _parameters;

        /// <summary>
        ///     The name of the container the model exists in
        /// </summary>
        private string _container;

        /// <summary>
        ///     The name of the model the method exists in
        /// </summary>
        private string _modelName;

        /// <summary>
        ///     The method name to call
        /// </summary>
        private String _methodName;

        /// <summary>
        ///     Serialisation controls for when this is run via a rest call
        /// </summary>
        private RestCallSerialization _serialization;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the collection of parameters for the search.
        /// </summary>
        internal List<LocalRestCallParameter> Parameters
        {
            get
            {
                if (_parameters == null)
                    _parameters = new List<LocalRestCallParameter>();

                return _parameters;
            }
        }

        /// <summary>
        ///     The name of the container the model exists in
        /// </summary>
        internal String Container
        {
            get { return _container; }
            set { _container = value; }
        }

        /// <summary>
        ///    The name of the model the method exists in
        /// </summary>
        internal String ModelName
        {
            get { return _modelName; }
            set { _modelName = value; }
        }

        /// <summary>
        ///    The method name to call
        /// </summary>
        internal String MethodName
        {
            get { return _methodName; }
            set { _methodName = value; }
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
        ///     Initialises a new <see cref="LocalRestCallModel" /> instance.
        /// </summary>
        public LocalRestCallModel(LocalProvider provider) : base(provider)
        {

        }

        #endregion

        #region implementations
        
        RestCallParameter[] RestCallModel.Parameters
        {
            get { return this.Parameters.ToArray(); }
        }

        string RestCallModel.Container
        {
            get { return this.Container; }
            set { this.Container = value; }
        }

        string RestCallModel.ModelName
        {
            get { return this.ModelName; }
            set { this.ModelName = value; }
        }

        string RestCallModel.MethodName
        {
            get { return this.MethodName; }
            set { this.MethodName = value; }
        }

        public RestCallSerialization Serialization
        {
            get
            {
                if (_serialization == null)
                    _serialization = new LocalRestCallSerialization();
                return _serialization;
            }
        }

        IDictionary<string, object> IRestCallSerializable.Serialize()
        {
            return this.Serialize();
        }
        
        #endregion

        #region methods

        public void AddParameter(String parameterName, Object value)
        {
            LocalRestCallParameter parameter = new LocalRestCallParameter();
            parameter.Parameter = parameterName;
            parameter.Value = value;

            this.Parameters.Add(parameter);
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
            
            result.Add("Container", this.Container);
            result.Add("ModelName", this.ModelName);
            result.Add("MethodName", this.MethodName);
            result.Add("Parameters", this.Parameters);
            result.Add("Serialization", this.Serialization);
            
            return result;
        }
        

        #endregion
    }
}
