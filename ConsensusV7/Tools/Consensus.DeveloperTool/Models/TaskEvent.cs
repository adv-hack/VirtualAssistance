using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Represents an event raised by a generation task
    /// </summary>
    public delegate void TaskEvent();

    /// <summary>
    ///     Represents an event raised by a generation task
    /// </summary>
    public delegate void TaskEvent<T>(T data);
}
