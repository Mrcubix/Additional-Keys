using System.Collections.Generic;

namespace AdditionalKeys.Platform.Linux
{
    public class LinuxKeys
    {
        /// <summary>
        /// A Dictionary of F keys and their virtual keycodes on Linux.
        /// </summary>
        internal static readonly Dictionary<string, EventCode> FKeys = new Dictionary<string, EventCode>
        {
            { "None", 0x00 },
            { "F13", EventCode.KEY_F13 },
            { "F14", EventCode.KEY_F14 },
            { "F15", EventCode.KEY_F15 },
            { "F16", EventCode.KEY_F16 },
            { "F17", EventCode.KEY_F17 },
            { "F18", EventCode.KEY_F18 },
            { "F19", EventCode.KEY_F19 },
            { "F20", EventCode.KEY_F20 },
            { "F21", EventCode.KEY_F21 },
            { "F22", EventCode.KEY_F22 },
            { "F23", EventCode.KEY_F23 },
            { "F24", EventCode.KEY_F24 },
        };

        /// <summary>
        /// A Dictionary of media keys and their virtual keycodes on Linux.
        /// </summary>
        internal static readonly Dictionary<string, EventCode> MediaKeys = new Dictionary<string, EventCode>
        {
            { "Volume Mute", EventCode.KEY_MUTE },
            { "Volume Down", EventCode.KEY_VOLUMEDOWN },
            { "Volume Up", EventCode.KEY_VOLUMEUP },
            { "Media Play/Pause", EventCode.KEY_PLAYPAUSE },
            { "Media Play", EventCode.KEY_PLAYPAUSE },
            { "Media Stop", EventCode.KEY_STOPCD },
            { "Media Previous", EventCode.KEY_PREVIOUSSONG },
            { "Media Next", EventCode.KEY_NEXTSONG },
        };

        /// <summary>
        /// A Dictionary containing all supported keys and their virtual keycodes on Linux.
        /// </summary>
        internal static readonly Dictionary<string, EventCode> AllKeys = new Dictionary<string, EventCode>()
        {
            { "None", 0x00 },
            { "F13", EventCode.KEY_F13 },
            { "F14", EventCode.KEY_F14 },
            { "F15", EventCode.KEY_F15 },
            { "F16", EventCode.KEY_F16 },
            { "F17", EventCode.KEY_F17 },
            { "F18", EventCode.KEY_F18 },
            { "F19", EventCode.KEY_F19 },
            { "F20", EventCode.KEY_F20 },
            { "F21", EventCode.KEY_F21 },
            { "F22", EventCode.KEY_F22 },
            { "F23", EventCode.KEY_F23 },
            { "F24", EventCode.KEY_F24 },
            { "Volume Mute", EventCode.KEY_MUTE },
            { "Volume Down", EventCode.KEY_VOLUMEDOWN },
            { "Volume Up", EventCode.KEY_VOLUMEUP },
            { "Media Play/Pause", EventCode.KEY_PLAYPAUSE },
            { "Media Play", EventCode.KEY_PLAYPAUSE },
            { "Media Stop", EventCode.KEY_STOPCD },
            { "Media Previous", EventCode.KEY_PREVIOUSSONG },
            { "Media Next", EventCode.KEY_NEXTSONG },
        };
    }
}