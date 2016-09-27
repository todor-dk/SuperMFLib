using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Misc;
using MediaFoundation.Core.Interfaces;
using MediaFoundation.Core;
using MediaFoundation.Misc.Classes;
using System.Runtime.InteropServices;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="TopoLoader"/> class implements a wrapper around the
    /// <see cref="IMFTopoLoader"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFTopoLoader"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFTopoLoader"/>:
    /// Converts a partial topology into a full topology. The topology loader exposes this interface.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/5EBF117C-E60A-40F2-A24B-C4F9DBDAE942(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5EBF117C-E60A-40F2-A24B-C4F9DBDAE942(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class TopoLoader : COM<IMFTopoLoader>
    {
        #region Construction

        private TopoLoader(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="TopoLoader"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the TopoLoader's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be considered void.
        /// </param>
        /// <returns>
        /// A new <see cref="TopoLoader"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static TopoLoader FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            TopoLoader result = new TopoLoader(unknown);
            unknown = IntPtr.Zero;
            return result;
        }

        #endregion

        /// <summary>
        /// Creates a new instance of the topology loader.
        /// </summary>
        /// <returns>A new topology loader. The caller must release the instance.</returns>
        public static TopoLoader Create()
        {
            IntPtr ppObj;
            int hr = MFExtern.MFCreateTopoLoader(out ppObj);
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppObj);
            return TopoLoader.FromUnknown(ref ppObj);
        }

        /// <summary>
        /// Creates a fully loaded topology from the input partial topology.
        /// </summary>
        /// <param name="inputTopology">
        /// The partial topology to be resolved.
        /// </param>
        /// <param name="currentTopology">
        /// The previous full topology. The topology loader can re-use objects from this topology in the new topology.
        /// This parameter can be <strong>null</strong>.
        /// </param>
        /// <returns>
        /// The completed topology. The caller must release the instance. Null is returned if
        /// one or more output nodes contain <see cref="Activate"/> pointers. The caller must bind the output nodes to media sinks.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/02CE47DB-54A1-456A-A763-C62039AEA2C9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/02CE47DB-54A1-456A-A763-C62039AEA2C9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Topology Load(Topology inputTopology, Topology currentTopology)
        {
            IntPtr ppOutputTopo = IntPtr.Zero;
            int hr = this.Interface.Load(inputTopology.AccessInterface(), out ppOutputTopo, currentTopology.AccessInterface());
            // MF_E_TOPO_SINK_ACTIVATES_UNSUPPORTED: One or more output nodes contain IMFActivate pointers.
            // The caller must bind the output nodes to media sinks. See <c>Binding Output Nodes to Media Sinks</c>.
            if (hr == MFError.MF_E_TOPO_SINK_ACTIVATES_UNSUPPORTED)
            {
                if (ppOutputTopo != IntPtr.Zero)
                    Marshal.Release(ppOutputTopo);
                return null;
            }

            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppOutputTopo);
            return Topology.FromUnknown(ref ppOutputTopo);
        }
    }
}
