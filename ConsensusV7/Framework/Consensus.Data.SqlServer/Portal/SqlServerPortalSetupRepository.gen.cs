using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PortalSetupRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerPortalSetupRepository : SqlServerRepository<PortalSetupRecord, Int32>, IPortalSetupRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Portal"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "PortalSetup"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="PortalSetupRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_PS_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "PORTAL_SETUP"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="PortalSetupRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PortalSetupRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, PortalSetupRecord record)
        {
            record.Id = dataRecord["PS_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["PS_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["PS_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["PS_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["PS_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["PS_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["PS_RCV_FROM"].ConvertTo<String>();
            record.DisplayLogo = dataRecord["PS_DISPLAY_LOGO"].ConvertTo<Byte?>();
            record.LogoFile = dataRecord["PS_LOGO_FILE"].ConvertTo<String>();
            record.DisplayMenu = dataRecord["PS_DISPLAY_MENU"].ConvertTo<Byte?>();
            record.DisplayHeader = dataRecord["PS_DISPLAY_HEADER"].ConvertTo<Byte?>();
            record.DisplayFooter = dataRecord["PS_DISPLAY_FOOTER"].ConvertTo<Byte?>();
            record.CopyrightMessage = dataRecord["PS_COPYRIGHT_MESSAGE"].ConvertTo<String>();
            record.PstId = dataRecord["PS_PST_ID"].ConvertTo<Int32?>();
            record.PortalTitle = dataRecord["PS_PORTAL_TITLE"].ConvertTo<String>();
            record.StartPmenuId = dataRecord["PS_START_PMENU_ID"].ConvertTo<Int32?>();
            record.PortalUrl = dataRecord["PS_PORTAL_URL"].ConvertTo<String>();
            record.PortalLangPrefix = dataRecord["PS_PORTAL_LANG_PREFIX"].ConvertTo<String>();
            record.SessionTimeout = dataRecord["PS_SESSION_TIMEOUT"].ConvertTo<Int32>();
            record.SecureSite = dataRecord["PS_SECURE_SITE"].ConvertTo<Byte>();
            record.DisplayDate = dataRecord["PS_DISPLAY_DATE"].ConvertTo<Byte>();
            record.SingleSignon = dataRecord["PS_SINGLE_SIGNON"].ConvertTo<Byte>();
            record.PrincipOrgId = dataRecord["PS_PRINCIP_ORG_ID"].ConvertTo<String>();
            record.RssFeedTtl = dataRecord["PS_RSS_FEED_TTL"].ConvertTo<Int32?>();
            record.RssFeedChDesc = dataRecord["PS_RSS_FEED_CH_DESC"].ConvertTo<String>();
            record.GlbPmenuId = dataRecord["PS_GLB_PMENU_ID"].ConvertTo<Int32?>();
            record.TopMenuHtml = dataRecord["PS_TOP_MENU_HTML"].ConvertTo<String>();
            record.AdditionalHeadtags = dataRecord["PS_ADDITIONAL_HEADTAGS"].ConvertTo<String>();
            record.Bootstrap = dataRecord["PS_BOOTSTRAP"].ConvertTo<Byte>();
            record.Menubrand = dataRecord["PS_MENUBRAND"].ConvertTo<String>();
            record.FbAppId = dataRecord["PS_FB_APP_ID"].ConvertTo<String>();
            record.HideToolbarAnony = dataRecord["PS_HIDE_TOOLBAR_ANONY"].ConvertTo<Byte>();
            record.MiniImage = dataRecord["PS_MINI_IMAGE"].ConvertTo<String>();
            record.ImpersonateUser = dataRecord["PS_IMPERSONATE_USER"].ConvertTo<String>();
            record.ImpersonatePassword = dataRecord["PS_IMPERSONATE_PASSWORD"].ConvertTo<String>();
            record.LocalPath = dataRecord["PS_LOCAL_PATH"].ConvertTo<String>();
            record.GlobalLoginPmenuId = dataRecord["PS_GLOBAL_LOGIN_PMENU_ID"].ConvertTo<Int32?>();
            record.MessagesPmenuId = dataRecord["PS_MESSAGES_PMENU_ID"].ConvertTo<Int32?>();
            record.PrimaryProductPmenuId = dataRecord["PS_PRIMARY_PRODUCT_PMENU_ID"].ConvertTo<Int32?>();
            record.PrimaryEventPmenuId = dataRecord["PS_PRIMARY_EVENT_PMENU_ID"].ConvertTo<Int32?>();
            record.GoogleApiKey = dataRecord["PS_GOOGLE_API_KEY"].ConvertTo<String>();
            record.ShowBreadcrumb = dataRecord["PS_SHOW_BREADCRUMB"].ConvertTo<Byte>();
            record.ShowUserAvatar = dataRecord["PS_SHOW_USER_AVATAR"].ConvertTo<Byte>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PortalSetupRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, PortalSetupRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_PS_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_PS_DISPLAY_LOGO", record.DisplayLogo);
            this.MapParameterIn(command, "@PA_PS_LOGO_FILE", record.LogoFile);
            this.MapParameterIn(command, "@PA_PS_DISPLAY_MENU", record.DisplayMenu);
            this.MapParameterIn(command, "@PA_PS_DISPLAY_HEADER", record.DisplayHeader);
            this.MapParameterIn(command, "@PA_PS_DISPLAY_FOOTER", record.DisplayFooter);
            this.MapParameterIn(command, "@PA_PS_COPYRIGHT_MESSAGE", record.CopyrightMessage);
            this.MapParameterIn(command, "@PA_PS_PST_ID", record.PstId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PstId);
            this.MapParameterIn(command, "@PA_PS_PORTAL_TITLE", record.PortalTitle);
            this.MapParameterIn(command, "@PA_PS_START_PMENU_ID", record.StartPmenuId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.StartPmenuId);
            this.MapParameterIn(command, "@PA_PS_PORTAL_URL", record.PortalUrl);
            this.MapParameterIn(command, "@PA_PS_PORTAL_LANG_PREFIX", record.PortalLangPrefix);
            this.MapParameterIn(command, "@PA_PS_SESSION_TIMEOUT", record.SessionTimeout == Int32.MinValue ? 15 : record.SessionTimeout);
            this.MapParameterIn(command, "@PA_PS_SECURE_SITE", record.SecureSite);
            this.MapParameterIn(command, "@PA_PS_DISPLAY_DATE", record.DisplayDate);
            this.MapParameterIn(command, "@PA_PS_SINGLE_SIGNON", record.SingleSignon);
            this.MapParameterIn(command, "@PA_PS_PRINCIP_ORG_ID", record.PrincipOrgId);
            this.MapParameterIn(command, "@PA_PS_RSS_FEED_TTL", record.RssFeedTtl == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.RssFeedTtl);
            this.MapParameterIn(command, "@PA_PS_RSS_FEED_CH_DESC", record.RssFeedChDesc);
            this.MapParameterIn(command, "@PA_PS_GLB_PMENU_ID", record.GlbPmenuId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.GlbPmenuId);
            this.MapParameterIn(command, "@PA_PS_TOP_MENU_HTML", record.TopMenuHtml);
            this.MapParameterIn(command, "@PA_PS_ADDITIONAL_HEADTAGS", record.AdditionalHeadtags);
            this.MapParameterIn(command, "@PA_PS_BOOTSTRAP", record.Bootstrap);
            this.MapParameterIn(command, "@PA_PS_MENUBRAND", record.Menubrand);
            this.MapParameterIn(command, "@PA_PS_FB_APP_ID", record.FbAppId);
            this.MapParameterIn(command, "@PA_PS_HIDE_TOOLBAR_ANONY", record.HideToolbarAnony);
            this.MapParameterIn(command, "@PA_PS_MINI_IMAGE", record.MiniImage);
            this.MapParameterIn(command, "@PA_PS_IMPERSONATE_USER", record.ImpersonateUser);
            this.MapParameterIn(command, "@PA_PS_IMPERSONATE_PASSWORD", record.ImpersonatePassword);
            this.MapParameterIn(command, "@PA_PS_LOCAL_PATH", record.LocalPath);
            this.MapParameterIn(command, "@PA_PS_GLOBAL_LOGIN_PMENU_ID", record.GlobalLoginPmenuId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.GlobalLoginPmenuId);
            this.MapParameterIn(command, "@PA_PS_MESSAGES_PMENU_ID", record.MessagesPmenuId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.MessagesPmenuId);
            this.MapParameterIn(command, "@PA_PS_PRIMARY_PRODUCT_PMENU_ID", record.PrimaryProductPmenuId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PrimaryProductPmenuId);
            this.MapParameterIn(command, "@PA_PS_PRIMARY_EVENT_PMENU_ID", record.PrimaryEventPmenuId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PrimaryEventPmenuId);
            this.MapParameterIn(command, "@PA_PS_GOOGLE_API_KEY", record.GoogleApiKey);
            this.MapParameterIn(command, "@PA_PS_SHOW_BREADCRUMB", record.ShowBreadcrumb);
            this.MapParameterIn(command, "@PA_PS_SHOW_USER_AVATAR", record.ShowUserAvatar);
            this.MapParameterIn(command, "@_AUDIT_USER_ID", UserId);
            this.MapParameterIn(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Extracts the parameter values for the specified <paramref name="command" /> and applies the values to the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PortalSetupRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, PortalSetupRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_PS_ID", record.Id);
            record.DisplayLogo = this.MapParameterOut(command, "@PA_PS_DISPLAY_LOGO", record.DisplayLogo);
            record.LogoFile = this.MapParameterOut(command, "@PA_PS_LOGO_FILE", record.LogoFile);
            record.DisplayMenu = this.MapParameterOut(command, "@PA_PS_DISPLAY_MENU", record.DisplayMenu);
            record.DisplayHeader = this.MapParameterOut(command, "@PA_PS_DISPLAY_HEADER", record.DisplayHeader);
            record.DisplayFooter = this.MapParameterOut(command, "@PA_PS_DISPLAY_FOOTER", record.DisplayFooter);
            record.CopyrightMessage = this.MapParameterOut(command, "@PA_PS_COPYRIGHT_MESSAGE", record.CopyrightMessage);
            record.PstId = this.MapParameterOut(command, "@PA_PS_PST_ID", record.PstId);
            record.PortalTitle = this.MapParameterOut(command, "@PA_PS_PORTAL_TITLE", record.PortalTitle);
            record.StartPmenuId = this.MapParameterOut(command, "@PA_PS_START_PMENU_ID", record.StartPmenuId);
            record.PortalUrl = this.MapParameterOut(command, "@PA_PS_PORTAL_URL", record.PortalUrl);
            record.PortalLangPrefix = this.MapParameterOut(command, "@PA_PS_PORTAL_LANG_PREFIX", record.PortalLangPrefix);
            record.SessionTimeout = this.MapParameterOut(command, "@PA_PS_SESSION_TIMEOUT", record.SessionTimeout);
            record.SecureSite = this.MapParameterOut(command, "@PA_PS_SECURE_SITE", record.SecureSite);
            record.DisplayDate = this.MapParameterOut(command, "@PA_PS_DISPLAY_DATE", record.DisplayDate);
            record.SingleSignon = this.MapParameterOut(command, "@PA_PS_SINGLE_SIGNON", record.SingleSignon);
            record.PrincipOrgId = this.MapParameterOut(command, "@PA_PS_PRINCIP_ORG_ID", record.PrincipOrgId);
            record.RssFeedTtl = this.MapParameterOut(command, "@PA_PS_RSS_FEED_TTL", record.RssFeedTtl);
            record.RssFeedChDesc = this.MapParameterOut(command, "@PA_PS_RSS_FEED_CH_DESC", record.RssFeedChDesc);
            record.GlbPmenuId = this.MapParameterOut(command, "@PA_PS_GLB_PMENU_ID", record.GlbPmenuId);
            record.TopMenuHtml = this.MapParameterOut(command, "@PA_PS_TOP_MENU_HTML", record.TopMenuHtml);
            record.AdditionalHeadtags = this.MapParameterOut(command, "@PA_PS_ADDITIONAL_HEADTAGS", record.AdditionalHeadtags);
            record.Bootstrap = this.MapParameterOut(command, "@PA_PS_BOOTSTRAP", record.Bootstrap);
            record.Menubrand = this.MapParameterOut(command, "@PA_PS_MENUBRAND", record.Menubrand);
            record.FbAppId = this.MapParameterOut(command, "@PA_PS_FB_APP_ID", record.FbAppId);
            record.HideToolbarAnony = this.MapParameterOut(command, "@PA_PS_HIDE_TOOLBAR_ANONY", record.HideToolbarAnony);
            record.MiniImage = this.MapParameterOut(command, "@PA_PS_MINI_IMAGE", record.MiniImage);
            record.ImpersonateUser = this.MapParameterOut(command, "@PA_PS_IMPERSONATE_USER", record.ImpersonateUser);
            record.ImpersonatePassword = this.MapParameterOut(command, "@PA_PS_IMPERSONATE_PASSWORD", record.ImpersonatePassword);
            record.LocalPath = this.MapParameterOut(command, "@PA_PS_LOCAL_PATH", record.LocalPath);
            record.GlobalLoginPmenuId = this.MapParameterOut(command, "@PA_PS_GLOBAL_LOGIN_PMENU_ID", record.GlobalLoginPmenuId);
            record.MessagesPmenuId = this.MapParameterOut(command, "@PA_PS_MESSAGES_PMENU_ID", record.MessagesPmenuId);
            record.PrimaryProductPmenuId = this.MapParameterOut(command, "@PA_PS_PRIMARY_PRODUCT_PMENU_ID", record.PrimaryProductPmenuId);
            record.PrimaryEventPmenuId = this.MapParameterOut(command, "@PA_PS_PRIMARY_EVENT_PMENU_ID", record.PrimaryEventPmenuId);
            record.GoogleApiKey = this.MapParameterOut(command, "@PA_PS_GOOGLE_API_KEY", record.GoogleApiKey);
            record.ShowBreadcrumb = this.MapParameterOut(command, "@PA_PS_SHOW_BREADCRUMB", record.ShowBreadcrumb);
            record.ShowUserAvatar = this.MapParameterOut(command, "@PA_PS_SHOW_USER_AVATAR", record.ShowUserAvatar);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IPortalSetupRepository.TableName
        {
            get { return this.TableName; }
        }

        #endregion
    }
}
