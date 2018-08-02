using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Consensus.Web.BackOffice.assets.templates;
using Consensus.Searches;

namespace Consensus.Web.BackOffice
{
    /// <summary>
    ///     Provides the abstraction for authenticated pages which screenObjectDisplay data.
    /// </summary>
    /// <typeparam name="TProxy">
    ///     The type of data that is displayed
    /// </typeparam>
    public abstract class BaseStandardPage<TProxy, TKey> : BaseStandardPage<TProxy> where TProxy : Proxy
    {
        #region fields

        /// <summary>
        ///     The instance of the API object that is presented within the page.
        /// </summary>
        private TProxy _data;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public abstract Func<TKey, TProxy> DataLoader
        {
            get;
        }
        
        /// <summary>
        ///     Gets the delegated method for instantiating a new API object that is presented within the page.
        /// </summary>
        public virtual Func<TProxy> DataCreator
        {
            get { return null; }
        }

        /// <summary>
        ///     Gets the unique identifier for the API object that is presented within the page.
        /// </summary>
        public virtual TKey DataId
        {
            get { return this.Request.QueryString["id"].ConvertTo<TKey>(); }
        }

        /// <summary>
        ///     Gets the instance of the API object that is presented within the page.
        /// </summary>
        public override TProxy Data
        {
            get
            {
                if (_data == null)
                {
                    // If an id has been specified, load the data using the ID
                    if (!Object.Equals(this.DataId, default(TKey)) && this.DataLoader != null)
                        _data = this.DataLoader(this.DataId);

                    // If an id has not been specified, create a new instance.
                    if (Object.Equals(this.DataId, default(TKey)) && this.DataCreator != null)
                        _data = this.DataCreator();
                }
                return _data;
            }
        }

        /// <summary>
        ///     Gets the ID of the object being saved via the REST api
        /// </summary>
        public override String SaveId
        {
            get { return (typeof(TKey).In(typeof(int), typeof(long), typeof(byte), typeof(short)) && this.DataId.ConvertTo<long>() == 0) ? "" : this.DataId.ConvertTo<String>(); }
        }
        
        public void SetSendPackSidebarOption()
        {
            if (Data != null && !Object.Equals(this.DataId, default(TKey)))
            {
                string parentUrl = Data.GetType().FullName.Substring(10).Replace(".", "/");

                // Matt wanted to see the "Send Pack" option, even if there were no packs available to be sent for the type.
                //IQueryRunnable packQuery = Query.Create()
                //    .Select("PACK_TYPE")
                //    .From(QuerySources.Packs)
                //    .Where("PARENT_URL", QueryConditionTypes.Equal, parentUrl);

                //IList<Dictionary<string, object>> results = packQuery.Run();

                //if (results.Count > 0)
                //{
                this.PopulateSideBar("javascript:consensus.web.sendPack('" + parentUrl + "', " + System.Web.HttpUtility.JavaScriptStringEncode(DataId.ToString(), true) + 
                    ", function(){ alert('Pack queued for sending successfully'); });", "Send Pack");
                //}
            }
        }
        #endregion
    }
}