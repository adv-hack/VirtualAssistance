using System;

namespace Consensus
{
    /// <summary>
    ///     Supports cloning, which creates a new instance of a class with the same values as the current object instance.
    /// </summary>
    /// <typeparam name="T">
    ///     The type of object that is cloned.
    /// </typeparam>
    public interface Cloneable<T>
    {
        /// <summary>
        ///     Creates a new <typeparamref name="T" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <typeparamref name="T" /> object instance.
        /// </returns>
        T Clone();
    }
}
