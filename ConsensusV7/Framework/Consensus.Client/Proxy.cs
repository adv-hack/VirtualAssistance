using System;

namespace Consensus
{
    /// <summary>
    ///     Provides the abstraction for consumable client classes which provide composition of the business model and business factory instances.
    /// </summary>
    public abstract class Proxy
    {
        public abstract void Delete();
        
        public abstract void Save();

        public abstract Boolean IsPersisted
        {
            get;
        }

        public abstract Boolean IsModified
        {
            get;
        }
    }
}
