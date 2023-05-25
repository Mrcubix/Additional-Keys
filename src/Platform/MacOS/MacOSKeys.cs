namespace AdditionalKeys.Platform.MacOS
{
    public class MacOSKeys
    {
        /// <summary>
        /// A Dictionary of F keys and their virtual keycodes on MacOS.
        /// </summary>
        internal static readonly Dictionary<string, CGKeyCode> FKeys = new Dictionary<string, CGKeyCode>
        {
            { "None", 0x00 },
            { "F13", CGKeyCode.kVK_F13 },
            { "F14", CGKeyCode.kVK_F14 },
            { "F15", CGKeyCode.kVK_F15 },
            { "F16", CGKeyCode.kVK_F16 },
            { "F17", CGKeyCode.kVK_F17 },
            { "F18", CGKeyCode.kVK_F18 },
            { "F19", CGKeyCode.kVK_F19 },
            { "F20", CGKeyCode.kVK_F20 },
        };

        /// <summary>
        /// A Dictionary of media keys and their virtual keycodes on MacOS.
        /// </summary>
        internal static readonly Dictionary<string, CGKeyCode> MediaKeys = new Dictionary<string, CGKeyCode>
        {
            { "Volume Mute", CGKeyCode.kVK_Mute },
            { "Volume Down", CGKeyCode.kVK_VolumeDown },
            { "Volume Up", CGKeyCode.kVK_VolumeUp },
        };

        /// <summary>
        /// A Dictionary containing all supported keys and their virtual keycodes on MacOS.
        /// </summary>
        internal static readonly Dictionary<string, CGKeyCode> AllKeys = new Dictionary<string, CGKeyCode>()
        {
            { "None", 0x00 },
            { "F13", CGKeyCode.kVK_F13 },
            { "F14", CGKeyCode.kVK_F14 },
            { "F15", CGKeyCode.kVK_F15 },
            { "F16", CGKeyCode.kVK_F16 },
            { "F17", CGKeyCode.kVK_F17 },
            { "F18", CGKeyCode.kVK_F18 },
            { "F19", CGKeyCode.kVK_F19 },
            { "F20", CGKeyCode.kVK_F20 },
            { "Volume Mute", CGKeyCode.kVK_Mute },
            { "Volume Down", CGKeyCode.kVK_VolumeDown },
            { "Volume Up", CGKeyCode.kVK_VolumeUp },
        };
    }
}