using Consensus.Document;
using Consensus.Searches;
using Consensus.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.document.controls
{
    public partial class PackEmailDetail : BaseControl<Pack, String>
    {
        #region Properties

        public override String DataTypeName
        {
            get { return "Email"; }
        }

        #endregion

        #region Methods

        protected override void OnPreRender(EventArgs eventArguments)
        {
            base.OnPreRender(eventArguments);

            var mergeFields = new List<string>();
            if (this.DataSource != null && this.DataSource.Id != null)
            {
                //Gets Merge fields depending on selected Packtype
                var packTypeObject = Packtype.FetchAll().Where(x => x.Type == this.DataSource.PackType).FirstOrDefault();
                if (packTypeObject != null)
                {
                    var mergeFieldListFromView = Query.Create()
                           .Select("COLUMN_NAME")
                           .From(QuerySources.PackMergeFields)
                           .WhereRaw("(TABLE_NAME = '" + packTypeObject.StoredProc + "' and COLUMN_NAME not like 'PR_ID%')", null)
                           .OrderBy("COLUMN_NAME", true)
                           .Run();

                    foreach (var field in mergeFieldListFromView)
                    {
                        mergeFields.Add(field.Values.First().ToString());
                    }
                }
                
                this.SubjectMerge.DataSource = mergeFields;
                this.BodyMerge.DataSource = mergeFields;

                //Checks if Word Template is linked to Pack
                var isWordTemplateLinkedToPack = false;
               
                var packList = Query.Create()
                       .Select("LIT_ID")
                       .From(QuerySources.DocumentTemplates)
                       .WhereRaw("(PACKXREF_PACK_ID = '" + this.DataSource.Id + "' and TYPE = 'Word Template' and IS_COVER_PAGE=1)", null)
                       .Run();

                if (packList.Count() > 0)
                {
                    isWordTemplateLinkedToPack = true;
                }                
                
                if (isWordTemplateLinkedToPack)
                {
                    this.Body.IsReadOnly = ConfigurableBoolean.TrueEnforced;
                    this.BodyMerge.IsReadOnly = ConfigurableBoolean.TrueEnforced;
                }

            }
        }

        #endregion
    }
}