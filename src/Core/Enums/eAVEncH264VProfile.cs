using System;

namespace MediaFoundation.Core.Enums
{
    /// <summary>
    /// Specifies an H.264 video profile.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/143765ED-2D9E-4635-854A-0F3287E0E8E7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/143765ED-2D9E-4635-854A-0F3287E0E8E7(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    internal enum eAVEncH264VProfile
    {
        /// <summary>
        /// The profile is unknown or not specified.
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// Simple profile.
        /// </summary>
        Simple = 66,
        /// <summary>
        /// Baseline profile.
        /// </summary>
        Base = 66,
        /// <summary>
        /// Main profile.
        /// </summary>
        Main = 77,
        /// <summary>
        /// High profile.
        /// </summary>
        High = 100,
        /// <summary>
        /// High 4:2:2 profile.
        /// </summary>
        [CLSCompliant(false)]
        _422 = 122,
        /// <summary>
        /// High 10 profile.
        /// </summary>
        High10 = 110,
        /// <summary>
        /// High 4:4:4 profile.
        /// </summary>
        [CLSCompliant(false)]
        _444 = 144,
        /// <summary>
        /// Extended profile.
        /// </summary>
        Extended = 88,
        /// <summary>
        /// Scalable base profile. H.264 extension.
        /// </summary>
        ScalableBase = 83,
        /// <summary>
        /// Scalable high profile. H.264 extension.
        /// </summary>
        ScalableHigh = 86,
        /// <summary>
        /// Multiview high profile. H.264 extension.
        /// </summary>
        MultiviewHigh = 118,
        /// <summary>
        /// Stereo high profile. H.264 extension.
        /// </summary>
        StereoHigh = 128,
        /// <summary>
        /// Constrained base profile. H.264 extension.
        /// </summary>
        ConstrainedBase = 256,
        /// <summary>
        /// Constrained high profile. H.264 extension.
        /// </summary>
        UCConstrainedHigh = 257,
        /// <summary>
        /// UC Constrained base profile. H.264 extension.
        /// </summary>
        UCScalableConstrainedBase = 258,
        /// <summary>
        /// UC Constrained high profile. H.264 extension.
        /// </summary>
        UCScalableConstrainedHigh = 259
    }
}
