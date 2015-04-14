using System;

namespace Scalesque {

    /// <summary>
    /// Extractor for Some&lt;T&gt;
    /// </summary>
    public static class Some {
        public static Option<T> unapply<T>(Option<T> option) {
            return option;
        }
    }

    /// <summary>
    /// Extractor for None.
    /// </summary>
    public sealed class None {

        /// <summary>
        ///  Instance use, scalesque only (improves c# compiler type inference)
        /// </summary>
        internal None() { }

        public static bool unapply<T>(Option<T> option) {
            return !option.HasValue;
        }

        /// <summary>
        /// Option equality that checks against the two different None types
        /// </summary>
        /// <param name="obj">Object to compare this object against</param>
        /// <returns>True if obj is a None, otherwise False</returns>
        public override bool Equals(object obj) {
          return Option.IsNone(obj);
        }
    }
}
