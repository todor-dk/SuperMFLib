using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using System.Diagnostics;
using MediaFoundation.Core.Interfaces;
using MediaFoundation.Core;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="Activate"/> class implements a wrapper around the
    /// <see cref="IMFActivate"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFActivate"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFActivate"/>:
    /// Enables the application to defer the creation of an object. This interface is exposed by activation
    /// objects.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/C0936E3C-3CD1-4C1E-A336-2DEE7D943963(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C0936E3C-3CD1-4C1E-A336-2DEE7D943963(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class Activate : Attributes<IMFActivate>
    {
        #region Construction

        private Activate(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="Activate"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the Activate's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be concidered void.
        /// </param>
        /// <returns>
        /// A new <see cref="Activate"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static Activate FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            Activate result = new Activate(unknown);
            unknown = IntPtr.Zero;
            return result;
        }

        #endregion

        /// <summary>
        /// Creates an activation object for the <c>Streaming Audio Renderer</c>.
        /// </summary>
        /// <returns>
        /// Returns a new <see cref="Activate"/>. Use this object to create the audio renderer.
        /// The caller must release the instance.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/BCE55C34-D64A-4F3B-8D09-6C9363E4EB11(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BCE55C34-D64A-4F3B-8D09-6C9363E4EB11(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static Activate CreateAudioRendererActivate()
        {
            IntPtr activate = IntPtr.Zero;
            int hr = MFExtern.MFCreateAudioRendererActivate(out activate);
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref activate);
            Debug.Assert(activate != IntPtr.Zero);
            return Activate.FromUnknown(ref activate);
        }

        /// <summary>
        /// Creates an activation object for the enhanced video renderer (EVR) media sink.
        /// </summary>
        /// <param name="hwndVideo">
        /// Handle to the window where the video will be displayed.
        /// </param>
        /// <returns>
        /// Returns a new <see cref="Activate"/>. Use this object to create the EVR.
        /// The caller must release the instance.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/021887FC-36AF-42D4-AE46-2EDC1C700110(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/021887FC-36AF-42D4-AE46-2EDC1C700110(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static Activate CreateVideoRendererActivate(IntPtr hwndVideo)
        {
            IntPtr activate = IntPtr.Zero;
            int hr = MFExtern.MFCreateVideoRendererActivate(hwndVideo, out activate);
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref activate);
            Debug.Assert(activate != IntPtr.Zero);
            return Activate.FromUnknown(ref activate);
        }

        /// <summary>
        /// Creates the object associated with this activation object.
        /// </summary>
        /// <param name="interfaceId">
        /// Interface identifier (IID) of the requested interface.
        /// </param>
        /// <returns>
        /// Object for the requested interface. The caller must release the instance.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/120B8070-6732-450D-8334-B3910F7BB4D2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/120B8070-6732-450D-8334-B3910F7BB4D2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public ComObject ActivateObject(Guid interfaceId)
        {
            IntPtr ppv;
            int hr = this.Interface.ActivateObject(interfaceId, out ppv);
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppv);
            return ComObject.FromUnknown(ref ppv);
        }

        /// <summary>
        /// Creates the object associated with this activation object.
        /// </summary>
        /// <returns>
        /// Object of the requested type. The caller must release the instance.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/120B8070-6732-450D-8334-B3910F7BB4D2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/120B8070-6732-450D-8334-B3910F7BB4D2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public TObject ActivateObject<TObject>()
            where TObject : class
        {
            object value = this.ActivateObject(typeof(TObject).GUID);
            return (TObject)value;
        }

        /// <summary>
        /// Shuts down the created object.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/1F88FF31-5A91-4838-BFCE-673A5A85C766(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1F88FF31-5A91-4838-BFCE-673A5A85C766(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void ShutdownObject()
        {
            int hr = this.Interface.ShutdownObject();
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Detaches the created object from the activation object.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/15216C57-F85D-4087-AD52-D35059647828(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/15216C57-F85D-4087-AD52-D35059647828(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void DetachObject()
        {
            int hr = this.Interface.DetachObject();
            COM.ThrowIfNotOK(hr);
        }
    }
}
