using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaFoundation
{
    /// <summary>
    /// Represents the entry point to the Microsoft Media Foundation framework.
    /// </summary>
    public class Framework : IDisposable
    {
        /// <summary>
        /// Initializes Microsoft Media Foundation.
        /// </summary>
        /// <returns><see cref="Framework"/> instance that can be disposed to shutdown the framework.</returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B4472E40-3681-4B26-9385-4DF7BF19C2D8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B4472E40-3681-4B26-9385-4DF7BF19C2D8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        /// <seealso cref="MFExtern.MFStartup"/>
        public static Framework Startup()
        {
            return Framework.Startup(MFExtern.MF_VERSION, MFStartup.Full);
        }

                /// <summary>
        /// Initializes Microsoft Media Foundation.
        /// </summary>
        /// <param name="flags">Optional flags.</param>
        /// <returns><see cref="Framework"/> instance that can be disposed to shutdown the framework.</returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B4472E40-3681-4B26-9385-4DF7BF19C2D8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B4472E40-3681-4B26-9385-4DF7BF19C2D8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        /// <seealso cref="MFExtern.MFStartup"/>
        public static Framework Startup(MFStartup flags)
        {
            return Framework.Startup(MFExtern.MF_VERSION, flags);
        }

        /// <summary>
        /// Initializes Microsoft Media Foundation.
        /// </summary>
        /// <param name="version">Version number.</param>
        /// <param name="flags">Optional flags.</param>
        /// <returns><see cref="Framework"/> instance that can be disposed to shutdown the framework.</returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B4472E40-3681-4B26-9385-4DF7BF19C2D8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B4472E40-3681-4B26-9385-4DF7BF19C2D8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        /// <seealso cref="MFExtern.MFStartup"/>
        public static Framework Startup(int version, MFStartup flags)
        {
            int hr = MFExtern.MFStartup(version, flags);
            COM.ThrowIfNotOK(hr);
            return new Framework();
        }

        private Framework()
        {
        }

        private int Disposed = 0;

        /// <summary>
        /// Shuts down the Microsoft Media Foundation platform. Call this function once for every call to 
        /// <see cref="MFStartup"/>. Do not call this function from work queue threads. 
        /// </summary>
        /// <seealso cref="MFExtern.MFShutdown"/>
        public void Dispose()
        {
            int disposed = System.Threading.Interlocked.CompareExchange(ref this.Disposed, 1, 0);
            if (disposed != 0)
                return;
            int hr = MFExtern.MFShutdown();
            COM.ThrowIfNotOK(hr);
        }
    }
}
