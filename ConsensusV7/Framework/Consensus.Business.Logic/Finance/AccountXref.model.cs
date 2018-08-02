using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="AccountXrefRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalAccountXrefModel
    {
        private bool _mainSave;        
        protected override void ResolveDependent()
        {            
            base.ResolveDependent();
            if (this.Main == 1 && !_mainSave)
            {                                
                var otherDefaults = this.Provider.Finance.AccountXref.FetchAllByAccountId(this.AccountId).Where(acc => acc.RoleId != this.RoleId).ToArray();
                otherDefaults.Execute(acc => acc.Main = 0).Execute(acc => acc._mainSave = true).Execute(acc => acc.Save());
            }
            if (this.MustUse == 1 && !_mainSave)
            {
                var otherDefaultscontacts = this.Provider.Finance.AccountXref.FetchAllByAccountId(this.AccountId).Where(acc => acc.RoleId != this.RoleId || acc.RoleId == null).ToArray();
                otherDefaultscontacts.Execute(acc => acc.MustUse = 0).Execute(acc => acc._mainSave = true).Execute(acc => acc.Save());
            }
        }
    }
}
