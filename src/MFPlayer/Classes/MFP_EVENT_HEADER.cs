#region license

/*
MediaFoundationLib - Provide access to MediaFoundation interfaces via .NET
Copyright (C) 2007
http://mfnet.sourceforge.net

This library is free software; you can redistribute it and/or
modify it under the terms of the GNU Lesser General Public
License as published by the Free Software Foundation; either
version 2.1 of the License, or (at your option) any later version.

This library is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public
License along with this library; if not, write to the Free Software
Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
*/

#endregion

using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security;

using MediaFoundation.Misc;
using System.Drawing;

using MediaFoundation.EVR;

namespace MediaFoundation.MFPlayer
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
    /// Applications should use the <c>Media Session</c> for playback. 
    /// <para/>
    /// Contains information that is common to  every type of MFPlay event.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct MFP_EVENT_HEADER {
    ///   MFP_EVENT_TYPE        eEventType;
    ///   HRESULT               hrEvent;
    ///   IMFPMediaPlayer       *pMediaPlayer;
    ///   MFP_MEDIAPLAYER_STATE eState;
    ///   IPropertyStore        *pPropertyStore;
    /// } MFP_EVENT_HEADER;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/ED9D3790-845A-4392-B755-6A5CE6E20DE5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/ED9D3790-845A-4392-B755-6A5CE6E20DE5(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Obsolete("This API may be removed from future releases of Windows.")]
    [StructLayout(LayoutKind.Sequential), UnmanagedName("MFP_EVENT_HEADER")]
    public class MFP_EVENT_HEADER
    {
        /// <summary>
        /// The type of event, specified as a member of the <see cref="MFPlayer.MFP_EVENT_TYPE"/> enumeration. 
        /// </summary>
        public MFP_EVENT_TYPE eEventType;
        /// <summary>
        /// Error or success code for the operation that caused the event.
        /// </summary>
        public int hrEvent;
        /// <summary>
        /// Pointer to the <see cref="MFPlayer.IMFPMediaPlayer"/> interface of the MFPlay player object that
        /// sent the event. 
        /// </summary>
        public IMFPMediaPlayer pMediaPlayer;
        /// <summary>
        /// The new state of the MFPlay player object, specified as a member of the 
        /// <see cref="MFPlayer.MFP_MEDIAPLAYER_STATE"/> enumeration. 
        /// </summary>
        public MFP_MEDIAPLAYER_STATE eState;
        /// <summary>
        /// A pointer to the <strong>IPropertyStore</strong> interface of a property store object. The property
        /// store is used to hold additional event data for some event types. This member might be <strong>NULL
        /// </strong>. 
        /// </summary>
        public IPropertyStore pPropertyStore;

        /// <summary>
        /// Gets the PTR.
        /// </summary>
        /// <returns>IntPtr.</returns>
        public IntPtr GetPtr()
        {
            IntPtr ip;

            int iSize = Marshal.SizeOf(this);

            ip = Marshal.AllocCoTaskMem(iSize);
            Marshal.StructureToPtr(this, ip, false);

            return ip;
        }

        /// <summary>
        /// PTRs to eh.
        /// </summary>
        /// <param name="pNativeData">The p native data.</param>
        /// <returns>MFP_EVENT_HEADER.</returns>
        public static MFP_EVENT_HEADER PtrToEH(IntPtr pNativeData)
        {
            MFP_EVENT_TYPE met = (MFP_EVENT_TYPE)Marshal.ReadInt32(pNativeData);
            object mce;

            switch (met)
            {
                case MFP_EVENT_TYPE.Play:
                    mce = Marshal.PtrToStructure(pNativeData, typeof(MFP_PLAY_EVENT));
                    break;
                case MFP_EVENT_TYPE.Pause:
                    mce = Marshal.PtrToStructure(pNativeData, typeof(MFP_PAUSE_EVENT));
                    break;
                case MFP_EVENT_TYPE.Stop:
                    mce = Marshal.PtrToStructure(pNativeData, typeof(MFP_STOP_EVENT));
                    break;
                case MFP_EVENT_TYPE.PositionSet:
                    mce = Marshal.PtrToStructure(pNativeData, typeof(MFP_POSITION_SET_EVENT));
                    break;
                case MFP_EVENT_TYPE.RateSet:
                    mce = Marshal.PtrToStructure(pNativeData, typeof(MFP_RATE_SET_EVENT));
                    break;
                case MFP_EVENT_TYPE.MediaItemCreated:
                    mce = Marshal.PtrToStructure(pNativeData, typeof(MFP_MEDIAITEM_CREATED_EVENT));
                    break;
                case MFP_EVENT_TYPE.MediaItemSet:
                    mce = Marshal.PtrToStructure(pNativeData, typeof(MFP_RATE_SET_EVENT));
                    break;
                case MFP_EVENT_TYPE.FrameStep:
                    mce = Marshal.PtrToStructure(pNativeData, typeof(MFP_FRAME_STEP_EVENT));
                    break;
                case MFP_EVENT_TYPE.MediaItemCleared:
                    mce = Marshal.PtrToStructure(pNativeData, typeof(MFP_MEDIAITEM_CLEARED_EVENT));
                    break;
                case MFP_EVENT_TYPE.MF:
                    mce = Marshal.PtrToStructure(pNativeData, typeof(MFP_MF_EVENT));
                    break;
                case MFP_EVENT_TYPE.Error:
                    mce = Marshal.PtrToStructure(pNativeData, typeof(MFP_ERROR_EVENT));
                    break;
                case MFP_EVENT_TYPE.PlaybackEnded:
                    mce = Marshal.PtrToStructure(pNativeData, typeof(MFP_PLAYBACK_ENDED_EVENT));
                    break;
                case MFP_EVENT_TYPE.AcquireUserCredential:
                    mce = Marshal.PtrToStructure(pNativeData, typeof(MFP_ACQUIRE_USER_CREDENTIAL_EVENT));
                    break;
                default:
                    // Don't know what it is.  Send back the header.
                    mce = Marshal.PtrToStructure(pNativeData, typeof(MFP_EVENT_HEADER));
                    break;
            }

            return mce as MFP_EVENT_HEADER;
        }
    }

#endif

}
