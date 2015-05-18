using MediaFoundation.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaFoundation.Core.Classes
{
#if NOT_IN_USE
    /// <summary>
    /// The following GUIDs define the types for the mutual exclusion object for Advanced Systems Format
    /// (ASF) streams.
    /// <para/>
    /// <para/>
    /// <list type="table">
    /// <listheader><term>Constant</term><description>Description</description></listheader>
    /// <item><term><strong>MFASFMutexType_Language</strong></term><description>
    /// The streams are mutually exclusive by language. This type of mutual exclusion is similar to the audio tracks on a DVD.</description></item>
    /// <item><term><strong>MFASFMutexType_Bitrate</strong></term><description>
    /// The streams are mutually exclusive by bit rate. This type of mutual exclusion is also called multiple bit rate (MBR) exclusion.</description></item>
    /// <item><term><strong>MFASFMutexType_Presentation</strong></term><description>
    /// The streams are mutually exclusive by presentation. This type can be used for many scenarios, but it should only be used when the content is the same but takes a different form. For example, two streams containing the same video, one formatted to fill the screen and the other maintaining the original widescreen aspect ratio, should be made mutually exclusive by using this type. Another example is streams containing video of the same scene shot from different angles.</description></item>
    /// <item><term><strong>MFASFMutexType_Unknown</strong></term><description>
    /// The streams are mutually exclusive based on custom criteria.</description></item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/3DB8EEBD-2E26-4C77-8F66-7D08436C9E42(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3DB8EEBD-2E26-4C77-8F66-7D08436C9E42(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MFASFMutexType_*")]
    public static class MFASFMutexType
    {
        /// <summary>
        /// The streams are mutually exclusive by language. This type of mutual exclusion is similar to the audio tracks on a DVD.
        /// </summary>
        public static readonly Guid Language = new Guid(0x72178C2B, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB);
        /// <summary>
        /// The streams are mutually exclusive by bit rate. This type of mutual exclusion is also called multiple bit rate (MBR) exclusion.
        /// </summary>
        public static readonly Guid Bitrate = new Guid(0x72178C2C, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB);
        /// <summary>
        /// The streams are mutually exclusive by presentation. This type can be used for many scenarios, but it should only be used 
        /// when the content is the same but takes a different form. For example, two streams containing the same video, one formatted 
        /// to fill the screen and the other maintaining the original widescreen aspect ratio, should be made mutually exclusive by using 
        /// this type. Another example is streams containing video of the same scene shot from different angles.
        /// </summary>
        public static readonly Guid Presentation = new Guid(0x72178C2D, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB);
        /// <summary>
        /// The streams are mutually exclusive based on custom criteria.
        /// </summary>
        public static readonly Guid Unknown = new Guid(0x72178C2E, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB);
    }

#endif
}
