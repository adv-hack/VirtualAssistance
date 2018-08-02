using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Script.Serialization;

namespace Consensus.Web
{
    public class RestSerializer : JavaScriptConverter
    {
        #region fields

        /// <summary>
        ///     The singleton instance of the serializer, with default options.
        /// </summary>
        private static RestSerializer _instance;

        /// <summary>
        /// A container to hold which properties to ignore for which types.
        /// </summary>
        private Dictionary<Type, List<string>> _ignore;

        /// <summary>
        /// A container to hold which properties to include for which types, ignoring all others
        /// </summary>
        private Dictionary<Type, List<string>> _include;

        /// <summary>
        /// Holds the depth to serialise the object to
        /// </summary>
        private RestSerializationDepth _goToDepth = RestSerializationDepth.GrandChild;

        /// <summary>
        /// A structure to set the individual depths to which named lists are serialised.
        /// </summary>
        private Dictionary<Type, Dictionary<string, RestSerializationDepth>> _namedListsResolveToDepth;

        /// <summary>
        /// Holds the depth up to which lists are serialised, defaulting to root. 
        /// </summary>
        private RestSerializationDepth _listsAtDepth = RestSerializationDepth.Root;

        /// <summary>
        /// Holds the default depth to serialise lists to, defaulting to root. 
        /// </summary>
        private RestSerializationDepth _listToDepth = RestSerializationDepth.Root;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the singleton instance of the serializer.
        /// </summary>
        public static RestSerializer Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RestSerializer();
                return _instance;
            }
        }

        /// <summary>
        ///     Gets the collection of the supported types.
        /// </summary>
        public override IEnumerable<Type> SupportedTypes
        {
            get
            {
                foreach (Type type in typeof(Proxy).Assembly.GetTypes())
                    if (!type.IsAbstract && type.IsSubclassOf(typeof(Proxy)))
                        yield return type;
            }
        }

        /// <summary>
        /// A container to hold which properties to ignore for which types.
        /// </summary>
        public Dictionary<Type, List<string>> Ignore
        {
            get
            {
                if (_ignore == null)
                    _ignore = new Dictionary<Type, List<string>>();
                return _ignore;
            }
            set
            {
                _ignore = value;
            }
        }

        /// <summary>
        /// A container to hold which properties to include for which types, ignoring all others
        /// </summary>
        public Dictionary<Type, List<string>> Include
        {
            get
            {
                if (_include == null)
                    _include = new Dictionary<Type, List<string>>();
                return _include;
            }
            set
            {
                _include = value;
            }
        }

        /// <summary>
        /// A structure to set the individual depths to which named lists are serialised.
        /// </summary>
        public Dictionary<Type, Dictionary<string, RestSerializationDepth>> NamedListsResolveToDepth
        {
            get
            {
                if (_namedListsResolveToDepth == null)
                    _namedListsResolveToDepth = new Dictionary<Type, Dictionary<string, RestSerializationDepth>>();
                return _namedListsResolveToDepth;
            }
            set
            {
                _namedListsResolveToDepth = value;
            }
        }

        /// <summary>
        /// Sets the depth to serialise the object to
        /// </summary>
        public RestSerializationDepth GoToDepth {
            get { return _goToDepth; }
            set { _goToDepth = value; }
        }

        /// <summary>
        /// Sets the depth up to which lists members are serialised rather than ignored.
        /// </summary>
        public RestSerializationDepth ListsAtDepth
        {
            get { return _listsAtDepth; }
            set { _listsAtDepth = value; }
        }

        /// <summary>
        /// Sets the depth to which to serialise list entries.
        /// </summary>
        public RestSerializationDepth ListsToDepth
        {
            get { return _listToDepth; }
            set { _listToDepth = value; }
        }
        

        #endregion


        #region methods

        /// <summary>
        ///     Serialises an object into an object graph.
        /// </summary>
        /// <param name="obj">
        ///     The object to be serialised.
        /// </param>
        /// <param name="serializer">
        ///     The custom serialiser used to serialise the object
        /// </param>
        /// <returns>
        ///     The object graph.
        /// </returns>
        public override IDictionary<String, Object> Serialize(Object obj, JavaScriptSerializer serializer)
        {
            HashSet<String> index = new HashSet<String>();
            
            return this.Serialize(obj, serializer, index, RestSerializationDepth.Root, _goToDepth, false);
        }
        
        public IDictionary<String, Object> Serialize(Object obj, JavaScriptSerializer serializer, HashSet<String> index, RestSerializationDepth depth, RestSerializationDepth toDepth, bool inList)
        {
            Type runtimeType = obj.GetType();

            // Create a dictionary and add the rest uri as a default property
            IDictionary<String, Object> result = new Dictionary<String, Object>();

            // If we have been asked to serialise nothing, return the empty result
            if (toDepth == RestSerializationDepth.None)
                return result;

            if (obj is Proxy)
            {
                String context = String.Join(".", runtimeType.Namespace.Split('.').Skip(1));
                object rawId = runtimeType.GetProperty("Id", BindingFlags.Public | BindingFlags.Instance).GetValue(obj);
                String identifier = rawId == null || (rawId.GetType().In(typeof(int), typeof(long), typeof(byte), typeof(short)) && rawId.ConvertTo<long>() == 0) ? "" : rawId.ConvertTo<String>();
                String uri = String.Concat(context, "/", runtimeType.Name, "/", identifier);
                if (index.Contains(uri))
                    return null;

                result.Add("uri", uri);
                index.Add(uri);
            }

            // Add each public instance property to the dictionary
            PropertyInfo[] properties = runtimeType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            List<string> toIgnore = Ignore.ContainsKey(obj.GetType()) ? Ignore[obj.GetType()] : new List<string>();
            List<string> toInclude = Include.ContainsKey(obj.GetType()) ? Include[obj.GetType()] : new List<string>();
            Dictionary<string, RestSerializationDepth> listDepths = NamedListsResolveToDepth.ContainsKey(obj.GetType()) ? NamedListsResolveToDepth[obj.GetType()] : new Dictionary<string, RestSerializationDepth>();
            foreach (PropertyInfo property in properties.Where(prop => prop.CanRead && !toIgnore.Contains(prop.Name) && (toInclude.Count == 0 || prop.Name == "Id" || toInclude.Contains(prop.Name))))
            {
                // Exclude members that are marked as non-serialized
                if (!property.GetCustomAttributes().OfType<NonSerializedAttribute>().Any())
                {
                    if ((property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(Collection<>)) || property.PropertyType.IsArray)
                    {
                        // Collections are (by default) serialized for root objects only                    
                        if ((!inList && depth <= _listsAtDepth && depth <= toDepth && !listDepths.ContainsKey(property.Name)) || (listDepths.ContainsKey(property.Name) && listDepths[property.Name] != RestSerializationDepth.None))
                        {
                            RestSerializationDepth listDepth = listDepths.ContainsKey(property.Name) ? listDepths[property.Name] : _listToDepth;
                            result[property.Name] = (property.GetValue(obj) as IEnumerable).OfType<Object>().Select(element => this.Serialize(element, serializer, index, RestSerializationDepth.Root, listDepth, true));
                        }
                    }
                    else if (typeof(Consensus.Common.ICodeModel).IsAssignableFrom(property.PropertyType))
                    {
                        // Code Models are serialized on root and child objects.
                        if (!inList && depth < toDepth && depth != RestSerializationDepth.None)
                            result[property.Name] = this.Serialize(property.GetValue(obj), serializer, index, RestSerializationDepth.None, toDepth, inList);
                    }
                    else if (this.SupportedTypes.Contains(property.PropertyType))
                    {
                        // Other models are serialized on root and child objects.
                        if (depth < toDepth && depth != RestSerializationDepth.None)
                        {
                            if (depth == RestSerializationDepth.Root)
                                result[property.Name] = this.Serialize(property.GetValue(obj), serializer, index, RestSerializationDepth.Child, toDepth, inList);
                            else if (depth == RestSerializationDepth.Child)
                                result[property.Name] = this.Serialize(property.GetValue(obj), serializer, index, RestSerializationDepth.GrandChild, toDepth, inList);
                        }
                    }
                    else if (property.PropertyType.IsEnum)
                    {
                        // Native property types are serialized on all objects
                        result[property.Name] = property.GetValue(obj).ToString();
                    }
                    else if (property.PropertyType == typeof(DateTime) || property.PropertyType == typeof(DateTime?))
                    {
                        DateTime? value = property.GetValue(obj).ConvertTo<DateTime?>();
                        if (value.HasValue)
                            result[property.Name] = value.Value.ToString("dd MMMM yyyy HH:mm:ss");
                        else
                            result[property.Name] = null;
                    }
                    else
                    {
                        result[property.Name] = property.GetValue(obj);
                    }
                }
            }
            return result;
        }

        /// <summary>
        ///     Deserialises an object graph into an object.
        /// </summary>
        /// <param name="dictionary">
        ///     The object graph to be deserialised.
        /// </param>
        /// <param name="type">
        ///     The runtime type of the object to return.
        /// </param>
        /// <param name="serializer">
        ///     The custom serialiser used to deserialise the object
        /// </param>
        /// <returns>
        ///     The object graph.
        /// </returns>
        public override Object Deserialize(IDictionary<String, Object> dictionary, Type type, JavaScriptSerializer serializer)
        {
            Object instance = type.GetMethod("Create", BindingFlags.Public | BindingFlags.Static, null, Type.EmptyTypes, null).Invoke(null, null);
            this.Deserialize(dictionary, instance, false);
            return instance;
        }

        /// <summary>
        ///     Deserialises an object graph onto an existing object.
        /// </summary>
        /// <param name="dictionary">
        ///     The object graph to be deserialised.
        /// </param>
        /// <param name="obj">
        ///     The object to be updated with the deserialised values.
        /// </returns>
        internal void Deserialize(IDictionary<String, Object> dictionary, Object obj, bool specialNulls)
        {
            // Categorise the types of properties to be updated.
            Dictionary<String, PropertyInfo> matchProperties = dictionary.Keys.ToDictionary(k => k, k => obj.GetType().GetProperty(k, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase));
            Dictionary<String, PropertyInfo> modelProperties = matchProperties.Where(this.IsModelProperty).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            Dictionary<String, PropertyInfo> arrayProperties = matchProperties.Where(this.IsArrayProperty).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            Dictionary<String, PropertyInfo> valueProperties = matchProperties.Where(this.IsValueProperty).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            Dictionary<String, PropertyInfo> collectionProperties = matchProperties.Where(this.IsCollection).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            // Set the value properties first
            foreach (String key in valueProperties.Keys)
            {
                bool isSet = false;
                PropertyInfo valuePropInfo = valueProperties[key];

                if (valuePropInfo.SetMethod != null)
                {
                    if (specialNulls && valuePropInfo.GetMethod != null)
                    {
                        // If specialNulls is set then check for where a field was set but is now empty.
                        // In this case make sure that strings values are set to an empty string, rather than a null, 
                        // and that numbers and datetimes (and maybe some other things) are set to the MinValue of their type
                        // This will allow us to use different logic when calling V7 and V6.5 procedures to force values to
                        // be nulled out.
                        Type valuePropType = valuePropInfo.PropertyType;
                        object newValue = dictionary[key].ConvertTo(valuePropType);
                        object oldValue = valuePropInfo.GetValue(obj);
                        if ((newValue == null || string.IsNullOrEmpty(newValue.ToString())) && !(oldValue == null || string.IsNullOrEmpty(oldValue.ToString())))
                        {
                            if (valuePropType.Equals(typeof(System.String)))
                            {
                                valuePropInfo.SetValue(obj, "");
                                isSet = true;
                            }
                            else
                            {
                                Type valueType = (valuePropType.IsGenericType && valuePropType.Name.StartsWith("Nullable"))
                                    ? valuePropType.GenericTypeArguments[0]
                                    : valuePropType;

                                FieldInfo minValueField = valueType.GetField("MinValue");
                                if (minValueField != null && valueType.IsSignedNumericOrDate())
                                {
                                    valuePropInfo.SetValue(obj, minValueField.GetValue(newValue));
                                    isSet = true;
                                }
                            }
                        }
                        else if (newValue != null && newValue is string && !newValue.Equals(oldValue))
                        {
                            valuePropInfo.SetValue(obj, ((string)newValue).Trim());
                            isSet = true;
                        }
                    }
                    if (!isSet)
                    {
                        valuePropInfo.SetValue(obj, dictionary[key].ConvertTo(valuePropInfo.PropertyType));
                    }
                }
            }

            // Set the model properties next
            foreach (String key in modelProperties.Keys)
                if (dictionary[key] != null && dictionary[key] is Dictionary<String, Object>)
                    this.Deserialize(dictionary[key] as Dictionary<String, Object>, modelProperties[key].GetValue(obj), specialNulls);

            // Set the array properties next
            foreach (String key in arrayProperties.Keys)
            {
                Type elementType = arrayProperties[key].PropertyType.GetElementType();
                IList elementList = Activator.CreateInstance(typeof(List<>).MakeGenericType(elementType)) as IList;
                foreach (Object entry in dictionary[key] as ArrayList)
                {
                    if (!elementType.IsPrimitive)
                    {
                        Object element = this.SupportedTypes.Contains(elementType) ? this.GetNewObject(elementType) : Activator.CreateInstance(elementType);
                        this.Deserialize(entry as Dictionary<String, Object>, element, specialNulls);
                        elementList.Add(element);
                    }
                    else
                    {
                        Object element = entry.ConvertTo(elementType);
                        elementList.Add(element);
                    }   
                }

                Array elementArray = Array.CreateInstance(elementType, elementList.Count);
                elementList.CopyTo(elementArray, 0);
                arrayProperties[key].SetValue(obj, elementArray);
            }

            // Set the collection properties next
            foreach (String key in collectionProperties.Keys)
            {
                Type collectionType = collectionProperties[key].PropertyType.GetGenericArguments().First();
                if (this.SupportedTypes.Contains(collectionType))
                    this.Deserialize(collectionType, collectionProperties[key].GetValue(obj) as Collection, dictionary[key] as ArrayList, specialNulls);
                else
                    collectionProperties[key].SetValue(obj, dictionary[key]);
            }
        }
        

        /// <summary>
        ///     Deserialises a collection of object graphs onto an existing object collection.
        /// </summary>
        internal void Deserialize(Type type, Collection collection, ArrayList arrayList, bool specialNulls)
        {
            foreach (Dictionary<String, Object> entry in arrayList)
            {
                Object identifer = entry.ContainsKey("Id") ? entry["Id"] : null;
                Object element = null;

                if (identifer != null && !Object.Equals(identifer, ""))
                    element = collection.OfType<Object>().FirstOrDefault(o => Object.Equals(o.GetType().GetProperty("Id").GetValue(o), identifer.ConvertTo(o.GetType().GetProperty("Id").PropertyType)));
                else if ((element = this.GetNewObject(type)) != null)
                    collection.Add(element);

                if (element != null)
                    this.Deserialize(entry, element, specialNulls);
            }

            foreach (Proxy proxy in collection)
            {
                Boolean matched = false;
                foreach (Dictionary<String, Object> entry in arrayList)
                {
                    Object identifer = entry.ContainsKey("Id") ? entry["Id"] : null;
                    if (matched = (identifer != null && !Object.Equals(identifer, "") && Object.Equals(proxy.GetType().GetProperty("Id").GetValue(proxy), identifer.ConvertTo(proxy.GetType().GetProperty("Id").PropertyType))))
                        break;
                }
                if (!matched)
                    proxy.Delete();
            }
        }

        /// <summary>
        ///     Creates a domain object.
        /// </summary>
        private Object GetNewObject(Type type)
        {
            MethodInfo method = type.GetMethods(BindingFlags.Public | BindingFlags.Static).FirstOrDefault(member => member.Name == "Create" && member.GetParameters().Length == 0);
            return (method == null) ? null : method.Invoke(null, new Object[] { });
        }

        private Boolean IsModelProperty(KeyValuePair<String, PropertyInfo> keyValuePair)
        {
            return keyValuePair.Value != null && this.SupportedTypes.Contains(keyValuePair.Value.PropertyType);
        }
        private Boolean IsArrayProperty(KeyValuePair<String, PropertyInfo> keyValuePair)
        {
            return keyValuePair.Value != null && !this.IsModelProperty(keyValuePair) && keyValuePair.Value.PropertyType.IsArray;
        }

        private Boolean IsCollection(KeyValuePair<String, PropertyInfo> keyValuePair)
        {
            return keyValuePair.Value != null && !this.IsModelProperty(keyValuePair) && String.Equals(keyValuePair.Value.PropertyType.Name.Split('`').First(), "Collection", StringComparison.Ordinal);
        }

        private Boolean IsValueProperty(KeyValuePair<String, PropertyInfo> keyValuePair)
        {
            return keyValuePair.Value != null && !this.IsModelProperty(keyValuePair) && !this.IsArrayProperty(keyValuePair) && !keyValuePair.Value.PropertyType.IsArray && keyValuePair.Value.CanWrite;
        }

        #endregion
    }
}