using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Represents the "PORTAL_SETUP" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class PortalSetupRecord : Record<Int32>, Cloneable<PortalSetupRecord>, IEquatable<PortalSetupRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "PS_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "PS_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "PS_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "PS_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "PS_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "PS_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "PS_DISPLAY_LOGO" field.
        /// </summary>
        private Byte? _displayLogo;

        /// <summary>
        ///     the value of the "PS_LOGO_FILE" field.
        /// </summary>
        private String _logoFile;

        /// <summary>
        ///     the value of the "PS_DISPLAY_MENU" field.
        /// </summary>
        private Byte? _displayMenu;

        /// <summary>
        ///     the value of the "PS_DISPLAY_HEADER" field.
        /// </summary>
        private Byte? _displayHeader;

        /// <summary>
        ///     the value of the "PS_DISPLAY_FOOTER" field.
        /// </summary>
        private Byte? _displayFooter;

        /// <summary>
        ///     the value of the "PS_COPYRIGHT_MESSAGE" field.
        /// </summary>
        private String _copyrightMessage;

        /// <summary>
        ///     the value of the "PS_PST_ID" field.
        /// </summary>
        private Int32? _pstId;

        /// <summary>
        ///     the value of the "PS_PORTAL_TITLE" field.
        /// </summary>
        private String _portalTitle;

        /// <summary>
        ///     the value of the "PS_START_PMENU_ID" field.
        /// </summary>
        private Int32? _startPmenuId;

        /// <summary>
        ///     the value of the "PS_PORTAL_URL" field.
        /// </summary>
        private String _portalUrl;

        /// <summary>
        ///     the value of the "PS_PORTAL_LANG_PREFIX" field.
        /// </summary>
        private String _portalLangPrefix;

        /// <summary>
        ///     the value of the "PS_SESSION_TIMEOUT" field.
        /// </summary>
        private Int32 _sessionTimeout;

        /// <summary>
        ///     the value of the "PS_SECURE_SITE" field.
        /// </summary>
        private Byte _secureSite;

        /// <summary>
        ///     the value of the "PS_DISPLAY_DATE" field.
        /// </summary>
        private Byte _displayDate;

        /// <summary>
        ///     the value of the "PS_SINGLE_SIGNON" field.
        /// </summary>
        private Byte _singleSignon;

        /// <summary>
        ///     the value of the "PS_PRINCIP_ORG_ID" field.
        /// </summary>
        private String _principOrgId;

        /// <summary>
        ///     the value of the "PS_RSS_FEED_TTL" field.
        /// </summary>
        private Int32? _rssFeedTtl;

        /// <summary>
        ///     the value of the "PS_RSS_FEED_CH_DESC" field.
        /// </summary>
        private String _rssFeedChDesc;

        /// <summary>
        ///     the value of the "PS_GLB_PMENU_ID" field.
        /// </summary>
        private Int32? _glbPmenuId;

        /// <summary>
        ///     the value of the "PS_TOP_MENU_HTML" field.
        /// </summary>
        private String _topMenuHtml;

        /// <summary>
        ///     the value of the "PS_ADDITIONAL_HEADTAGS" field.
        /// </summary>
        private String _additionalHeadtags;

        /// <summary>
        ///     the value of the "PS_BOOTSTRAP" field.
        /// </summary>
        private Byte _bootstrap;

        /// <summary>
        ///     the value of the "PS_MENUBRAND" field.
        /// </summary>
        private String _menubrand;

        /// <summary>
        ///     the value of the "PS_FB_APP_ID" field.
        /// </summary>
        private String _fbAppId;

        /// <summary>
        ///     the value of the "PS_HIDE_TOOLBAR_ANONY" field.
        /// </summary>
        private Byte _hideToolbarAnony;

        /// <summary>
        ///     the value of the "PS_MINI_IMAGE" field.
        /// </summary>
        private String _miniImage;

        /// <summary>
        ///     the value of the "PS_IMPERSONATE_USER" field.
        /// </summary>
        private String _impersonateUser;

        /// <summary>
        ///     the value of the "PS_IMPERSONATE_PASSWORD" field.
        /// </summary>
        private String _impersonatePassword;

        /// <summary>
        ///     the value of the "PS_LOCAL_PATH" field.
        /// </summary>
        private String _localPath;

        /// <summary>
        ///     the value of the "PS_GLOBAL_LOGIN_PMENU_ID" field.
        /// </summary>
        private Int32? _globalLoginPmenuId;

        /// <summary>
        ///     the value of the "PS_MESSAGES_PMENU_ID" field.
        /// </summary>
        private Int32? _messagesPmenuId;

        /// <summary>
        ///     the value of the "PS_PRIMARY_PRODUCT_PMENU_ID" field.
        /// </summary>
        private Int32? _primaryProductPmenuId;

        /// <summary>
        ///     the value of the "PS_PRIMARY_EVENT_PMENU_ID" field.
        /// </summary>
        private Int32? _primaryEventPmenuId;

        /// <summary>
        ///     the value of the "PS_GOOGLE_API_KEY" field.
        /// </summary>
        private String _googleApiKey;

        /// <summary>
        ///     the value of the "PS_SHOW_BREADCRUMB" field.
        /// </summary>
        private Byte _showBreadcrumb;

        /// <summary>
        ///     the value of the "PS_SHOW_USER_AVATAR" field.
        /// </summary>
        private Byte _showUserAvatar;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "PS_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "PS_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "PS_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "PS_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "PS_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "PS_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "PS_DISPLAY_LOGO" field.
        /// </summary>
        public Byte? DisplayLogo
        {
            get { return _displayLogo; }
            set { _displayLogo = value; }
        }

        /// <summary>
        ///     the value of the "PS_LOGO_FILE" field.
        /// </summary>
        public String LogoFile
        {
            get { return _logoFile; }
            set { _logoFile = value; }
        }

        /// <summary>
        ///     the value of the "PS_DISPLAY_MENU" field.
        /// </summary>
        public Byte? DisplayMenu
        {
            get { return _displayMenu; }
            set { _displayMenu = value; }
        }

        /// <summary>
        ///     the value of the "PS_DISPLAY_HEADER" field.
        /// </summary>
        public Byte? DisplayHeader
        {
            get { return _displayHeader; }
            set { _displayHeader = value; }
        }

        /// <summary>
        ///     the value of the "PS_DISPLAY_FOOTER" field.
        /// </summary>
        public Byte? DisplayFooter
        {
            get { return _displayFooter; }
            set { _displayFooter = value; }
        }

        /// <summary>
        ///     the value of the "PS_COPYRIGHT_MESSAGE" field.
        /// </summary>
        public String CopyrightMessage
        {
            get { return _copyrightMessage; }
            set { _copyrightMessage = value; }
        }

        /// <summary>
        ///     the value of the "PS_PST_ID" field.
        /// </summary>
        public Int32? PstId
        {
            get { return _pstId; }
            set { _pstId = value; }
        }

        /// <summary>
        ///     the value of the "PS_PORTAL_TITLE" field.
        /// </summary>
        public String PortalTitle
        {
            get { return _portalTitle; }
            set { _portalTitle = value; }
        }

        /// <summary>
        ///     the value of the "PS_START_PMENU_ID" field.
        /// </summary>
        public Int32? StartPmenuId
        {
            get { return _startPmenuId; }
            set { _startPmenuId = value; }
        }

        /// <summary>
        ///     the value of the "PS_PORTAL_URL" field.
        /// </summary>
        public String PortalUrl
        {
            get { return _portalUrl; }
            set { _portalUrl = value; }
        }

        /// <summary>
        ///     the value of the "PS_PORTAL_LANG_PREFIX" field.
        /// </summary>
        public String PortalLangPrefix
        {
            get { return _portalLangPrefix; }
            set { _portalLangPrefix = value; }
        }

        /// <summary>
        ///     the value of the "PS_SESSION_TIMEOUT" field.
        /// </summary>
        public Int32 SessionTimeout
        {
            get { return _sessionTimeout; }
            set { _sessionTimeout = value; }
        }

        /// <summary>
        ///     the value of the "PS_SECURE_SITE" field.
        /// </summary>
        public Byte SecureSite
        {
            get { return _secureSite; }
            set { _secureSite = value; }
        }

        /// <summary>
        ///     the value of the "PS_DISPLAY_DATE" field.
        /// </summary>
        public Byte DisplayDate
        {
            get { return _displayDate; }
            set { _displayDate = value; }
        }

        /// <summary>
        ///     the value of the "PS_SINGLE_SIGNON" field.
        /// </summary>
        public Byte SingleSignon
        {
            get { return _singleSignon; }
            set { _singleSignon = value; }
        }

        /// <summary>
        ///     the value of the "PS_PRINCIP_ORG_ID" field.
        /// </summary>
        public String PrincipOrgId
        {
            get { return _principOrgId; }
            set { _principOrgId = value; }
        }

        /// <summary>
        ///     the value of the "PS_RSS_FEED_TTL" field.
        /// </summary>
        public Int32? RssFeedTtl
        {
            get { return _rssFeedTtl; }
            set { _rssFeedTtl = value; }
        }

        /// <summary>
        ///     the value of the "PS_RSS_FEED_CH_DESC" field.
        /// </summary>
        public String RssFeedChDesc
        {
            get { return _rssFeedChDesc; }
            set { _rssFeedChDesc = value; }
        }

        /// <summary>
        ///     the value of the "PS_GLB_PMENU_ID" field.
        /// </summary>
        public Int32? GlbPmenuId
        {
            get { return _glbPmenuId; }
            set { _glbPmenuId = value; }
        }

        /// <summary>
        ///     the value of the "PS_TOP_MENU_HTML" field.
        /// </summary>
        public String TopMenuHtml
        {
            get { return _topMenuHtml; }
            set { _topMenuHtml = value; }
        }

        /// <summary>
        ///     the value of the "PS_ADDITIONAL_HEADTAGS" field.
        /// </summary>
        public String AdditionalHeadtags
        {
            get { return _additionalHeadtags; }
            set { _additionalHeadtags = value; }
        }

        /// <summary>
        ///     the value of the "PS_BOOTSTRAP" field.
        /// </summary>
        public Byte Bootstrap
        {
            get { return _bootstrap; }
            set { _bootstrap = value; }
        }

        /// <summary>
        ///     the value of the "PS_MENUBRAND" field.
        /// </summary>
        public String Menubrand
        {
            get { return _menubrand; }
            set { _menubrand = value; }
        }

        /// <summary>
        ///     the value of the "PS_FB_APP_ID" field.
        /// </summary>
        public String FbAppId
        {
            get { return _fbAppId; }
            set { _fbAppId = value; }
        }

        /// <summary>
        ///     the value of the "PS_HIDE_TOOLBAR_ANONY" field.
        /// </summary>
        public Byte HideToolbarAnony
        {
            get { return _hideToolbarAnony; }
            set { _hideToolbarAnony = value; }
        }

        /// <summary>
        ///     the value of the "PS_MINI_IMAGE" field.
        /// </summary>
        public String MiniImage
        {
            get { return _miniImage; }
            set { _miniImage = value; }
        }

        /// <summary>
        ///     the value of the "PS_IMPERSONATE_USER" field.
        /// </summary>
        public String ImpersonateUser
        {
            get { return _impersonateUser; }
            set { _impersonateUser = value; }
        }

        /// <summary>
        ///     the value of the "PS_IMPERSONATE_PASSWORD" field.
        /// </summary>
        public String ImpersonatePassword
        {
            get { return _impersonatePassword; }
            set { _impersonatePassword = value; }
        }

        /// <summary>
        ///     the value of the "PS_LOCAL_PATH" field.
        /// </summary>
        public String LocalPath
        {
            get { return _localPath; }
            set { _localPath = value; }
        }

        /// <summary>
        ///     the value of the "PS_GLOBAL_LOGIN_PMENU_ID" field.
        /// </summary>
        public Int32? GlobalLoginPmenuId
        {
            get { return _globalLoginPmenuId; }
            set { _globalLoginPmenuId = value; }
        }

        /// <summary>
        ///     the value of the "PS_MESSAGES_PMENU_ID" field.
        /// </summary>
        public Int32? MessagesPmenuId
        {
            get { return _messagesPmenuId; }
            set { _messagesPmenuId = value; }
        }

        /// <summary>
        ///     the value of the "PS_PRIMARY_PRODUCT_PMENU_ID" field.
        /// </summary>
        public Int32? PrimaryProductPmenuId
        {
            get { return _primaryProductPmenuId; }
            set { _primaryProductPmenuId = value; }
        }

        /// <summary>
        ///     the value of the "PS_PRIMARY_EVENT_PMENU_ID" field.
        /// </summary>
        public Int32? PrimaryEventPmenuId
        {
            get { return _primaryEventPmenuId; }
            set { _primaryEventPmenuId = value; }
        }

        /// <summary>
        ///     the value of the "PS_GOOGLE_API_KEY" field.
        /// </summary>
        public String GoogleApiKey
        {
            get { return _googleApiKey; }
            set { _googleApiKey = value; }
        }

        /// <summary>
        ///     the value of the "PS_SHOW_BREADCRUMB" field.
        /// </summary>
        public Byte ShowBreadcrumb
        {
            get { return _showBreadcrumb; }
            set { _showBreadcrumb = value; }
        }

        /// <summary>
        ///     the value of the "PS_SHOW_USER_AVATAR" field.
        /// </summary>
        public Byte ShowUserAvatar
        {
            get { return _showUserAvatar; }
            set { _showUserAvatar = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="PortalSetupRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="PortalSetupRecord" /> object instance.
        /// </returns>
        public PortalSetupRecord Clone()
        {
            PortalSetupRecord record = new PortalSetupRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.DisplayLogo = this.DisplayLogo;
            record.LogoFile = this.LogoFile;
            record.DisplayMenu = this.DisplayMenu;
            record.DisplayHeader = this.DisplayHeader;
            record.DisplayFooter = this.DisplayFooter;
            record.CopyrightMessage = this.CopyrightMessage;
            record.PstId = this.PstId;
            record.PortalTitle = this.PortalTitle;
            record.StartPmenuId = this.StartPmenuId;
            record.PortalUrl = this.PortalUrl;
            record.PortalLangPrefix = this.PortalLangPrefix;
            record.SessionTimeout = this.SessionTimeout;
            record.SecureSite = this.SecureSite;
            record.DisplayDate = this.DisplayDate;
            record.SingleSignon = this.SingleSignon;
            record.PrincipOrgId = this.PrincipOrgId;
            record.RssFeedTtl = this.RssFeedTtl;
            record.RssFeedChDesc = this.RssFeedChDesc;
            record.GlbPmenuId = this.GlbPmenuId;
            record.TopMenuHtml = this.TopMenuHtml;
            record.AdditionalHeadtags = this.AdditionalHeadtags;
            record.Bootstrap = this.Bootstrap;
            record.Menubrand = this.Menubrand;
            record.FbAppId = this.FbAppId;
            record.HideToolbarAnony = this.HideToolbarAnony;
            record.MiniImage = this.MiniImage;
            record.ImpersonateUser = this.ImpersonateUser;
            record.ImpersonatePassword = this.ImpersonatePassword;
            record.LocalPath = this.LocalPath;
            record.GlobalLoginPmenuId = this.GlobalLoginPmenuId;
            record.MessagesPmenuId = this.MessagesPmenuId;
            record.PrimaryProductPmenuId = this.PrimaryProductPmenuId;
            record.PrimaryEventPmenuId = this.PrimaryEventPmenuId;
            record.GoogleApiKey = this.GoogleApiKey;
            record.ShowBreadcrumb = this.ShowBreadcrumb;
            record.ShowUserAvatar = this.ShowUserAvatar;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="PortalSetupRecord" /> instance is equal to another <see cref="PortalSetupRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="PortalSetupRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(PortalSetupRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.DisplayLogo == that.DisplayLogo);
            result = result && (this.LogoFile.TrimOrNullify() == that.LogoFile.TrimOrNullify());
            result = result && (this.DisplayMenu == that.DisplayMenu);
            result = result && (this.DisplayHeader == that.DisplayHeader);
            result = result && (this.DisplayFooter == that.DisplayFooter);
            result = result && (this.CopyrightMessage.TrimOrNullify() == that.CopyrightMessage.TrimOrNullify());
            result = result && (this.PstId == that.PstId);
            result = result && (this.PortalTitle.TrimOrNullify() == that.PortalTitle.TrimOrNullify());
            result = result && (this.StartPmenuId == that.StartPmenuId);
            result = result && (this.PortalUrl.TrimOrNullify() == that.PortalUrl.TrimOrNullify());
            result = result && (this.PortalLangPrefix.TrimOrNullify() == that.PortalLangPrefix.TrimOrNullify());
            result = result && (this.SessionTimeout == that.SessionTimeout);
            result = result && (this.SecureSite == that.SecureSite);
            result = result && (this.DisplayDate == that.DisplayDate);
            result = result && (this.SingleSignon == that.SingleSignon);
            result = result && (this.PrincipOrgId.TrimOrNullify() == that.PrincipOrgId.TrimOrNullify());
            result = result && (this.RssFeedTtl == that.RssFeedTtl);
            result = result && (this.RssFeedChDesc.TrimOrNullify() == that.RssFeedChDesc.TrimOrNullify());
            result = result && (this.GlbPmenuId == that.GlbPmenuId);
            result = result && (this.TopMenuHtml.TrimOrNullify() == that.TopMenuHtml.TrimOrNullify());
            result = result && (this.AdditionalHeadtags.TrimOrNullify() == that.AdditionalHeadtags.TrimOrNullify());
            result = result && (this.Bootstrap == that.Bootstrap);
            result = result && (this.Menubrand.TrimOrNullify() == that.Menubrand.TrimOrNullify());
            result = result && (this.FbAppId.TrimOrNullify() == that.FbAppId.TrimOrNullify());
            result = result && (this.HideToolbarAnony == that.HideToolbarAnony);
            result = result && (this.MiniImage.TrimOrNullify() == that.MiniImage.TrimOrNullify());
            result = result && (this.ImpersonateUser.TrimOrNullify() == that.ImpersonateUser.TrimOrNullify());
            result = result && (this.ImpersonatePassword.TrimOrNullify() == that.ImpersonatePassword.TrimOrNullify());
            result = result && (this.LocalPath.TrimOrNullify() == that.LocalPath.TrimOrNullify());
            result = result && (this.GlobalLoginPmenuId == that.GlobalLoginPmenuId);
            result = result && (this.MessagesPmenuId == that.MessagesPmenuId);
            result = result && (this.PrimaryProductPmenuId == that.PrimaryProductPmenuId);
            result = result && (this.PrimaryEventPmenuId == that.PrimaryEventPmenuId);
            result = result && (this.GoogleApiKey.TrimOrNullify() == that.GoogleApiKey.TrimOrNullify());
            result = result && (this.ShowBreadcrumb == that.ShowBreadcrumb);
            result = result && (this.ShowUserAvatar == that.ShowUserAvatar);
            return result;
        }

        #endregion
    }
}
