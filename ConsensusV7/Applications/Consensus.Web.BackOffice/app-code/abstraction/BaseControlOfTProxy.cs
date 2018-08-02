using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.UserInterface;

namespace Consensus.Web.BackOffice
{
    public abstract class BaseControl<TProxy> : BaseControl
    {
        #region fields

        /// <summary>
        ///     The data source for the control
        /// </summary>
        private TProxy _dataSource;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the data source for the control
        /// </summary>
        public TProxy DataSource
        {
            get { return _dataSource; }
            set { _dataSource = value; this.PopulateControl(); }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Populates the control fields.
        /// </summary>
        protected virtual void PopulateControl()
        {
            Object value;

            // Populate the value of the input controls
            BaseInputControl[] inputControls = this.GetControlTree<BaseInputControl>(this).Where(control => !String.IsNullOrEmpty(control.DataBoundValue) && !(control is ICanBeACustomField && ((ICanBeACustomField)control).IsCustomField)).ToArray();
            foreach (BaseInputControl inputControl in inputControls)
                if (this.GetControlValue(this.DataSource, inputControl.DataBoundValue, out value))
                    inputControl.FieldValueRaw = value;

            // Populate the screenObjectDisplay text for the popup controls
            PopupField[] popupControls = this.GetControlTree<PopupField>(this).Where(control => !String.IsNullOrEmpty(control.DataBoundText) && !(control is ICanBeACustomField && ((ICanBeACustomField)control).IsCustomField)).ToArray();
            foreach (PopupField popupControl in popupControls)
                if (this.GetControlValue(this.DataSource, popupControl.DataBoundText, out value))
                    popupControl.FieldText = value.ConvertTo<String>();

            // Ensure defaults are applied for new records only
            inputControls.Execute(control => control.ApplyDefaultValue = (this.DataSource as Proxy) == null || (this.DataSource as Proxy).IsPersisted == false);
        }
        

        /// <summary>
        ///     Registers any client-side script for the control.
        /// </summary>
        protected virtual void RegisterJavascript()
        {
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            this.RegisterJavascript();
        }

        private IEnumerable<OfType> GetControlTree<OfType>(Control parent)
        {
            List<Control> controls = new List<Control>();
            foreach (Control child in parent.Controls)
            {
                if (child is OfType)
                {
                    controls.Add(child);
                }
                controls.AddRange(GetControlTree<OfType>(child).ToList().ConvertAll<Control>(new Converter<OfType, Control>(o => o.ConvertTo<Control>())));
            }
            return controls.ConvertAll<OfType>(c => c.ConvertTo<OfType>());
        }

        private Boolean GetControlValue(Object source, String memberName, out Object result)
        {
            Boolean success = false;
            result = null;

            if (source != null)
            {
                String dotPrefix = memberName.Contains('.') ? memberName.Substring(0, memberName.IndexOf('.')) : memberName;
                String dotSuffix = memberName.Contains('.') ? memberName.Substring(memberName.IndexOf('.') + 1) : null;
                MemberInfo member = source.GetType().GetMember(dotPrefix, BindingFlags.Public | BindingFlags.Instance).FirstOrDefault();
                if (success = (member is FieldInfo))
                    result = (member as FieldInfo).GetValue(source);
                else if (success = (member is PropertyInfo && (member as PropertyInfo).CanRead))
                    result = (member as PropertyInfo).GetValue(source);
                if (success && result != null && dotSuffix != null)
                    success = GetControlValue(result, dotSuffix, out result);
            }
            return success;
        }

        #endregion
    }
}