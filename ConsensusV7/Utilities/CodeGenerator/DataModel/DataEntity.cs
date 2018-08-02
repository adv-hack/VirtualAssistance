using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeGenerator;

namespace CodeGenerator.DataModel
{
    /// <summary>
    ///     Represents a defined data structure in which information is stored.
    /// </summary>
    [Serializable]
    public class DataEntity
    {
        #region fields

        /// <summary>
        ///     The collection of fields defined on this entity.
        /// </summary>
        private DataEntityField[] _fields;

        /// <summary>
        ///     The calculated object prefix
        /// </summary>
        private String _objectPrefix;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the database in which the entity is defined.
        /// </summary>
        internal Database Parent { get; private set; }

        /// <summary>
        ///     Gets the identifier for the underlying data object.
        /// </summary>
        public Int32 ObjectId { get; private set; }

        /// <summary>
        ///     Gets the name of the underlying data object.
        /// </summary>
        public String ObjectName { get; private set; }

        /// <summary>
        ///     Gets or sets the programmatic name of the entity.
        /// </summary>
        public String CodeName { get; set; }

        /// <summary>
        ///     Gets or sets the programmatic description for entity.
        /// </summary>
        public String CodeDescription { get; set; }

        /// <summary>
        ///     Gets the column prefix for the entity.
        /// </summary>
        public String ObjectPrefix
        {
            get
            {
                if (_objectPrefix == null)
                {
                    Dictionary<String, Int32> prefixTable = new Dictionary<String, Int32>();

                    // Ensure all field information has been obtained from the database
                    if (_fields == null)
                        _fields = DataEntityField.GetAll(this).ToArray();

                    // Identify the prefixes
                    Int32 maxLength = _fields.Max(field => field.ObjectName.Length);
                    for (Int32 length = 1; length <= maxLength; length++)
                    {
                        String[] prefixes = _fields.Where(field => field.ObjectName.Length >= length).Select(field => field.ObjectName.Substring(0, length)).Distinct().ToArray();
                        foreach (String prefix in prefixes)
                            prefixTable.Add(prefix, _fields.Count(field => field.ObjectName.StartsWith(prefix)));
                    }

                    // Identify the longest prefix which is applicable to all columns
                    Int32 maxValue = prefixTable.Max(kpv => kpv.Value);
                    String maxText = prefixTable.Where(kvp => kvp.Value == maxValue).Select(kvp => kvp.Key).OrderByDescending(key => key.Length).FirstOrDefault();
                    while (!Char.IsLetterOrDigit(maxText[maxText.Length - 1]))
                        maxText = maxText.Substring(0, maxText.Length - 1);

                    // Store the prefix to prevent repeated calculation
                    _objectPrefix = maxText;
                }

                return _objectPrefix;
            }
        }

        /// <summary>
        ///     Gets or sets the domain in which the entity is defined.
        /// </summary>
        public DataDomain CodeDomain { get; set; }

        /// <summary>
        ///     Gets or sets whether business logic code is generated which permits the instantiation of this type.
        /// </summary>
        public Boolean CanCreate { get; set; }

        /// <summary>
        ///     Gets or sets whether business logic code is generated which permits the modification of this type.
        /// </summary>
        public Boolean CanModify { get; set; }

        /// <summary>
        ///     Gets or sets whether business logic code is generated which permits the removal of this type.
        /// </summary>
        public Boolean CanRemove { get; set; }

        /// <summary>
        ///     Gets the primary key field for this entity.
        /// </summary>
        public DataEntityField KeyField
        {
            get { return this.Fields.FirstOrDefault(field => field.IsPrimaryKey); }
        }

        /// <summary>
        ///     Gets the collection of fields defined on this entity.
        /// </summary>
        public DataEntityField[] Fields
        {
            get
            {
                if (_fields == null)
                    _fields = DataEntityField.GetAll(this).ToArray();

                IEnumerable<DataEntityField> result = _fields;
                result = result.Where(field => !String.Equals(field.ObjectName, field.Parent.ObjectPrefix + "_LOCK", StringComparison.OrdinalIgnoreCase));
                result = result.Where(field => !String.Equals(field.ObjectName, field.Parent.ObjectPrefix + "_ADD_DATE", StringComparison.OrdinalIgnoreCase));
                result = result.Where(field => !String.Equals(field.ObjectName, field.Parent.ObjectPrefix + "_ADD_BY", StringComparison.OrdinalIgnoreCase));
                result = result.Where(field => !String.Equals(field.ObjectName, field.Parent.ObjectPrefix + "_MOD_DATE", StringComparison.OrdinalIgnoreCase));
                result = result.Where(field => !String.Equals(field.ObjectName, field.Parent.ObjectPrefix + "_MOD_BY", StringComparison.OrdinalIgnoreCase));
                result = result.Where(field => !String.Equals(field.ObjectName, field.Parent.ObjectPrefix + "_RCV_DATE", StringComparison.OrdinalIgnoreCase));
                result = result.Where(field => !String.Equals(field.ObjectName, field.Parent.ObjectPrefix + "_RCV_BY", StringComparison.OrdinalIgnoreCase));
                result = result.Where(field => !String.Equals(field.ObjectName, field.Parent.ObjectPrefix + "_RCV_FROM", StringComparison.OrdinalIgnoreCase));
                return result.ToArray();
            }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Saves changes to the entity
        /// </summary>
        public void Save()
        {
            this.Parent.Execute("SaveEntity", 
                this.ObjectId, 
                this.ObjectName,
                this.CodeName,
                this.CodeDescription,
                this.CodeDomain == null ? null : this.CodeDomain.Name,
                (this.CanCreate ? 1 : 0) + (this.CanCreate ? 2 : 0) + (this.CanCreate ? 4 : 0)
            );
        }

        private static DataEntity Parse(IDataRecord record, Database database)
        {
            return new DataEntity()
            {
                Parent = database,
                ObjectId = record["ObjectId"].ConvertTo<Int32>(),
                ObjectName = record["ObjectName"].ConvertTo<String>(),
                CodeName = record["CodeName"].ConvertTo<String>(),
                CodeDescription = record["CodeDescription"].ConvertTo<String>(),
                CodeDomain = database.Domains.FirstOrDefault(domain => String.Equals(domain.Name, record["CodeDomain"].ConvertTo<String>(), StringComparison.OrdinalIgnoreCase)),
                CanCreate = (record["CodeFlags"].ConvertTo<Int32>() & 1) == 1,
                CanModify = (record["CodeFlags"].ConvertTo<Int32>() & 2) == 2,
                CanRemove = (record["CodeFlags"].ConvertTo<Int32>() & 4) == 4,
            };
        }

        private static DataEntity Parse(IDataRecord record, DataDomain domain)
        {
            return new DataEntity()
            {
                Parent = domain.Parent,
                ObjectId = record["ObjectId"].ConvertTo<Int32>(),
                ObjectName = record["ObjectName"].ConvertTo<String>(),
                CodeName = record["CodeName"].ConvertTo<String>(),
                CodeDescription = record["CodeDescription"].ConvertTo<String>(),
                CodeDomain = domain,
                CanCreate = (record["CodeFlags"].ConvertTo<Int32>() & 1) == 1,
                CanModify = (record["CodeFlags"].ConvertTo<Int32>() & 2) == 2,
                CanRemove = (record["CodeFlags"].ConvertTo<Int32>() & 4) == 4,
            };
        }

        /// <summary>
        ///     Gets all entities that have been defined within the database.
        /// </summary>
        /// <param name="database">
        ///     The database in which the entities are defined.
        /// </param>
        /// <returns>
        ///     An enumerable collection of entities.
        /// </returns>
        public static IEnumerable<DataEntity> GetAll(Database database)
        {
            return database.Execute(DataEntity.Parse, database, "GetEntity", "");
        }

        /// <summary>
        ///     Gets all of the entities that pertain to specific domain.
        /// </summary>
        /// <param name="domain">
        ///     The domain in which the entities are defined.
        /// </param>
        /// <returns>
        ///     An enumerable collection of entities.
        /// </returns>
        public static IEnumerable<DataEntity> GetAll(DataDomain domain)
        {
            return domain.Parent.Execute(DataEntity.Parse, domain, "GetEntity", domain.Name);
        }

        #endregion
    }
}
