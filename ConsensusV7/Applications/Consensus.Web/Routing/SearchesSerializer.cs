using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Web;
using System.Web.Script.Serialization;

namespace Consensus.Web
{
    class SearchesSerializer : JavaScriptConverter
    {
        private static SearchesSerializer _instance;
        private static JavaScriptSerializer _serializer;

        /// <summary>
        ///    Gets the singleton instance of the serializer.
        /// </summary>
        public static SearchesSerializer Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SearchesSerializer();
                return _instance;
            }
        }

        /// <summary>
        ///     Gets the serializer for converting Searches, Queries and RestCalls to and from JSON
        /// </summary>
        public static JavaScriptSerializer Serializer
        {
            get
            {
                if (_serializer == null)
                {
                    _serializer = new JavaScriptSerializer();
                    _serializer.RegisterConverters(new JavaScriptConverter[] { Instance });
                }
                return _serializer;
            }
        }

        public override IEnumerable<Type> SupportedTypes
        {
            get
            {
                return new Type[] 
                {
                    typeof(Consensus.Searches.Query),
                    typeof(Consensus.Searches.Search),
                    typeof(Consensus.Searches.RestCall)
                };
            }
        }

        public override object Deserialize(IDictionary<string, object> dictionary, Type type, JavaScriptSerializer serializer)
        {
            object result = null;

            if (type.Equals(typeof(Searches.Query)))
            {
                result = Searches.Query.Deserialize(dictionary);
            }
            else if (type.Equals(typeof(Searches.Search)))
            {
                result = Searches.Search.Deserialize(dictionary);
            }
            else if (type.Equals(typeof(Searches.RestCall)))
            {
                result = Searches.RestCall.Deserialize(dictionary);
            }

            return result;
        }

        public override IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer)
        {
            IDictionary<string, object> result = null;
            if (obj is Searches.Query)
            { 
                result = ((Searches.Query)obj).Serialize();
            }
            else if (obj is Searches.Search)
            {
                result = ((Searches.Search)obj).Serialize();
            }
            else if (obj is Searches.RestCall)
            { 
                result = ((Searches.RestCall)obj).Serialize();
            }

            return result;
        }
                
    }
}
