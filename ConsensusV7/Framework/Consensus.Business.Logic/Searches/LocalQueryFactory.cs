using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Consensus.Searches
{
    public class LocalQueryFactory : LocalFactory<LocalQueryModel>, QueryFactory
    {
        QueryModel QueryFactory.Create()
        {
            return new LocalQueryModel(this.Provider);
        }

        Dictionary<String, Object>[] QueryFactory.Execute(QueryModel query)
        {
            return (query as ISearchesRunnable).Run();
        }

        ISearchesRunnable QueryFactory.Deserialize(IDictionary<string, object> dictionary)
        {
            LocalQueryModel result = new LocalQueryModel(this.Provider);

            foreach (string key in dictionary.Keys)
            {
                switch (key)
                {
                    case "Distinct":
                        result.Distinct = dictionary[key].ConvertTo<bool>();
                        break;
                    case "Top":
                        result.Top = dictionary[key].ConvertTo<int?>();
                        break;
                    case "Source":
                        if (dictionary[key] is IDictionary<string, object>)
                        {
                            IDictionary<string, object> source = (IDictionary<string, object>)dictionary[key];
                            QuerySources src;

                            if (source.ContainsKey("Source") && Enum.TryParse<QuerySources>(source["Source"].ToString(), out src))
                                result.Source = new LocalQuerySource() { Source = src, Alias = source.ContainsKey("Alias") && source["Alias"] != null ? source["Alias"].ToString() : null };
                        }
                        break;
                    case "Selects":
                        SerialiseCollection<LocalQuerySelect>(dictionary, result, result.Selects, key);
                        break;
                    case "Joins":
                        SerialiseCollection<LocalQueryJoin>(dictionary, result, result.Joins, key);
                        break;
                    case "Wheres":                         
                        SerialiseCollection<LocalQueryCondition>(dictionary, result, result.Wheres, key);
                        break;
                    case "Orders":
                        SerialiseCollection<LocalQueryOrder>(dictionary, result, result.Orders, key);
                        break;
                }
            }

            return result;
        }
        
        private void SerialiseCollection<TItem>(IDictionary<string, object> dictionary, LocalQueryModel result, IList<TItem> resultArr, string key)
        {
            if (dictionary[key] is System.Collections.ArrayList)
            {
                foreach (object oItem in dictionary[key] as System.Collections.ArrayList)
                {
                    if (oItem is IDictionary<string, object>)
                    {
                        IDictionary<string, object> dItem = oItem as IDictionary<string, object>;
                        object lItem;

                        // Instantiate an instance of the line item.
                        if (typeof(TItem).IsAssignableFrom(typeof(LocalQueryCondition)))
                        {
                            // There are two different types of "Where" clause - instantiate the correct one
                            if (dItem.ContainsKey("MatchCorrelation"))
                                lItem = new LocalQueryConditionCorrelation();
                            else
                                lItem = new LocalQueryConditionValue();
                        }
                        else
                        {
                            ConstructorInfo consInfo = typeof(TItem).GetConstructor(new Type[0]);
                            if (consInfo == null)
                            {
                                // The LocalQueryJoin constructor needs the current model instance to be passed
                                consInfo = typeof(TItem).GetConstructor(new Type[] { typeof(LocalQueryModel) });
                                lItem = consInfo.Invoke(new object[] { result });
                            }
                            else
                            {
                                lItem = consInfo.Invoke(null);
                            }
                        }

                        resultArr.Add((TItem)lItem);
                        Type itemType = lItem.GetType();

                        // Set each property on the item for which we have some data.
                        foreach (string pkey in dItem.Keys)
                        {
                            PropertyInfo pInfo = itemType.GetProperty(pkey);
                            if (pInfo != null)
                            {
                                // If this property is a List<> then call this method iteratively to serialise the contents.
                                // Currently this seems to only be for Join Conditions, however it is generic so should work for whatever Lists it finds.
                                if (pInfo.PropertyType.Name.StartsWith("List") && pInfo.PropertyType.GenericTypeArguments.Length == 1 && dItem[pkey] is System.Collections.ArrayList)
                                {
                                    MethodInfo szcInfo = this.GetType().GetMethod("SerialiseCollection", BindingFlags.NonPublic | BindingFlags.Instance);
                                    MethodInfo szcTyped = szcInfo.MakeGenericMethod(pInfo.PropertyType.GenericTypeArguments[0]);

                                    szcTyped.Invoke(this, new object[] { dItem, result, pInfo.GetValue(lItem), pkey });
                                }
                                else if (pInfo.SetMethod != null)
                                {
                                    // Set the value of the property
                                    pInfo.SetValue(lItem, dItem[pkey].ConvertTo(pInfo.PropertyType));
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
