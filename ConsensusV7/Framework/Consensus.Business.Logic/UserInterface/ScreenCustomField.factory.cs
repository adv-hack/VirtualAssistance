using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ScreenCustomFieldModel" /> object.
    /// </summary>
    public partial class LocalScreenCustomFieldFactory
    {
        /// <summary>
        /// Fetch the custom fields for a page.
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public IEnumerable<LocalScreenCustomFieldModel> FetchAllByPage(string page)
        {
            IEnumerable<ScreenCustomFieldRecord> recordCollection = this.Provider.DataProvider.UserInterface.ScreenCustomField.FetchAllByPage(page);
            IEnumerable<LocalScreenCustomFieldModel> modelCollection = recordCollection.Select(record => new LocalScreenCustomFieldModel(this.Provider, record));
            return modelCollection;
        }

        /// <summary>
        ///     Updates the page configuration.
        /// </summary>
        public void Update( ArrayList customFields)
        {
            foreach (Dictionary<String, Object> customField in customFields)
            {
                // Get the custom field object
                LocalScreenCustomFieldModel fieldObject = null;

                if (customField.ContainsKey("Id"))
                {
                    int Id = 0;
                    string sId = customField["Id"].ConvertTo<String>().TrimOrNullify(); // TODO: can simplify this if Id is already an int?
                    if (int.TryParse(sId, out Id))
                    {
                        fieldObject = this.Provider.UserInterface.ScreenCustomField.FetchById(Id);
                    }
                }

                if (customField.ContainsKey("DeleteMe") && customField["DeleteMe"].ToString() == "1")
                {
                    if (fieldObject != null)
                    {
                        fieldObject.Delete();
                    }
                }
                else
                {
                    if (fieldObject == null)
                        fieldObject = this.Provider.UserInterface.ScreenCustomField.Create();

                    Type objType = fieldObject.GetType();
                    // Apply the properties
                    foreach (string key in customField.Keys)
                    {
                        System.Reflection.PropertyInfo fieldInfo = objType.GetProperty(key);
                        if (fieldInfo != null 
                            && fieldInfo.SetMethod != null
                            && key != "Cftype"
                            && key != "CustomFieldValues"
                            && key != "CustomFieldListItems"
                            ) 
                        {
                            object currValue = fieldInfo.GetValue(fieldObject);
                            if (currValue != null)
                                fieldInfo.SetValue(fieldObject, customField[key].ConvertTo(fieldInfo.PropertyType, fieldInfo.GetValue(fieldObject).ConvertTo(fieldInfo.PropertyType)));
                            else
                                fieldInfo.SetValue(fieldObject, customField[key].ConvertTo(fieldInfo.PropertyType));
                        }
                    }

                    if (customField.ContainsKey("CustomFieldListItems"))
                    {
                        ArrayList listItems = customField["CustomFieldListItems"] as ArrayList;
                        LocalCollection<LocalScreenCustomFieldListitemModel, IScreenCustomFieldListitemModel> listObjects = fieldObject.CustomFieldListItems;

                        foreach (Dictionary<string, object> listItem in listItems)
                        {

                            LocalScreenCustomFieldListitemModel listObject;

                            if (listItem.ContainsKey("Id") && !string.IsNullOrEmpty(listItem["Id"].ToString()))
                            {
                                listObject = listObjects.FirstOrDefault(i => i.Id == listItem["Id"].ConvertTo<int>());

                                if (listItem.ContainsKey("DeleteMe") && listItem["DeleteMe"].ToString() == "1")
                                {
                                    listObject.Delete();
                                    listObjects.Remove(listObject);
                                }
                                else
                                {
                                    if (listItem.ContainsKey("IdValue"))
                                        listObject.IdValue = listItem["IdValue"].ConvertTo<String>().TrimOrNullify();
                                    if (listItem.ContainsKey("Text"))
                                        listObject.Text = listItem["Text"].ConvertTo<String>().TrimOrNullify();
                                }
                            }
                            else
                            {
                                if (!(listItem.ContainsKey("DeleteMe") && listItem["DeleteMe"].ToString() == "1"))
                                {
                                    listObject = this.Provider.UserInterface.ScreenCustomFieldListitem.Create();
                                    if (listItem.ContainsKey("IdValue"))
                                        listObject.IdValue = listItem["IdValue"].ConvertTo<String>().TrimOrNullify();
                                    if (listItem.ContainsKey("Text"))
                                        listObject.Text = listItem["Text"].ConvertTo<String>().TrimOrNullify();
                                    listObjects.Add(listObject);
                                }
                            }
                        }                        
                    }

                    // When creating a new record, ensure that the url and page are set
                    if (!fieldObject.IsPersisted && fieldObject.IsModified)
                    {
                        fieldObject.Page = customField["Page"].ConvertTo<String>();
                        fieldObject.Url = customField["Url"].ConvertTo<String>();
                    }
                    fieldObject.Save();
                }
            }
        }

    }
}
