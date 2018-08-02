using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ScreenObjectModel" /> object.
    /// </summary>
    public partial class LocalScreenObjectFactory
    {
        /// <summary>
        ///     Updates the page configuration.
        /// </summary>
        public void Update(String url, ArrayList controls)
        {
            foreach (Dictionary<String, Object> control in controls)
            {
                // Get the screen object for the control
                LocalScreenObjectModel screenObject = this.Provider.UserInterface.ScreenObject.FetchAll().FirstOrDefault(obj => String.Equals(obj.Url, url, StringComparison.OrdinalIgnoreCase) && String.Equals(obj.Control, control["ControlId"].ConvertTo<String>(), StringComparison.OrdinalIgnoreCase));

                if (control.ContainsKey("DeleteMe") && control["DeleteMe"].ToString() == "1")
                {
                    if (screenObject != null)
                    {
                        screenObject.Delete();
                    }
                }
                else
                {
                    if (screenObject == null)
                        screenObject = this.Provider.UserInterface.ScreenObject.Create();

                    // Apply the configuration
                    Dictionary<String, Dictionary<String, Object>> configuration = (control["Configuration"] as Dictionary<String, Object>).ToDictionary(pair => pair.Key, pair => pair.Value as Dictionary<String, Object>);
                    if (configuration.ContainsKey("Icon"))
                        screenObject.Icon = configuration["Icon"]["ConfiguredValue"].ConvertTo<String>().TrimOrNullify();
                    if (configuration.ContainsKey("Title"))
                        screenObject.Title = configuration["Title"]["ConfiguredValue"].ConvertTo<String>().TrimOrNullify();
                    if (configuration.ContainsKey("DefaultValue"))
                        screenObject.Default = configuration["DefaultValue"]["ConfiguredValue"].ConvertTo<String>().TrimOrNullify();
                    if (configuration.ContainsKey("Requirement"))
                        screenObject.Requirement = configuration["Requirement"]["ConfiguredValue"].ConvertTo<ScreenObjectRequirement>();
                    if (configuration.ContainsKey("OnText"))
                        screenObject.OnText = configuration["OnText"]["ConfiguredValue"].ConvertTo<String>().TrimOrNullify();
                    if (configuration.ContainsKey("OnColour"))
                        screenObject.OnColour = configuration["OnColour"]["ConfiguredValue"].ConvertTo<String>().TrimOrNullify();
                    if (configuration.ContainsKey("OffText"))
                        screenObject.OffText = configuration["OffText"]["ConfiguredValue"].ConvertTo<String>().TrimOrNullify();
                    if (configuration.ContainsKey("OffColour"))
                        screenObject.OffColour = configuration["OffColour"]["ConfiguredValue"].ConvertTo<String>().TrimOrNullify();
                    if (configuration.ContainsKey("ValidatorCritical"))
                        screenObject.ValidatorCritical = configuration["ValidatorCritical"]["ConfiguredValue"].ConvertTo<Boolean>();
                    if (configuration.ContainsKey("ValidatorMessage"))
                        screenObject.ValidatorMessage = configuration["ValidatorMessage"]["ConfiguredValue"].ConvertTo<String>().TrimOrNullify();
                    if (configuration.ContainsKey("ValidatorExpression"))
                        screenObject.ValidatorExpression = configuration["ValidatorExpression"]["ConfiguredValue"].ConvertTo<String>().TrimOrNullify();
                    if (configuration.ContainsKey("MaximumLength"))
                        screenObject.MaximumLength = configuration["MaximumLength"]["ConfiguredValue"].ConvertTo<Int32>();
                    if (configuration.ContainsKey("IsHidden") && configuration["IsHidden"]["ConfiguredValue"].ConvertTo<Boolean>())
                        screenObject.Visibility = ScreenObjectVisibility.Hidden;
                    else if (configuration.ContainsKey("IsReadOnly") && configuration["IsReadOnly"]["ConfiguredValue"].ConvertTo<Boolean>())
                        screenObject.Visibility = ScreenObjectVisibility.ReadOnly;
                    else
                        screenObject.Visibility = ScreenObjectVisibility.Visible;

                    // Apply the n-1 configuration items
                    if (configuration.ContainsKey("Columns"))
                        this.UpdateColumns(screenObject, control, "Columns");
                    if (configuration.ContainsKey("Items"))
                        this.UpdateItems(screenObject, control, "Items");
                    if (configuration.ContainsKey("Security"))
                        this.UpdateSecurity(screenObject, control, "Security");

                    // When creating a new screen object record, ensure that the page url and control ID are set
                    if (!screenObject.IsPersisted && (screenObject.IsModified || screenObject.Entries.Any(ent => ent.IsModified) || screenObject.DisplayRules.Any(rule => rule.IsModified) || screenObject.Columns.Any(rule => rule.IsModified)))
                    {
                        screenObject.Control = control["ControlId"].ConvertTo<String>();
                        screenObject.Url = url;
                    }
                    screenObject.Save();
                }
            }
        }

        private void Update<TModel, TInterface>(LocalScreenObjectModel screenObject, Dictionary<String, Object> configTable, String configEntry, Collection<TInterface> collection, Func<TModel, Dictionary<String, Object>, Boolean> predicate, Func<TModel> creator, Action<TModel, Dictionary<String, Object>> updator) where TModel : LocalModel, TInterface
        {
            Dictionary<String, Object> configuration = configTable["Configuration"] as Dictionary<String, Object>;
            ArrayList entries = configuration[configEntry] as ArrayList;
            foreach (Dictionary<String, Object> entry in entries)
            {
                // Find the model in the collection, creating a new model if no existing model can be found.
                TModel model = collection.OfType<TModel>().FirstOrDefault(element => predicate(element, entry));
                if (model == null)
                    model = creator.Invoke();

                // Update the model with the properties from the configuration.
                updator.Invoke(model, entry);

                // Add the model to the collection, if the model contains changes
                if (model.IsModified && !model.IsPersisted)
                    collection.Add(model);
            }
        }

        private void UpdateColumns(LocalScreenObjectModel screenObject, Dictionary<String, Object> configTable, String configEntry)
        {
            this.Update(screenObject, configTable, configEntry, screenObject.Columns, (model, entry) => model.Ordinal == entry["Ordinal"].ConvertTo<Int32>(), this.Provider.UserInterface.ScreenObjectColumn.Create, (model, entry) =>
            {
                model.CustomTitle = entry["CustomTitle"].ConvertTo<String>();
                model.Exportable = entry["Exportable"].ConvertTo<Boolean>();
                model.Visible = entry["Visible"].ConvertTo<Boolean>();
                if (model.IsModified)
                    model.Ordinal = entry["Ordinal"].ConvertTo<Int32>();
            });
        }

        private void UpdateItems(LocalScreenObjectModel screenObject, Dictionary<String, Object> configTable, String configEntry)
        {
            this.Update(screenObject, configTable, configEntry, screenObject.Entries, (model, entry) => model.Normal == entry["Value"].ConvertTo<String>(), this.Provider.UserInterface.ScreenObjectEntry.Create, (model, entry) =>
            {
                model.Custom = entry["CustomText"].ConvertTo<String>();
                model.Hide = !entry["Displayed"].ConvertTo<Boolean>();
                if (model.IsModified)
                    model.Normal = entry["Value"].ConvertTo<String>();
            });
        }

        private void UpdateSecurity(LocalScreenObjectModel screenObject, Dictionary<String, Object> configTable, String configEntry)
        {
            this.Update(screenObject, configTable, configEntry, screenObject.DisplayRules, (model, entry) => model.PrincipalId == entry["PrincipalId"].ConvertTo<Int32>(), this.Provider.UserInterface.ScreenObjectDisplay.Create, (model, entry) =>
            {
                ScreenObjectVisibility? visibility = entry["Visibility"].ConvertTo<ScreenObjectVisibility?>();
                if (visibility == null)
                {
                    if (model.IsPersisted)
                        model.Delete();
                }
                else
                {
                    if (visibility != null)
                    {
                        model.Visibility = visibility.Value;
                        model.PrincipalId = entry["PrincipalId"].ConvertTo<Int32>();
                    }
                }
            });
        }
    }
}
