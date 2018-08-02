using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Web.Controls
{
    public class EnumField : ListField
    {
        #region fields

        /// <summary>
        ///     The type of the enum that is displayed in the list.
        /// </summary>
        private String _enumType;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the type of the enum that is displayed in the list.
        /// </summary>
        public String EnumType
        {
            get { return _enumType; }
            set { _enumType = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Initialises the control tree.
        /// </summary>
        protected override void InitialiseControlTree()
        {
            Type[] enumerators = typeof(IBusinessProvider).Assembly.GetTypes().Where(type => type.IsEnum).ToArray();
            Type enumType = enumerators.FirstOrDefault(type => String.Equals(type.FullName, this.EnumType, StringComparison.OrdinalIgnoreCase)) ?? enumerators.FirstOrDefault(type => String.Equals(type.Name, this.EnumType, StringComparison.OrdinalIgnoreCase));
            if (enumType != null)
            {
                IEnumerable<Object> values = Enum.GetValues(enumType).OfType<Object>().Select(obj => new { Value = obj, Text = obj.ConvertTo<String>() }).ToArray();

                // Populate the dropdown list
                base.InitialiseControlTree();
                this.DisplayMember = "Text";
                this.ValueMember = "Value";
                this.DataSource = values.ToList();
            }
        }

        #endregion
    }
}
