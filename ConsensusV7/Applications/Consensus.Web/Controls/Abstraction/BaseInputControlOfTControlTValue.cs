using Consensus.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.Controls
{
    /// <summary>
    ///     Provides the abstraction for all encapsulated input controls with a strongly-typed value within the web application 
    /// </summary>
    /// <typeparam name="TControl">
    ///     The type of control that has been encapsulated.
    /// </typeparam>
    /// <typeparam name="TValue">
    ///     The type of value that is obtained from the control.
    /// </typeparam>
    [ParseChildren(true)]
    public abstract class BaseInputControl<TControl, TValue> : BaseInputControl<TControl> where TControl : Control, new()
    {
        #region fields

        /// <summary>
        ///     The client side code which is executed when the editor value is changed.
        /// </summary>
        private String _clientOnChange;

        /// <summary>
        ///     The URL parameter that is used to initialise the field value.
        /// </summary>
        private String _valueUrlParameter;

        /// <summary>
        ///     Specifies whether the field is editable when the field is initialised with a URL parameter
        /// </summary>
        private Boolean _valueUrlIsEnforced;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the control.
        /// </summary>
        public abstract TValue FieldValue
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the control.
        /// </summary>
        public override Object FieldValueRaw
        {
            get { return this.FieldValue; }
            set { this.FieldValue = value.ConvertTo<TValue>(); }
        }

        /// <summary>
        ///     Gets or sets client side code which is executed when the editor value is changed.
        /// </summary>
        public String ClientOnChange
        {
            get { return _clientOnChange; }
            set { _clientOnChange = value; }
        }

        /// <summary>
        ///     Gets or sets whether the field is editable when the field is initialised with a URL parameter
        /// </summary>
        public Boolean ValueUrlIsEnforced
        {
            get { return _valueUrlIsEnforced; }
            set { _valueUrlIsEnforced = value; }
        }

        /// <summary>
        ///    Gets or sets the URL parameter that is used to initialise the field value.
        /// </summary>
        public String ValueUrlParameter
        {
            get { return _valueUrlParameter; }
            set { _valueUrlParameter = value; }
        }

        /// <summary>
        ///     Gets the runtime type of the value.
        /// </summary>
        public override Type FieldType
        {
            get { return typeof(TValue); }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Sets the initial value of the control.
        /// </summary>
        protected override void InitialiseControlValue()
        {
            if (!String.IsNullOrEmpty(this.ValueUrlParameter) && HttpContext.Current.Request.QueryString.AllKeys.Contains(this.ValueUrlParameter) && !String.IsNullOrEmpty(HttpContext.Current.Request.QueryString[this.ValueUrlParameter]))
            {
                this.FieldValue = HttpContext.Current.Request.QueryString[this.ValueUrlParameter].ConvertTo<TValue>();
                this.IsReadOnly = this.ValueUrlIsEnforced ? ConfigurableBoolean.TrueEnforced : this.IsReadOnly;
            }
        }

        protected override void InitialiseControlState()
        {
            base.InitialiseControlState();
            this.SetOnChangeAttribute();
        }

        protected virtual void SetOnChangeAttribute()
        {
            this.FieldAttributes["onchange"] = this.ClientOnChange;
        }

        #endregion
    }
}
