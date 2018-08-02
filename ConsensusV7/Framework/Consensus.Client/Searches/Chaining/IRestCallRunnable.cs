using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Searches
{
    interface IRestCallRunnable : IRunnable
    {
        new IEnumerable<Proxy> Run();
    }
}
