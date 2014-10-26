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
using System.Collections;
using System.Text;
using System.Drawing;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;

using MediaFoundation.Misc;
using MediaFoundation.Transform;

namespace MediaFoundation.Misc
{

    /// <summary>
    /// Utility class that contans Media Foundation error codes constants and 
    /// helper methods for handling and working with HRESULTs and errors codes.
    /// </summary>
    public static class MFError
    {
        #region Errors

        /// <summary>
        /// Error: Platform not initialized. Please call MFStartup().
        /// </summary>
        public const int MF_E_PLATFORM_NOT_INITIALIZED = unchecked((int)0xC00D36B0);
        /// <summary>
        /// Error: The buffer was too small to carry out the requested action.
        /// </summary>
        public const int MF_E_BUFFERTOOSMALL = unchecked((int)0xC00D36B1);
        /// <summary>
        /// Error: The request is invalid in the current state.
        /// </summary>
        public const int MF_E_INVALIDREQUEST = unchecked((int)0xC00D36B2);
        /// <summary>
        /// Error: The stream number provided was invalid.
        /// </summary>
        public const int MF_E_INVALIDSTREAMNUMBER = unchecked((int)0xC00D36B3);
        /// <summary>
        /// Error: The data specified for the media type is invalid, inconsistent, or not supported by this object.
        /// </summary>
        public const int MF_E_INVALIDMEDIATYPE = unchecked((int)0xC00D36B4);
        /// <summary>
        /// Error: The callee is currently not accepting further input.
        /// </summary>
        public const int MF_E_NOTACCEPTING = unchecked((int)0xC00D36B5);
        /// <summary>
        /// Error: This object needs to be initialized before the requested operation can be carried out.
        /// </summary>
        public const int MF_E_NOT_INITIALIZED = unchecked((int)0xC00D36B6);
        /// <summary>
        /// Error: The requested representation is not supported by this object.
        /// </summary>
        public const int MF_E_UNSUPPORTED_REPRESENTATION = unchecked((int)0xC00D36B7);
        /// <summary>
        /// Error: An object ran out of media types to suggest therefore the requested chain of streaming objects cannot be completed.
        /// </summary>
        public const int MF_E_NO_MORE_TYPES = unchecked((int)0xC00D36B9);
        /// <summary>
        /// Error: The object does not support the specified service.
        /// </summary>
        public const int MF_E_UNSUPPORTED_SERVICE = unchecked((int)0xC00D36BA);
        /// <summary>
        /// Error: An unexpected error has occurred in the operation requested.
        /// </summary>
        public const int MF_E_UNEXPECTED = unchecked((int)0xC00D36BB);
        /// <summary>
        /// Error: Invalid name.
        /// </summary>
        public const int MF_E_INVALIDNAME = unchecked((int)0xC00D36BC);
        /// <summary>
        /// Error: Invalid type.
        /// </summary>
        public const int MF_E_INVALIDTYPE = unchecked((int)0xC00D36BD);
        /// <summary>
        /// Error: The file does not conform to the relevant file format specification.
        /// </summary>
        public const int MF_E_INVALID_FILE_FORMAT = unchecked((int)0xC00D36BE);
        /// <summary>
        /// Error: Invalid index.
        /// </summary>
        public const int MF_E_INVALIDINDEX = unchecked((int)0xC00D36BF);
        /// <summary>
        /// Error: An invalid timestamp was given.
        /// </summary>
        public const int MF_E_INVALID_TIMESTAMP = unchecked((int)0xC00D36C0);
        /// <summary>
        /// Error: The scheme of the given URL is unsupported.
        /// </summary>
        public const int MF_E_UNSUPPORTED_SCHEME = unchecked((int)0xC00D36C3);
        /// <summary>
        /// Error: The byte stream type of the given URL is unsupported.
        /// </summary>
        public const int MF_E_UNSUPPORTED_BYTESTREAM_TYPE = unchecked((int)0xC00D36C4);
        /// <summary>
        /// Error: The given time format is unsupported.
        /// </summary>
        public const int MF_E_UNSUPPORTED_TIME_FORMAT = unchecked((int)0xC00D36C5);
        /// <summary>
        /// Error: The Media Sample does not have a timestamp.
        /// </summary>
        public const int MF_E_NO_SAMPLE_TIMESTAMP = unchecked((int)0xC00D36C8);
        /// <summary>
        /// Error: The Media Sample does not have a duration.
        /// </summary>
        public const int MF_E_NO_SAMPLE_DURATION = unchecked((int)0xC00D36C9);
        /// <summary>
        /// Error: The request failed because the data in the stream is corrupt.
        /// </summary>
        public const int MF_E_INVALID_STREAM_DATA = unchecked((int)0xC00D36CB);
        /// <summary>
        /// Error: Real time services are not available.
        /// </summary>
        public const int MF_E_RT_UNAVAILABLE = unchecked((int)0xC00D36CF);
        /// <summary>
        /// Error: The specified rate is not supported.
        /// </summary>
        public const int MF_E_UNSUPPORTED_RATE = unchecked((int)0xC00D36D0);
        /// <summary>
        /// Error: This component does not support stream-thinning.
        /// </summary>
        public const int MF_E_THINNING_UNSUPPORTED = unchecked((int)0xC00D36D1);
        /// <summary>
        /// Error: The call failed because no reverse playback rates are available.
        /// </summary>
        public const int MF_E_REVERSE_UNSUPPORTED = unchecked((int)0xC00D36D2);
        /// <summary>
        /// Error: The requested rate transition cannot occur in the current state.
        /// </summary>
        public const int MF_E_UNSUPPORTED_RATE_TRANSITION = unchecked((int)0xC00D36D3);
        /// <summary>
        /// Error: The requested rate change has been pre-empted and will not occur.
        /// </summary>
        public const int MF_E_RATE_CHANGE_PREEMPTED = unchecked((int)0xC00D36D4);
        /// <summary>
        /// Error: The specified object or value does not exist.
        /// </summary>
        public const int MF_E_NOT_FOUND = unchecked((int)0xC00D36D5);
        /// <summary>
        /// Error: The requested value is not available.
        /// </summary>
        public const int MF_E_NOT_AVAILABLE = unchecked((int)0xC00D36D6);
        /// <summary>
        /// Error: The specified operation requires a clock and no clock is available.
        /// </summary>
        public const int MF_E_NO_CLOCK = unchecked((int)0xC00D36D7);
        /// <summary>
        /// Error: This callback and state had already been passed in to this event generator earlier.
        /// </summary>
        public const int MF_S_MULTIPLE_BEGIN = unchecked((int)0x000D36D8);
        /// <summary>
        /// Error: This callback has already been passed in to this event generator.
        /// </summary>
        public const int MF_E_MULTIPLE_BEGIN = unchecked((int)0xC00D36D9);
        /// <summary>
        /// Error: Some component is already listening to events on this event generator.
        /// </summary>
        public const int MF_E_MULTIPLE_SUBSCRIBERS = unchecked((int)0xC00D36DA);
        /// <summary>
        /// Error: This timer was orphaned before its callback time arrived.
        /// </summary>
        public const int MF_E_TIMER_ORPHANED = unchecked((int)0xC00D36DB);
        /// <summary>
        /// Error: A state transition is already pending.
        /// </summary>
        public const int MF_E_STATE_TRANSITION_PENDING = unchecked((int)0xC00D36DC);
        /// <summary>
        /// Error: The requested state transition is unsupported.
        /// </summary>
        public const int MF_E_UNSUPPORTED_STATE_TRANSITION = unchecked((int)0xC00D36DD);
        /// <summary>
        /// Error: An unrecoverable error has occurred.
        /// </summary>
        public const int MF_E_UNRECOVERABLE_ERROR_OCCURRED = unchecked((int)0xC00D36DE);
        /// <summary>
        /// Error: The provided sample has too many buffers.
        /// </summary>
        public const int MF_E_SAMPLE_HAS_TOO_MANY_BUFFERS = unchecked((int)0xC00D36DF);
        /// <summary>
        /// Error: The provided sample is not writable.
        /// </summary>
        public const int MF_E_SAMPLE_NOT_WRITABLE = unchecked((int)0xC00D36E0);
        /// <summary>
        /// Error: The specified key is not valid.
        /// </summary>
        public const int MF_E_INVALID_KEY = unchecked((int)0xC00D36E2);
        /// <summary>
        /// Error: You are calling MFStartup with the wrong MF_VERSION. Mismatched bits?
        /// </summary>
        public const int MF_E_BAD_STARTUP_VERSION = unchecked((int)0xC00D36E3);
        /// <summary>
        /// Error: The caption of the given URL is unsupported.
        /// </summary>
        public const int MF_E_UNSUPPORTED_CAPTION = unchecked((int)0xC00D36E4);
        /// <summary>
        /// Error: The operation on the current offset is not permitted.
        /// </summary>
        public const int MF_E_INVALID_POSITION = unchecked((int)0xC00D36E5);
        /// <summary>
        /// Error: The requested attribute was not found.
        /// </summary>
        public const int MF_E_ATTRIBUTENOTFOUND = unchecked((int)0xC00D36E6);
        /// <summary>
        /// Error: The specified property type is not allowed in this context.
        /// </summary>
        public const int MF_E_PROPERTY_TYPE_NOT_ALLOWED = unchecked((int)0xC00D36E7);
        /// <summary>
        /// Error: The specified property type is not supported.
        /// </summary>
        public const int MF_E_PROPERTY_TYPE_NOT_SUPPORTED = unchecked((int)0xC00D36E8);
        /// <summary>
        /// Error: The specified property is empty.
        /// </summary>
        public const int MF_E_PROPERTY_EMPTY = unchecked((int)0xC00D36E9);
        /// <summary>
        /// Error: The specified property is not empty.
        /// </summary>
        public const int MF_E_PROPERTY_NOT_EMPTY = unchecked((int)0xC00D36EA);
        /// <summary>
        /// Error: The vector property specified is not allowed in this context.
        /// </summary>
        public const int MF_E_PROPERTY_VECTOR_NOT_ALLOWED = unchecked((int)0xC00D36EB);
        /// <summary>
        /// Error: A vector property is required in this context.
        /// </summary>
        public const int MF_E_PROPERTY_VECTOR_REQUIRED = unchecked((int)0xC00D36EC);
        /// <summary>
        /// Error: The operation is cancelled.
        /// </summary>
        public const int MF_E_OPERATION_CANCELLED = unchecked((int)0xC00D36ED);
        /// <summary>
        /// Error: The provided bytestream was expected to be seekable and it is not.
        /// </summary>
        public const int MF_E_BYTESTREAM_NOT_SEEKABLE = unchecked((int)0xC00D36EE);
        /// <summary>
        /// Error: The Media Foundation platform is disabled when the system is running in Safe Mode.
        /// </summary>
        public const int MF_E_DISABLED_IN_SAFEMODE = unchecked((int)0xC00D36EF);
        /// <summary>
        /// Error: The Media Source could not parse the byte stream.
        /// </summary>
        public const int MF_E_CANNOT_PARSE_BYTESTREAM = unchecked((int)0xC00D36F0);
        /// <summary>
        /// Error: Mutually exclusive flags have been specified to source resolver. This flag combination is invalid.
        /// </summary>
        public const int MF_E_SOURCERESOLVER_MUTUALLY_EXCLUSIVE_FLAGS = unchecked((int)0xC00D36F1);
        /// <summary>
        /// Error: MediaProc is in the wrong state.
        /// </summary>
        public const int MF_E_MEDIAPROC_WRONGSTATE = unchecked((int)0xC00D36F2);
        /// <summary>
        /// Error: Real time I/O service can not provide requested throughput.
        /// </summary>
        public const int MF_E_RT_THROUGHPUT_NOT_AVAILABLE = unchecked((int)0xC00D36F3);
        /// <summary>
        /// Error: The workqueue cannot be registered with more classes.
        /// </summary>
        public const int MF_E_RT_TOO_MANY_CLASSES = unchecked((int)0xC00D36F4);
        /// <summary>
        /// Error: This operation cannot succeed because another thread owns this object.
        /// </summary>
        public const int MF_E_RT_WOULDBLOCK = unchecked((int)0xC00D36F5);
        /// <summary>
        /// Error: Internal. Bitpump not found.
        /// </summary>
        public const int MF_E_NO_BITPUMP = unchecked((int)0xC00D36F6);
        /// <summary>
        /// Error: No more RT memory available.
        /// </summary>
        public const int MF_E_RT_OUTOFMEMORY = unchecked((int)0xC00D36F7);
        /// <summary>
        /// Error: An MMCSS class has not been set for this work queue.
        /// </summary>
        public const int MF_E_RT_WORKQUEUE_CLASS_NOT_SPECIFIED = unchecked((int)0xC00D36F8);
        /// <summary>
        /// Error: Insufficient memory for response.
        /// </summary>
        public const int MF_E_INSUFFICIENT_BUFFER = unchecked((int)0xC00D7170);
        /// <summary>
        /// Error: Activate failed to create mediasink. Call OutputNode::GetUINT32(MF_TOPONODE_MAJORTYPE) for more information.
        /// </summary>
        public const int MF_E_CANNOT_CREATE_SINK = unchecked((int)0xC00D36FA);
        /// <summary>
        /// Error: The length of the provided bytestream is unknown.
        /// </summary>
        public const int MF_E_BYTESTREAM_UNKNOWN_LENGTH = unchecked((int)0xC00D36FB);
        /// <summary>
        /// Error: The media session cannot pause from a stopped state.
        /// </summary>
        public const int MF_E_SESSION_PAUSEWHILESTOPPED = unchecked((int)0xC00D36FC);
        /// <summary>
        /// Error: The activate could not be created in the remote process for some reason it was replaced with empty one.
        /// </summary>
        public const int MF_S_ACTIVATE_REPLACED = unchecked((int)0x000D36FD);
        /// <summary>
        /// Error: The data specified for the media type is supported, but would require a format change, which is not supported by this object.
        /// </summary>
        public const int MF_E_FORMAT_CHANGE_NOT_SUPPORTED = unchecked((int)0xC00D36FE);
        /// <summary>
        /// Error: The operation failed because an invalid combination of workqueue ID and flags was specified.
        /// </summary>
        public const int MF_E_INVALID_WORKQUEUE = unchecked((int)0xC00D36FF);
        /// <summary>
        /// Error: No DRM support is available.
        /// </summary>
        public const int MF_E_DRM_UNSUPPORTED = unchecked((int)0xC00D3700);
        /// <summary>
        /// Error: This operation is not authorized.
        /// </summary>
        public const int MF_E_UNAUTHORIZED = unchecked((int)0xC00D3701);
        /// <summary>
        /// Error: The value is not in the specified or valid range.
        /// </summary>
        public const int MF_E_OUT_OF_RANGE = unchecked((int)0xC00D3702);
        /// <summary>
        /// Error: The registered codec merit is not valid.
        /// </summary>
        public const int MF_E_INVALID_CODEC_MERIT = unchecked((int)0xC00D3703);
        /// <summary>
        /// Error: Hardware MFT failed to start streaming due to lack of hardware resources.
        /// </summary>
        public const int MF_E_HW_MFT_FAILED_START_STREAMING = unchecked((int)0xC00D3704);
        /// <summary>
        /// Error: Parsing is still in progress and is not yet complete.
        /// </summary>
        public const int MF_S_ASF_PARSEINPROGRESS = unchecked((int)0x400D3A98);
        /// <summary>
        /// Error: Not enough data have been parsed to carry out the requested action.
        /// </summary>
        public const int MF_E_ASF_PARSINGINCOMPLETE = unchecked((int)0xC00D3A98);
        /// <summary>
        /// Error: There is a gap in the ASF data provided.
        /// </summary>
        public const int MF_E_ASF_MISSINGDATA = unchecked((int)0xC00D3A99);
        /// <summary>
        /// Error: The data provided are not valid ASF.
        /// </summary>
        public const int MF_E_ASF_INVALIDDATA = unchecked((int)0xC00D3A9A);
        /// <summary>
        /// Error: The packet is opaque, so the requested information cannot be returned.
        /// </summary>
        public const int MF_E_ASF_OPAQUEPACKET = unchecked((int)0xC00D3A9B);
        /// <summary>
        /// Error: The requested operation failed since there is no appropriate ASF index.
        /// </summary>
        public const int MF_E_ASF_NOINDEX = unchecked((int)0xC00D3A9C);
        /// <summary>
        /// Error: The value supplied is out of range for this operation.
        /// </summary>
        public const int MF_E_ASF_OUTOFRANGE = unchecked((int)0xC00D3A9D);
        /// <summary>
        /// Error: The index entry requested needs to be loaded before it can be available.
        /// </summary>
        public const int MF_E_ASF_INDEXNOTLOADED = unchecked((int)0xC00D3A9E);
        /// <summary>
        /// Error: The packet has reached the maximum number of payloads.
        /// </summary>
        public const int MF_E_ASF_TOO_MANY_PAYLOADS = unchecked((int)0xC00D3A9F);
        /// <summary>
        /// Error: Stream type is not supported.
        /// </summary>
        public const int MF_E_ASF_UNSUPPORTED_STREAM_TYPE = unchecked((int)0xC00D3AA0);
        /// <summary>
        /// Error: One or more ASF packets were dropped.
        /// </summary>
        public const int MF_E_ASF_DROPPED_PACKET = unchecked((int)0xC00D3AA1);
        /// <summary>
        /// Error: There are no events available in the queue.
        /// </summary>
        public const int MF_E_NO_EVENTS_AVAILABLE = unchecked((int)0xC00D3E80);
        /// <summary>
        /// Error: A media source cannot go from the stopped state to the paused state.
        /// </summary>
        public const int MF_E_INVALID_STATE_TRANSITION = unchecked((int)0xC00D3E82);
        /// <summary>
        /// Error: The media stream cannot process any more samples because there are no more samples in the stream.
        /// </summary>
        public const int MF_E_END_OF_STREAM = unchecked((int)0xC00D3E84);
        /// <summary>
        /// Error: The request is invalid because Shutdown() has been called.
        /// </summary>
        public const int MF_E_SHUTDOWN = unchecked((int)0xC00D3E85);
        /// <summary>
        /// Error: The MP3 object was not found.
        /// </summary>
        public const int MF_E_MP3_NOTFOUND = unchecked((int)0xC00D3E86);
        /// <summary>
        /// Error: The MP3 parser ran out of data before finding the MP3 object.
        /// </summary>
        public const int MF_E_MP3_OUTOFDATA = unchecked((int)0xC00D3E87);
        /// <summary>
        /// Error: The file is not really a MP3 file.
        /// </summary>
        public const int MF_E_MP3_NOTMP3 = unchecked((int)0xC00D3E88);
        /// <summary>
        /// Error: The MP3 file is not supported.
        /// </summary>
        public const int MF_E_MP3_NOTSUPPORTED = unchecked((int)0xC00D3E89);
        /// <summary>
        /// Error: The Media stream has no duration.
        /// </summary>
        public const int MF_E_NO_DURATION = unchecked((int)0xC00D3E8A);
        /// <summary>
        /// Error: The Media format is recognized but is invalid.
        /// </summary>
        public const int MF_E_INVALID_FORMAT = unchecked((int)0xC00D3E8C);
        /// <summary>
        /// Error: The property requested was not found.
        /// </summary>
        public const int MF_E_PROPERTY_NOT_FOUND = unchecked((int)0xC00D3E8D);
        /// <summary>
        /// Error: The property is read only.
        /// </summary>
        public const int MF_E_PROPERTY_READ_ONLY = unchecked((int)0xC00D3E8E);
        /// <summary>
        /// Error: The specified property is not allowed in this context.
        /// </summary>
        public const int MF_E_PROPERTY_NOT_ALLOWED = unchecked((int)0xC00D3E8F);
        /// <summary>
        /// Error: The media source is not started.
        /// </summary>
        public const int MF_E_MEDIA_SOURCE_NOT_STARTED = unchecked((int)0xC00D3E91);
        /// <summary>
        /// Error: The Media format is recognized but not supported.
        /// </summary>
        public const int MF_E_UNSUPPORTED_FORMAT = unchecked((int)0xC00D3E98);
        /// <summary>
        /// Error: The MPEG frame has bad CRC.
        /// </summary>
        public const int MF_E_MP3_BAD_CRC = unchecked((int)0xC00D3E99);
        /// <summary>
        /// Error: The file is not protected.
        /// </summary>
        public const int MF_E_NOT_PROTECTED = unchecked((int)0xC00D3E9A);
        /// <summary>
        /// Error: The media source is in the wrong state.
        /// </summary>
        public const int MF_E_MEDIA_SOURCE_WRONGSTATE = unchecked((int)0xC00D3E9B);
        /// <summary>
        /// Error: No streams are selected in source presentation descriptor.
        /// </summary>
        public const int MF_E_MEDIA_SOURCE_NO_STREAMS_SELECTED = unchecked((int)0xC00D3E9C);
        /// <summary>
        /// Error: No key frame sample was found.
        /// </summary>
        public const int MF_E_CANNOT_FIND_KEYFRAME_SAMPLE = unchecked((int)0xC00D3E9D);

        /// <summary>
        /// Error: The characteristics of the media source are not supported.
        /// </summary>
        public const int MF_E_UNSUPPORTED_CHARACTERISTICS = unchecked((int)0xC00D3E9E);
        /// <summary>
        /// Error: No audio recording device was found.
        /// </summary>
        public const int MF_E_NO_AUDIO_RECORDING_DEVICE   = unchecked((int)0xC00D3E9F);
        /// <summary>
        /// Error: The requested audio recording device is currently in use.
        /// </summary>
        public const int MF_E_AUDIO_RECORDING_DEVICE_IN_USE = unchecked((int)0xC00D3EA0);
        /// <summary>
        /// Error: The audio recording device is no longer present.
        /// </summary>
        public const int MF_E_AUDIO_RECORDING_DEVICE_INVALIDATED = unchecked((int)0xC00D3EA1);
        /// <summary>
        /// Error: The video recording device is no longer present.
        /// </summary>
        public const int MF_E_VIDEO_RECORDING_DEVICE_INVALIDATED = unchecked((int)0xC00D3EA2);
        /// <summary>
        /// Error: The video recording device is preempted by another immersive application.
        /// </summary>
        public const int MF_E_VIDEO_RECORDING_DEVICE_PREEMPTED = unchecked((int)0xC00D3EA3);

        /// <summary>
        /// Error: An attempt to acquire a network resource failed.
        /// </summary>
        public const int MF_E_NETWORK_RESOURCE_FAILURE = unchecked((int)0xC00D4268);
        /// <summary>
        /// Error: Error writing to the network.
        /// </summary>
        public const int MF_E_NET_WRITE = unchecked((int)0xC00D4269);
        /// <summary>
        /// Error: Error reading from the network.
        /// </summary>
        public const int MF_E_NET_READ = unchecked((int)0xC00D426A);
        /// <summary>
        /// Error: Internal. Entry cannot complete operation without network.
        /// </summary>
        public const int MF_E_NET_REQUIRE_NETWORK = unchecked((int)0xC00D426B);
        /// <summary>
        /// Error: Internal. Async op is required.
        /// </summary>
        public const int MF_E_NET_REQUIRE_ASYNC = unchecked((int)0xC00D426C);
        /// <summary>
        /// Error: Internal. Bandwidth levels are not supported.
        /// </summary>
        public const int MF_E_NET_BWLEVEL_NOT_SUPPORTED = unchecked((int)0xC00D426D);
        /// <summary>
        /// Error: Internal. Stream groups are not supported.
        /// </summary>
        public const int MF_E_NET_STREAMGROUPS_NOT_SUPPORTED = unchecked((int)0xC00D426E);
        /// <summary>
        /// Error: Manual stream selection is not supported.
        /// </summary>
        public const int MF_E_NET_MANUALSS_NOT_SUPPORTED = unchecked((int)0xC00D426F);
        /// <summary>
        /// Error: Invalid presentation descriptor.
        /// </summary>
        public const int MF_E_NET_INVALID_PRESENTATION_DESCRIPTOR = unchecked((int)0xC00D4270);
        /// <summary>
        /// Error: Cannot find cache stream.
        /// </summary>
        public const int MF_E_NET_CACHESTREAM_NOT_FOUND = unchecked((int)0xC00D4271);
        /// <summary>
        /// Error: The proxy setting is manual.
        /// </summary>
        public const int MF_I_MANUAL_PROXY = unchecked((int)0x400D4272);
        /// <summary>
        /// Error: Internal. Entry cannot complete operation without input.
        /// </summary>
        public const int MF_E_NET_REQUIRE_INPUT = unchecked((int)0xC00D4274);
        /// <summary>
        /// Error: The client redirected to another server.
        /// </summary>
        public const int MF_E_NET_REDIRECT = unchecked((int)0xC00D4275);
        /// <summary>
        /// Error: The client is redirected to a proxy server.
        /// </summary>
        public const int MF_E_NET_REDIRECT_TO_PROXY = unchecked((int)0xC00D4276);
        /// <summary>
        /// Error: The client reached maximum redirection limit.
        /// </summary>
        public const int MF_E_NET_TOO_MANY_REDIRECTS = unchecked((int)0xC00D4277);
        /// <summary>
        /// Error: The server, a computer set up to offer multimedia content to other computers, could not handle your request for multimedia content in a timely manner.  Please try again later.
        /// </summary>
        public const int MF_E_NET_TIMEOUT = unchecked((int)0xC00D4278);
        /// <summary>
        /// Error: The control socket is closed by the client.
        /// </summary>
        public const int MF_E_NET_CLIENT_CLOSE = unchecked((int)0xC00D4279);
        /// <summary>
        /// Error: The server received invalid data from the client on the control connection.
        /// </summary>
        public const int MF_E_NET_BAD_CONTROL_DATA = unchecked((int)0xC00D427A);
        /// <summary>
        /// Error: The server is not a compatible streaming media server.
        /// </summary>
        public const int MF_E_NET_INCOMPATIBLE_SERVER = unchecked((int)0xC00D427B);
        /// <summary>
        /// Error: Url.
        /// </summary>
        public const int MF_E_NET_UNSAFE_URL = unchecked((int)0xC00D427C);
        /// <summary>
        /// Error: Data is not available.
        /// </summary>
        public const int MF_E_NET_CACHE_NO_DATA = unchecked((int)0xC00D427D);
        /// <summary>
        /// Error: End of line.
        /// </summary>
        public const int MF_E_NET_EOL = unchecked((int)0xC00D427E);
        /// <summary>
        /// Error: The request could not be understood by the server.
        /// </summary>
        public const int MF_E_NET_BAD_REQUEST = unchecked((int)0xC00D427F);
        /// <summary>
        /// Error: The server encountered an unexpected condition which prevented it from fulfilling the request.
        /// </summary>
        public const int MF_E_NET_INTERNAL_SERVER_ERROR = unchecked((int)0xC00D4280);
        /// <summary>
        /// Error: Session not found.
        /// </summary>
        public const int MF_E_NET_SESSION_NOT_FOUND = unchecked((int)0xC00D4281);
        /// <summary>
        /// Error: There is no connection established with the Windows Media server. The operation failed.
        /// </summary>
        public const int MF_E_NET_NOCONNECTION = unchecked((int)0xC00D4282);
        /// <summary>
        /// Error: The network connection has failed.
        /// </summary>
        public const int MF_E_NET_CONNECTION_FAILURE = unchecked((int)0xC00D4283);
        /// <summary>
        /// Error: The Server service that received the HTTP push request is not a compatible version of Windows Media Services (WMS).  This error may indicate the push request was received by IIS instead of WMS.  Ensure WMS is started and has the HTTP Server control protocol properly enabled and try again.
        /// </summary>
        public const int MF_E_NET_INCOMPATIBLE_PUSHSERVER = unchecked((int)0xC00D4284);
        /// <summary>
        /// Error: The Windows Media server is denying access.  The username and/or password might be incorrect.
        /// </summary>
        public const int MF_E_NET_SERVER_ACCESSDENIED = unchecked((int)0xC00D4285);
        /// <summary>
        /// Error: The proxy server is denying access.  The username and/or password might be incorrect.
        /// </summary>
        public const int MF_E_NET_PROXY_ACCESSDENIED = unchecked((int)0xC00D4286);
        /// <summary>
        /// Error: Unable to establish a connection to the server.
        /// </summary>
        public const int MF_E_NET_CANNOTCONNECT = unchecked((int)0xC00D4287);
        /// <summary>
        /// Error: The specified push template is invalid.
        /// </summary>
        public const int MF_E_NET_INVALID_PUSH_TEMPLATE = unchecked((int)0xC00D4288);
        /// <summary>
        /// Error: The specified push publishing point is invalid.
        /// </summary>
        public const int MF_E_NET_INVALID_PUSH_PUBLISHING_POINT = unchecked((int)0xC00D4289);
        /// <summary>
        /// Error: The requested resource is in use.
        /// </summary>
        public const int MF_E_NET_BUSY = unchecked((int)0xC00D428A);
        /// <summary>
        /// Error: The Publishing Point or file on the Windows Media Server is no longer available.
        /// </summary>
        public const int MF_E_NET_RESOURCE_GONE = unchecked((int)0xC00D428B);
        /// <summary>
        /// Error: The proxy experienced an error while attempting to contact the media server.
        /// </summary>
        public const int MF_E_NET_ERROR_FROM_PROXY = unchecked((int)0xC00D428C);
        /// <summary>
        /// Error: The proxy did not receive a timely response while attempting to contact the media server.
        /// </summary>
        public const int MF_E_NET_PROXY_TIMEOUT = unchecked((int)0xC00D428D);
        /// <summary>
        /// Error: The server is currently unable to handle the request due to a temporary overloading or maintenance of the server.
        /// </summary>
        public const int MF_E_NET_SERVER_UNAVAILABLE = unchecked((int)0xC00D428E);
        /// <summary>
        /// Error: The encoding process was unable to keep up with the amount of supplied data.
        /// </summary>
        public const int MF_E_NET_TOO_MUCH_DATA = unchecked((int)0xC00D428F);
        /// <summary>
        /// Error: Session not found.
        /// </summary>
        public const int MF_E_NET_SESSION_INVALID = unchecked((int)0xC00D4290);
        /// <summary>
        /// Error: The requested URL is not available in offline mode.
        /// </summary>
        public const int MF_E_OFFLINE_MODE = unchecked((int)0xC00D4291);
        /// <summary>
        /// Error: A device in the network is blocking UDP traffic.
        /// </summary>
        public const int MF_E_NET_UDP_BLOCKED = unchecked((int)0xC00D4292);
        /// <summary>
        /// Error: The specified configuration value is not supported.
        /// </summary>
        public const int MF_E_NET_UNSUPPORTED_CONFIGURATION = unchecked((int)0xC00D4293);
        /// <summary>
        /// Error: The networking protocol is disabled.
        /// </summary>
        public const int MF_E_NET_PROTOCOL_DISABLED = unchecked((int)0xC00D4294);
        /// <summary>
        /// Error: This object has already been initialized and cannot be re-initialized at this time.
        /// </summary>
        public const int MF_E_ALREADY_INITIALIZED = unchecked((int)0xC00D4650);
        /// <summary>
        /// Error: The amount of data passed in exceeds the given bitrate and buffer window.
        /// </summary>
        public const int MF_E_BANDWIDTH_OVERRUN = unchecked((int)0xC00D4651);
        /// <summary>
        /// Error: The sample was passed in too late to be correctly processed.
        /// </summary>
        public const int MF_E_LATE_SAMPLE = unchecked((int)0xC00D4652);
        /// <summary>
        /// Error: The requested action cannot be carried out until the object is flushed and the queue is emptied.
        /// </summary>
        public const int MF_E_FLUSH_NEEDED = unchecked((int)0xC00D4653);
        /// <summary>
        /// Error: The profile is invalid.
        /// </summary>
        public const int MF_E_INVALID_PROFILE = unchecked((int)0xC00D4654);
        /// <summary>
        /// Error: The index that is being generated needs to be committed before the requested action can be carried out.
        /// </summary>
        public const int MF_E_INDEX_NOT_COMMITTED = unchecked((int)0xC00D4655);
        /// <summary>
        /// Error: The index that is necessary for the requested action is not found.
        /// </summary>
        public const int MF_E_NO_INDEX = unchecked((int)0xC00D4656);
        /// <summary>
        /// Error: The requested index cannot be added in-place to the specified ASF content.
        /// </summary>
        public const int MF_E_CANNOT_INDEX_IN_PLACE = unchecked((int)0xC00D4657);
        /// <summary>
        /// Error: The ASF leaky bucket parameters must be specified in order to carry out this request.
        /// </summary>
        public const int MF_E_MISSING_ASF_LEAKYBUCKET = unchecked((int)0xC00D4658);
        /// <summary>
        /// Error: The stream id is invalid. The valid range for ASF stream id is from 1 to 127.
        /// </summary>
        public const int MF_E_INVALID_ASF_STREAMID = unchecked((int)0xC00D4659);
        /// <summary>
        /// Error: The requested Stream Sink has been removed and cannot be used.
        /// </summary>
        public const int MF_E_STREAMSINK_REMOVED = unchecked((int)0xC00D4A38);
        /// <summary>
        /// Error: The various Stream Sinks in this Media Sink are too far out of sync for the requested action to take place.
        /// </summary>
        public const int MF_E_STREAMSINKS_OUT_OF_SYNC = unchecked((int)0xC00D4A3A);
        /// <summary>
        /// Error: Stream Sinks cannot be added to or removed from this Media Sink because its set of streams is fixed.
        /// </summary>
        public const int MF_E_STREAMSINKS_FIXED = unchecked((int)0xC00D4A3B);
        /// <summary>
        /// Error: The given Stream Sink already exists.
        /// </summary>
        public const int MF_E_STREAMSINK_EXISTS = unchecked((int)0xC00D4A3C);
        /// <summary>
        /// Error: Sample allocations have been canceled.
        /// </summary>
        public const int MF_E_SAMPLEALLOCATOR_CANCELED = unchecked((int)0xC00D4A3D);
        /// <summary>
        /// Error: The sample allocator is currently empty, due to outstanding requests.
        /// </summary>
        public const int MF_E_SAMPLEALLOCATOR_EMPTY = unchecked((int)0xC00D4A3E);
        /// <summary>
        /// Error: When we try to stop a stream sink, it is already stopped.
        /// </summary>
        public const int MF_E_SINK_ALREADYSTOPPED = unchecked((int)0xC00D4A3F);
        /// <summary>
        /// Error: The ASF file sink could not reserve AVIO because the bitrate is unknown.
        /// </summary>
        public const int MF_E_ASF_FILESINK_BITRATE_UNKNOWN = unchecked((int)0xC00D4A40);
        /// <summary>
        /// Error: No streams are selected in sink presentation descriptor.
        /// </summary>
        public const int MF_E_SINK_NO_STREAMS = unchecked((int)0xC00D4A41);
        /// <summary>
        /// Error: The sink has not been finalized before shut down. This may cause sink to generate corrupted content.
        /// </summary>
        public const int MF_S_SINK_NOT_FINALIZED = unchecked((int)0x000D4A42);
        /// <summary>
        /// Error: A metadata item was too long to write to the output container.
        /// </summary>
        public const int MF_E_METADATA_TOO_LONG = unchecked((int)0xC00D4A43);
        /// <summary>
        /// Error: The operation failed because no samples were processed by the sink.
        /// </summary>
        public const int MF_E_SINK_NO_SAMPLES_PROCESSED = unchecked((int)0xC00D4A44);
        /// <summary>
        /// Error: There is no available procamp hardware with which to perform color correction.
        /// </summary>
        public const int MF_E_VIDEO_REN_NO_PROCAMP_HW = unchecked((int)0xC00D4E20);
        /// <summary>
        /// Error: There is no available deinterlacing hardware with which to deinterlace the video stream.
        /// </summary>
        public const int MF_E_VIDEO_REN_NO_DEINTERLACE_HW = unchecked((int)0xC00D4E21);
        /// <summary>
        /// Error: A video stream requires copy protection to be enabled, but there was a failure in attempting to enable copy protection.
        /// </summary>
        public const int MF_E_VIDEO_REN_COPYPROT_FAILED = unchecked((int)0xC00D4E22);
        /// <summary>
        /// Error: A component is attempting to access a surface for sharing that is not shared.
        /// </summary>
        public const int MF_E_VIDEO_REN_SURFACE_NOT_SHARED = unchecked((int)0xC00D4E23);
        /// <summary>
        /// Error: A component is attempting to access a shared device that is already locked by another component.
        /// </summary>
        public const int MF_E_VIDEO_DEVICE_LOCKED = unchecked((int)0xC00D4E24);
        /// <summary>
        /// Error: The device is no longer available. The handle should be closed and a new one opened.
        /// </summary>
        public const int MF_E_NEW_VIDEO_DEVICE = unchecked((int)0xC00D4E25);
        /// <summary>
        /// Error: A video sample is not currently queued on a stream that is required for mixing.
        /// </summary>
        public const int MF_E_NO_VIDEO_SAMPLE_AVAILABLE = unchecked((int)0xC00D4E26);
        /// <summary>
        /// Error: No audio playback device was found.
        /// </summary>
        public const int MF_E_NO_AUDIO_PLAYBACK_DEVICE = unchecked((int)0xC00D4E84);
        /// <summary>
        /// Error: The requested audio playback device is currently in use.
        /// </summary>
        public const int MF_E_AUDIO_PLAYBACK_DEVICE_IN_USE = unchecked((int)0xC00D4E85);
        /// <summary>
        /// Error: The audio playback device is no longer present.
        /// </summary>
        public const int MF_E_AUDIO_PLAYBACK_DEVICE_INVALIDATED = unchecked((int)0xC00D4E86);
        /// <summary>
        /// Error: The audio service is not running.
        /// </summary>
        public const int MF_E_AUDIO_SERVICE_NOT_RUNNING = unchecked((int)0xC00D4E87);
        /// <summary>
        /// Error: The topology contains an invalid optional node.  Possible reasons are incorrect number of outputs and inputs or optional node is at the beginning or end of a segment.
        /// </summary>
        public const int MF_E_TOPO_INVALID_OPTIONAL_NODE = unchecked((int)0xC00D520E);
        /// <summary>
        /// Error: No suitable transform was found to decrypt the content.
        /// </summary>
        public const int MF_E_TOPO_CANNOT_FIND_DECRYPTOR = unchecked((int)0xC00D5211);
        /// <summary>
        /// Error: No suitable transform was found to encode or decode the content.
        /// </summary>
        public const int MF_E_TOPO_CODEC_NOT_FOUND = unchecked((int)0xC00D5212);
        /// <summary>
        /// Error: Unable to find a way to connect nodes.
        /// </summary>
        public const int MF_E_TOPO_CANNOT_CONNECT = unchecked((int)0xC00D5213);
        /// <summary>
        /// Error: Unsupported operations in topoloader.
        /// </summary>
        public const int MF_E_TOPO_UNSUPPORTED = unchecked((int)0xC00D5214);
        /// <summary>
        /// Error: The topology or its nodes contain incorrectly set time attributes.
        /// </summary>
        public const int MF_E_TOPO_INVALID_TIME_ATTRIBUTES = unchecked((int)0xC00D5215);
        /// <summary>
        /// Error: The topology contains loops, which are unsupported in media foundation topologies.
        /// </summary>
        public const int MF_E_TOPO_LOOPS_IN_TOPOLOGY = unchecked((int)0xC00D5216);
        /// <summary>
        /// Error: A source stream node in the topology does not have a presentation descriptor.
        /// </summary>
        public const int MF_E_TOPO_MISSING_PRESENTATION_DESCRIPTOR = unchecked((int)0xC00D5217);
        /// <summary>
        /// Error: A source stream node in the topology does not have a stream descriptor.
        /// </summary>
        public const int MF_E_TOPO_MISSING_STREAM_DESCRIPTOR = unchecked((int)0xC00D5218);
        /// <summary>
        /// Error: A stream descriptor was set on a source stream node but it was not selected on the presentation descriptor.
        /// </summary>
        public const int MF_E_TOPO_STREAM_DESCRIPTOR_NOT_SELECTED = unchecked((int)0xC00D5219);
        /// <summary>
        /// Error: A source stream node in the topology does not have a source.
        /// </summary>
        public const int MF_E_TOPO_MISSING_SOURCE = unchecked((int)0xC00D521A);
        /// <summary>
        /// Error: The topology loader does not support sink activates on output nodes.
        /// </summary>
        public const int MF_E_TOPO_SINK_ACTIVATES_UNSUPPORTED = unchecked((int)0xC00D521B);
        /// <summary>
        /// Error: The sequencer cannot find a segment with the given ID.
        /// </summary>
        public const int MF_E_SEQUENCER_UNKNOWN_SEGMENT_ID = unchecked((int)0xC00D61AC);
        /// <summary>
        /// Error: The context was canceled.
        /// </summary>
        public const int MF_S_SEQUENCER_CONTEXT_CANCELED = unchecked((int)0x000D61AD);
        /// <summary>
        /// Error: Cannot find source in source cache.
        /// </summary>
        public const int MF_E_NO_SOURCE_IN_CACHE = unchecked((int)0xC00D61AE);
        /// <summary>
        /// Error: Cannot update topology flags.
        /// </summary>
        public const int MF_S_SEQUENCER_SEGMENT_AT_END_OF_STREAM = unchecked((int)0x000D61AF);
        /// <summary>
        /// Error: A valid type has not been set for this stream or a stream that it depends on.
        /// </summary>
        public const int MF_E_TRANSFORM_TYPE_NOT_SET = unchecked((int)0xC00D6D60);
        /// <summary>
        /// Error: A stream change has occurred. Output cannot be produced until the streams have been renegotiated.
        /// </summary>
        public const int MF_E_TRANSFORM_STREAM_CHANGE = unchecked((int)0xC00D6D61);
        /// <summary>
        /// Error: The transform cannot take the requested action until all of the input data it currently holds is processed or flushed.
        /// </summary>
        public const int MF_E_TRANSFORM_INPUT_REMAINING = unchecked((int)0xC00D6D62);
        /// <summary>
        /// Error: The transform requires a profile but no profile was supplied or found.
        /// </summary>
        public const int MF_E_TRANSFORM_PROFILE_MISSING = unchecked((int)0xC00D6D63);
        /// <summary>
        /// Error: The transform requires a profile but the supplied profile was invalid or corrupt.
        /// </summary>
        public const int MF_E_TRANSFORM_PROFILE_INVALID_OR_CORRUPT = unchecked((int)0xC00D6D64);
        /// <summary>
        /// Error: The transform requires a profile but the supplied profile ended unexpectedly while parsing.
        /// </summary>
        public const int MF_E_TRANSFORM_PROFILE_TRUNCATED = unchecked((int)0xC00D6D65);
        /// <summary>
        /// Error: The property ID does not match any property supported by the transform.
        /// </summary>
        public const int MF_E_TRANSFORM_PROPERTY_PID_NOT_RECOGNIZED = unchecked((int)0xC00D6D66);
        /// <summary>
        /// Error: The variant does not have the type expected for this property ID.
        /// </summary>
        public const int MF_E_TRANSFORM_PROPERTY_VARIANT_TYPE_WRONG = unchecked((int)0xC00D6D67);
        /// <summary>
        /// Error: An attempt was made to set the value on a read-only property.
        /// </summary>
        public const int MF_E_TRANSFORM_PROPERTY_NOT_WRITEABLE = unchecked((int)0xC00D6D68);
        /// <summary>
        /// Error: The array property value has an unexpected number of dimensions.
        /// </summary>
        public const int MF_E_TRANSFORM_PROPERTY_ARRAY_VALUE_WRONG_NUM_DIM = unchecked((int)0xC00D6D69);
        /// <summary>
        /// Error: The array or blob property value has an unexpected size.
        /// </summary>
        public const int MF_E_TRANSFORM_PROPERTY_VALUE_SIZE_WRONG = unchecked((int)0xC00D6D6A);
        /// <summary>
        /// Error: The property value is out of range for this transform.
        /// </summary>
        public const int MF_E_TRANSFORM_PROPERTY_VALUE_OUT_OF_RANGE = unchecked((int)0xC00D6D6B);
        /// <summary>
        /// Error: The property value is incompatible with some other property or mediatype set on the transform.
        /// </summary>
        public const int MF_E_TRANSFORM_PROPERTY_VALUE_INCOMPATIBLE = unchecked((int)0xC00D6D6C);
        /// <summary>
        /// Error: The requested operation is not supported for the currently set output mediatype.
        /// </summary>
        public const int MF_E_TRANSFORM_NOT_POSSIBLE_FOR_CURRENT_OUTPUT_MEDIATYPE = unchecked((int)0xC00D6D6D);
        /// <summary>
        /// Error: The requested operation is not supported for the currently set input mediatype.
        /// </summary>
        public const int MF_E_TRANSFORM_NOT_POSSIBLE_FOR_CURRENT_INPUT_MEDIATYPE = unchecked((int)0xC00D6D6E);
        /// <summary>
        /// Error: The requested operation is not supported for the currently set combination of mediatypes.
        /// </summary>
        public const int MF_E_TRANSFORM_NOT_POSSIBLE_FOR_CURRENT_MEDIATYPE_COMBINATION = unchecked((int)0xC00D6D6F);
        /// <summary>
        /// Error: The requested feature is not supported in combination with some other currently enabled feature.
        /// </summary>
        public const int MF_E_TRANSFORM_CONFLICTS_WITH_OTHER_CURRENTLY_ENABLED_FEATURES = unchecked((int)0xC00D6D70);
        /// <summary>
        /// Error: The transform cannot produce output until it gets more input samples.
        /// </summary>
        public const int MF_E_TRANSFORM_NEED_MORE_INPUT = unchecked((int)0xC00D6D72);
        /// <summary>
        /// Error: The requested operation is not supported for the current speaker configuration.
        /// </summary>
        public const int MF_E_TRANSFORM_NOT_POSSIBLE_FOR_CURRENT_SPKR_CONFIG = unchecked((int)0xC00D6D73);
        /// <summary>
        /// Error: The transform cannot accept mediatype changes in the middle of processing.
        /// </summary>
        public const int MF_E_TRANSFORM_CANNOT_CHANGE_MEDIATYPE_WHILE_PROCESSING = unchecked((int)0xC00D6D74);
        /// <summary>
        /// Error: The caller should not propagate this event to downstream components.
        /// </summary>
        public const int MF_S_TRANSFORM_DO_NOT_PROPAGATE_EVENT = unchecked((int)0x000D6D75);
        /// <summary>
        /// Error: The input type is not supported for D3D device.
        /// </summary>
        public const int MF_E_UNSUPPORTED_D3D_TYPE = unchecked((int)0xC00D6D76);
        /// <summary>
        /// Error: The caller does not appear to support this transform's asynchronous capabilities.
        /// </summary>
        public const int MF_E_TRANSFORM_ASYNC_LOCKED = unchecked((int)0xC00D6D77);
        /// <summary>
        /// Error: An audio compression manager driver could not be initialized by the transform.
        /// </summary>
        public const int MF_E_TRANSFORM_CANNOT_INITIALIZE_ACM_DRIVER = unchecked((int)0xC00D6D78L);
        /// <summary>
        /// Error: You are not allowed to open this file. Contact the content provider for further assistance.
        /// </summary>
        public const int MF_E_LICENSE_INCORRECT_RIGHTS = unchecked((int)0xC00D7148);
        /// <summary>
        /// Error: The license for this media file has expired. Get a new license or contact the content provider for further assistance.
        /// </summary>
        public const int MF_E_LICENSE_OUTOFDATE = unchecked((int)0xC00D7149);
        /// <summary>
        /// Error: You need a license to perform the requested operation on this media file.
        /// </summary>
        public const int MF_E_LICENSE_REQUIRED = unchecked((int)0xC00D714A);
        /// <summary>
        /// Error: The licenses for your media files are corrupted. Contact Microsoft product support.
        /// </summary>
        public const int MF_E_DRM_HARDWARE_INCONSISTENT = unchecked((int)0xC00D714B);
        /// <summary>
        /// Error: The APP needs to provide IMFContentProtectionManager callback to access the protected media file.
        /// </summary>
        public const int MF_E_NO_CONTENT_PROTECTION_MANAGER = unchecked((int)0xC00D714C);
        /// <summary>
        /// Error: Client does not have rights to restore licenses.
        /// </summary>
        public const int MF_E_LICENSE_RESTORE_NO_RIGHTS = unchecked((int)0xC00D714D);
        /// <summary>
        /// Error: Licenses are restricted and hence can not be backed up.
        /// </summary>
        public const int MF_E_BACKUP_RESTRICTED_LICENSE = unchecked((int)0xC00D714E);
        /// <summary>
        /// Error: License restore requires machine to be individualized.
        /// </summary>
        public const int MF_E_LICENSE_RESTORE_NEEDS_INDIVIDUALIZATION = unchecked((int)0xC00D714F);
        /// <summary>
        /// Error: Protection for stream is not required.
        /// </summary>
        public const int MF_S_PROTECTION_NOT_REQUIRED = unchecked((int)0x000D7150);
        /// <summary>
        /// Error: Component is revoked.
        /// </summary>
        public const int MF_E_COMPONENT_REVOKED = unchecked((int)0xC00D7151);
        /// <summary>
        /// Error: Trusted functionality is currently disabled on this component.
        /// </summary>
        public const int MF_E_TRUST_DISABLED = unchecked((int)0xC00D7152);
        /// <summary>
        /// Error: No Action is set on WMDRM Output Trust Authority.
        /// </summary>
        public const int MF_E_WMDRMOTA_NO_ACTION = unchecked((int)0xC00D7153);
        /// <summary>
        /// Error: Action is already set on WMDRM Output Trust Authority.
        /// </summary>
        public const int MF_E_WMDRMOTA_ACTION_ALREADY_SET = unchecked((int)0xC00D7154);
        /// <summary>
        /// Error: DRM Heaader is not available.
        /// </summary>
        public const int MF_E_WMDRMOTA_DRM_HEADER_NOT_AVAILABLE = unchecked((int)0xC00D7155);
        /// <summary>
        /// Error: Current encryption scheme is not supported.
        /// </summary>
        public const int MF_E_WMDRMOTA_DRM_ENCRYPTION_SCHEME_NOT_SUPPORTED = unchecked((int)0xC00D7156);
        /// <summary>
        /// Error: Action does not match with current configuration.
        /// </summary>
        public const int MF_E_WMDRMOTA_ACTION_MISMATCH = unchecked((int)0xC00D7157);
        /// <summary>
        /// Error: Invalid policy for WMDRM Output Trust Authority.
        /// </summary>
        public const int MF_E_WMDRMOTA_INVALID_POLICY = unchecked((int)0xC00D7158);
        /// <summary>
        /// Error: The policies that the Input Trust Authority requires to be enforced are unsupported by the outputs.
        /// </summary>
        public const int MF_E_POLICY_UNSUPPORTED = unchecked((int)0xC00D7159);
        /// <summary>
        /// Error: The OPL that the license requires to be enforced are not supported by the Input Trust Authority.
        /// </summary>
        public const int MF_E_OPL_NOT_SUPPORTED = unchecked((int)0xC00D715A);
        /// <summary>
        /// Error: The topology could not be successfully verified.
        /// </summary>
        public const int MF_E_TOPOLOGY_VERIFICATION_FAILED = unchecked((int)0xC00D715B);
        /// <summary>
        /// Error: Signature verification could not be completed successfully for this component.
        /// </summary>
        public const int MF_E_SIGNATURE_VERIFICATION_FAILED = unchecked((int)0xC00D715C);
        /// <summary>
        /// Error: Running this process under a debugger while using protected content is not allowed.
        /// </summary>
        public const int MF_E_DEBUGGING_NOT_ALLOWED = unchecked((int)0xC00D715D);
        /// <summary>
        /// Error: MF component has expired.
        /// </summary>
        public const int MF_E_CODE_EXPIRED = unchecked((int)0xC00D715E);
        /// <summary>
        /// Error: The current GRL on the machine does not meet the minimum version requirements.
        /// </summary>
        public const int MF_E_GRL_VERSION_TOO_LOW = unchecked((int)0xC00D715F);
        /// <summary>
        /// Error: The current GRL on the machine does not contain any renewal entries for the specified revocation.
        /// </summary>
        public const int MF_E_GRL_RENEWAL_NOT_FOUND = unchecked((int)0xC00D7160);
        /// <summary>
        /// Error: The current GRL on the machine does not contain any extensible entries for the specified extension GUID.
        /// </summary>
        public const int MF_E_GRL_EXTENSIBLE_ENTRY_NOT_FOUND = unchecked((int)0xC00D7161);
        /// <summary>
        /// Error: The kernel isn't secure for high security level content.
        /// </summary>
        public const int MF_E_KERNEL_UNTRUSTED = unchecked((int)0xC00D7162);
        /// <summary>
        /// Error: The response from protected environment driver isn't valid.
        /// </summary>
        public const int MF_E_PEAUTH_UNTRUSTED = unchecked((int)0xC00D7163);
        /// <summary>
        /// Error: A non-PE process tried to talk to PEAuth.
        /// </summary>
        public const int MF_E_NON_PE_PROCESS = unchecked((int)0xC00D7165);
        /// <summary>
        /// Error: We need to reboot the machine.
        /// </summary>
        public const int MF_E_REBOOT_REQUIRED = unchecked((int)0xC00D7167);
        /// <summary>
        /// Error: Protection for this stream is not guaranteed to be enforced until the MEPolicySet event is fired.
        /// </summary>
        public const int MF_S_WAIT_FOR_POLICY_SET = unchecked((int)0x000D7168);
        /// <summary>
        /// Error: This video stream is disabled because it is being sent to an unknown software output.
        /// </summary>
        public const int MF_S_VIDEO_DISABLED_WITH_UNKNOWN_SOFTWARE_OUTPUT = unchecked((int)0x000D7169);
        /// <summary>
        /// Error: The GRL file is not correctly formed, it may have been corrupted or overwritten.
        /// </summary>
        public const int MF_E_GRL_INVALID_FORMAT = unchecked((int)0xC00D716A);
        /// <summary>
        /// Error: The GRL file is in a format newer than those recognized by this GRL Reader.
        /// </summary>
        public const int MF_E_GRL_UNRECOGNIZED_FORMAT = unchecked((int)0xC00D716B);
        /// <summary>
        /// Error: The GRL was reloaded and required all processes that can run protected media to restart.
        /// </summary>
        public const int MF_E_ALL_PROCESS_RESTART_REQUIRED = unchecked((int)0xC00D716C);
        /// <summary>
        /// Error: The GRL was reloaded and the current process needs to restart.
        /// </summary>
        public const int MF_E_PROCESS_RESTART_REQUIRED = unchecked((int)0xC00D716D);
        /// <summary>
        /// Error: The user space is untrusted for protected content play.
        /// </summary>
        public const int MF_E_USERMODE_UNTRUSTED = unchecked((int)0xC00D716E);
        /// <summary>
        /// Error: PEAuth communication session hasn't been started.
        /// </summary>
        public const int MF_E_PEAUTH_SESSION_NOT_STARTED = unchecked((int)0xC00D716F);
        /// <summary>
        /// Error: PEAuth's public key is revoked.
        /// </summary>
        public const int MF_E_PEAUTH_PUBLICKEY_REVOKED = unchecked((int)0xC00D7171);
        /// <summary>
        /// Error: The GRL is absent.
        /// </summary>
        public const int MF_E_GRL_ABSENT = unchecked((int)0xC00D7172);
        /// <summary>
        /// Error: The Protected Environment is trusted.
        /// </summary>
        public const int MF_S_PE_TRUSTED = unchecked((int)0x000D7173);
        /// <summary>
        /// Error: The Protected Environment is untrusted.
        /// </summary>
        public const int MF_E_PE_UNTRUSTED = unchecked((int)0xC00D7174);
        /// <summary>
        /// Error: The Protected Environment Authorization service (PEAUTH) has not been started.
        /// </summary>
        public const int MF_E_PEAUTH_NOT_STARTED = unchecked((int)0xC00D7175);
        /// <summary>
        /// Error: The sample protection algorithms supported by components are not compatible.
        /// </summary>
        public const int MF_E_INCOMPATIBLE_SAMPLE_PROTECTION = unchecked((int)0xC00D7176);
        /// <summary>
        /// Error: No more protected environment sessions can be supported.
        /// </summary>
        public const int MF_E_PE_SESSIONS_MAXED = unchecked((int)0xC00D7177);
        /// <summary>
        /// Error: WMDRM ITA does not allow protected content with high security level for this release.
        /// </summary>
        public const int MF_E_HIGH_SECURITY_LEVEL_CONTENT_NOT_ALLOWED = unchecked((int)0xC00D7178);
        /// <summary>
        /// Error: WMDRM ITA cannot allow the requested action for the content as one or more components is not properly signed.
        /// </summary>
        public const int MF_E_TEST_SIGNED_COMPONENTS_NOT_ALLOWED = unchecked((int)0xC00D7179);
        /// <summary>
        /// Error: WMDRM ITA does not support the requested action.
        /// </summary>
        public const int MF_E_ITA_UNSUPPORTED_ACTION = unchecked((int)0xC00D717A);
        /// <summary>
        /// Error: WMDRM ITA encountered an error in parsing the Secure Audio Path parameters.
        /// </summary>
        public const int MF_E_ITA_ERROR_PARSING_SAP_PARAMETERS = unchecked((int)0xC00D717B);
        /// <summary>
        /// Error: The Policy Manager action passed in is invalid.
        /// </summary>
        public const int MF_E_POLICY_MGR_ACTION_OUTOFBOUNDS = unchecked((int)0xC00D717C);
        /// <summary>
        /// Error: The structure specifying Output Protection Level is not the correct format.
        /// </summary>
        public const int MF_E_BAD_OPL_STRUCTURE_FORMAT = unchecked((int)0xC00D717D);
        /// <summary>
        /// Error: WMDRM ITA does not recognize the Explicite Analog Video Output Protection guid specified in the license.
        /// </summary>
        public const int MF_E_ITA_UNRECOGNIZED_ANALOG_VIDEO_PROTECTION_GUID = unchecked((int)0xC00D717E);
        /// <summary>
        /// Error: IMFPMPHost object not available.
        /// </summary>
        public const int MF_E_NO_PMP_HOST = unchecked((int)0xC00D717F);
        /// <summary>
        /// Error: WMDRM ITA could not initialize the Output Protection Level data.
        /// </summary>
        public const int MF_E_ITA_OPL_DATA_NOT_INITIALIZED = unchecked((int)0xC00D7180);
        /// <summary>
        /// Error: WMDRM ITA does not recognize the Analog Video Output specified by the OTA.
        /// </summary>
        public const int MF_E_ITA_UNRECOGNIZED_ANALOG_VIDEO_OUTPUT = unchecked((int)0xC00D7181);
        /// <summary>
        /// Error: WMDRM ITA does not recognize the Digital Video Output specified by the OTA.
        /// </summary>
        public const int MF_E_ITA_UNRECOGNIZED_DIGITAL_VIDEO_OUTPUT = unchecked((int)0xC00D7182);

        /// <summary>
        /// Error: The protected stream cannot be resolved without the callback PKEY_PMP_Creation_Callback in the configuration property store.
        /// </summary>
        public const int MF_E_RESOLUTION_REQUIRES_PMP_CREATION_CALLBACK = unchecked((int)0xC00D7183);
        /// <summary>
        /// Error: A valid hostname and port number could not be found in the DTCP parameters.
        /// </summary>
        public const int MF_E_INVALID_AKE_CHANNEL_PARAMETERS = unchecked((int)0xC00D7184);
        /// <summary>
        /// Error: The content protection system was not enabled by the application.
        /// </summary>
        public const int MF_E_CONTENT_PROTECTION_SYSTEM_NOT_ENABLED = unchecked((int)0xC00D7185);
        /// <summary>
        /// Error: The content protection system is not supported.
        /// </summary>
        public const int MF_E_UNSUPPORTED_CONTENT_PROTECTION_SYSTEM = unchecked((int)0xC00D7186);
        /// <summary>
        /// Error: DRM migration is not supported for the content.
        /// </summary>
        public const int MF_E_DRM_MIGRATION_NOT_SUPPORTED = unchecked((int)0xC00D7187);

        /// <summary>
        /// Error: The continuity key supplied is not currently valid.
        /// </summary>
        public const int MF_E_CLOCK_INVALID_CONTINUITY_KEY = unchecked((int)0xC00D9C40);
        /// <summary>
        /// Error: No Presentation Time Source has been specified.
        /// </summary>
        public const int MF_E_CLOCK_NO_TIME_SOURCE = unchecked((int)0xC00D9C41);
        /// <summary>
        /// Error: The clock is already in the requested state.
        /// </summary>
        public const int MF_E_CLOCK_STATE_ALREADY_SET = unchecked((int)0xC00D9C42);
        /// <summary>
        /// Error: The clock has too many advanced features to carry out the request.
        /// </summary>
        public const int MF_E_CLOCK_NOT_SIMPLE = unchecked((int)0xC00D9C43);
        /// <summary>
        /// Error: Timer::SetTimer returns this success code if called happened while timer is stopped. Timer is not going to be dispatched until clock is running.
        /// </summary>
        public const int MF_S_CLOCK_STOPPED = unchecked((int)0x000D9C44);
        /// <summary>
        /// Error: The component does not support any more drop modes.
        /// </summary>
        public const int MF_E_NO_MORE_DROP_MODES = unchecked((int)0xC00DA028);
        /// <summary>
        /// Error: The component does not support any more quality levels.
        /// </summary>
        public const int MF_E_NO_MORE_QUALITY_LEVELS = unchecked((int)0xC00DA029);
        /// <summary>
        /// Error: The component does not support drop time functionality.
        /// </summary>
        public const int MF_E_DROPTIME_NOT_SUPPORTED = unchecked((int)0xC00DA02A);
        /// <summary>
        /// Error: Quality Manager needs to wait longer before bumping the Quality Level up.
        /// </summary>
        public const int MF_E_QUALITYKNOB_WAIT_LONGER = unchecked((int)0xC00DA02B);
        /// <summary>
        /// Error: Quality Manager is in an invalid state. Quality Management is off at this moment.
        /// </summary>
        public const int MF_E_QM_INVALIDSTATE = unchecked((int)0xC00DA02C);
        /// <summary>
        /// Error: No transcode output container type is specified.
        /// </summary>
        public const int MF_E_TRANSCODE_NO_CONTAINERTYPE = unchecked((int)0xC00DA410);
        /// <summary>
        /// Error: The profile does not have a media type configuration for any selected source streams.
        /// </summary>
        public const int MF_E_TRANSCODE_PROFILE_NO_MATCHING_STREAMS = unchecked((int)0xC00DA411);
        /// <summary>
        /// Error: Cannot find an encoder MFT that accepts the user preferred output type.
        /// </summary>
        public const int MF_E_TRANSCODE_NO_MATCHING_ENCODER = unchecked((int)0xC00DA412);

        /// <summary>
        /// Error: The profile is invalid.
        /// </summary>
        public const int MF_E_TRANSCODE_INVALID_PROFILE = unchecked((int)0xC00DA413);

        /// <summary>
        /// Error: Memory allocator is not initialized.
        /// </summary>
        public const int MF_E_ALLOCATOR_NOT_INITIALIZED = unchecked((int)0xC00DA7F8);
        /// <summary>
        /// Error: Memory allocator is not committed yet.
        /// </summary>
        public const int MF_E_ALLOCATOR_NOT_COMMITED = unchecked((int)0xC00DA7F9);
        /// <summary>
        /// Error: Memory allocator has already been committed.
        /// </summary>
        public const int MF_E_ALLOCATOR_ALREADY_COMMITED = unchecked((int)0xC00DA7FA);
        /// <summary>
        /// Error: An error occurred in media stream.
        /// </summary>
        public const int MF_E_STREAM_ERROR = unchecked((int)0xC00DA7FB);
        /// <summary>
        /// Error: Stream is not in a state to handle the request.
        /// </summary>
        public const int MF_E_INVALID_STREAM_STATE = unchecked((int)0xC00DA7FC);
        /// <summary>
        /// Error: Hardware stream is not connected yet.
        /// </summary>
        public const int MF_E_HW_STREAM_NOT_CONNECTED = unchecked((int)0xC00DA7FD);

        /// <summary>
        /// Error: No capture devices are available.
        /// </summary>
        public const int MF_E_NO_CAPTURE_DEVICES_AVAILABLE = unchecked((int)0xC00DABE0);
        /// <summary>
        /// Error: No output was set for recording.
        /// </summary>
        public const int MF_E_CAPTURE_SINK_OUTPUT_NOT_SET = unchecked((int)0xC00DABE1);
        /// <summary>
        /// Error: The current capture sink configuration does not support mirroring.
        /// </summary>
        public const int MF_E_CAPTURE_SINK_MIRROR_ERROR = unchecked((int)0xC00DABE2);
        /// <summary>
        /// Error: The current capture sink configuration does not support rotation.
        /// </summary>
        public const int MF_E_CAPTURE_SINK_ROTATE_ERROR = unchecked((int)0xC00DABE3);
        /// <summary>
        /// Error: The op is invalid.
        /// </summary>
        public const int MF_E_CAPTURE_ENGINE_INVALID_OP = unchecked((int)0xC00DABE4);

        /// <summary>
        /// Error: The Direct3D device manager was not initialized. The owner of the device must 
        /// call IDirect3DDeviceManager9::ResetDevice. Same as DXVA2_E_NOT_INITIALIZED.
        /// </summary>
        public const int MF_E_DXGI_DEVICE_NOT_INITIALIZED = unchecked((int)0x80041000);
        /// <summary>
        /// Error: The device handle is invalid. 
        /// </summary>
        public const int MF_E_DXGI_NEW_VIDEO_DEVICE = unchecked((int)0x80041001);
        /// <summary>
        /// Error: The device is locked. 
        /// </summary>
        public const int MF_E_DXGI_VIDEO_DEVICE_LOCKED = unchecked((int)0x80041002);

        #endregion

        #region externs

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, EntryPoint = "FormatMessageW", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        private static extern int FormatMessage(FormatMessageFlags dwFlags, IntPtr lpSource,
            int dwMessageId, int dwLanguageId, out IntPtr lpBuffer, int nSize, IntPtr[] Arguments);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, EntryPoint = "LoadLibraryExW", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        private static extern IntPtr LoadLibraryEx(string lpFileName, IntPtr hFile, LoadLibraryExFlags dwFlags);

        [DllImport("kernel32.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeLibrary(IntPtr hFile);

        [DllImport("kernel32.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        private static extern IntPtr LocalFree(IntPtr hMem);

        #endregion

        #region Declarations

        [Flags, UnmanagedName("#defines in WinBase.h")]
        private enum LoadLibraryExFlags
        {
            DontResolveDllReferences = 0x00000001,
            LoadLibraryAsDataFile = 0x00000002,
            LoadWithAlteredSearchPath = 0x00000008,
            LoadIgnoreCodeAuthzLevel = 0x00000010
        }

        [Flags, UnmanagedName("FORMAT_MESSAGE_* defines")]
        private enum FormatMessageFlags
        {
            AllocateBuffer = 0x00000100,
            IgnoreInserts = 0x00000200,
            FromString = 0x00000400,
            FromHmodule = 0x00000800,
            FromSystem = 0x00001000,
            ArgumentArray = 0x00002000,
            MaxWidthMask = 0x000000FF
        }

        #endregion

        private static IntPtr s_hModule = IntPtr.Zero;
        private const string MESSAGEFILE = "mferror.dll";

        /// <summary>
        /// Returns a string describing a MF error.  Works for both error codes
        /// (values &lt; 0) and Status codes (values &gt;= 0)
        /// </summary>
        /// <param name="hr">HRESULT for which to get description</param>
        /// <returns>The string, or null if no error text can be found</returns>
        public static string GetErrorText(int hr)
        {
            string sRet = null;
            int dwBufferLength;
            IntPtr ip = IntPtr.Zero;

            FormatMessageFlags dwFormatFlags =
                FormatMessageFlags.AllocateBuffer |
                FormatMessageFlags.IgnoreInserts |
                FormatMessageFlags.FromSystem |
                FormatMessageFlags.MaxWidthMask;

            // Scan both the Windows Media library, and the system library looking for the message
            dwBufferLength = FormatMessage(
                dwFormatFlags,
                s_hModule, // module to get message from (NULL == system)
                hr, // error number to get message for
                0, // default language
                out ip,
                0,
                null
                );

            // Not a system message.  In theory, you should be able to get both with one call.  In practice (at
            // least on my 64bit box), you need to make 2 calls.
            if (dwBufferLength == 0)
            {
                if (s_hModule == IntPtr.Zero)
                {
                    // Load the Media Foundation error message dll
                    s_hModule = LoadLibraryEx(MESSAGEFILE, IntPtr.Zero, LoadLibraryExFlags.LoadLibraryAsDataFile);
                }

                if (s_hModule != IntPtr.Zero)
                {
                    // If the load succeeds, make sure we look in it
                    dwFormatFlags |= FormatMessageFlags.FromHmodule;

                    // Scan both the Windows Media library, and the system library looking for the message
                    dwBufferLength = FormatMessage(
                        dwFormatFlags,
                        s_hModule, // module to get message from (NULL == system)
                        hr, // error number to get message for
                        0, // default language
                        out ip,
                        0,
                        null
                        );
                }
            }

            try
            {
                // Convert the returned buffer to a string.  If ip is null (due to not finding
                // the message), no exception is thrown.  sRet just stays null.  The
                // try/finally is for the (remote) possibility that we run out of memory
                // creating the string.
                sRet = Marshal.PtrToStringUni(ip);
            }
            finally
            {
                // Cleanup
                if (ip != IntPtr.Zero)
                {
                    LocalFree(ip);
                }
            }

            return sRet;
        }

        /// <summary>
        /// If hr has a "failed" status code (E_*), throw an exception.  Note that status
        /// messages (S_*) are not considered failure codes.  If MediaFoundation error text
        /// is available, it is used to build the exception, otherwise a generic com error
        /// is thrown.
        /// </summary>
        /// <param name="hr">The HRESULT to check</param>
        public static void ThrowExceptionForHR(int hr)
        {
            // If a severe error has occurred
            if (hr < 0)
            {
                string s = GetErrorText(hr);

                // If a string is returned, build a COM error from it
                if (s != null)
                {
                    throw new COMException(s, hr);
                }
                else
                {
                    // No string, just use standard com error
                    Marshal.ThrowExceptionForHR(hr);
                }
            }
        }
    }

}
