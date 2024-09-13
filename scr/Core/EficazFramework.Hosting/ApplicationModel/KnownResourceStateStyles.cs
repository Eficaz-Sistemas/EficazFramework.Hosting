using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EficazFramework.Hosting.ApplicationModel
{
    /// <summary>
    /// The set of well known resource states.
    /// </summary>
    public static class KnownResourceStateStyles
    {
        /// <summary>
        /// The success state
        /// </summary>
        public static readonly string Success = "success";

        /// <summary>
        /// The error state. Useful for error messages.
        /// </summary>
        public static readonly string Error = "error";

        /// <summary>
        /// The info state. Useful for infomational messages.
        /// </summary>
        public static readonly string Info = "info";

        /// <summary>
        /// The warn state. Useful for showing warnings.
        /// </summary>
        public static readonly string Warn = "warn";
    }
}
