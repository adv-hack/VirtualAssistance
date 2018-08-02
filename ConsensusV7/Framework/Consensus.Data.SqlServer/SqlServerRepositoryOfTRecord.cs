using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus
{
    /// <summary>
    ///     Provides the abstraction for repositories which persist and retrieve the <typeparamref name="TRecord" /> data structure, in a Microsoft SQL Server database.
    /// </summary>
    public abstract partial class SqlServerRepository<TRecord>
    {
    }
}
