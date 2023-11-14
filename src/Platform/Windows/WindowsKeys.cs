namespace AdditionalKeys.Platform.Windows
{
    public class WindowsKeys
    {
        /// <summary>
        /// A Dictionary of F keys and their virtual keycodes on Windows.
        /// </summary>
        internal static readonly Dictionary<string, VirtualKey> FKeys = new Dictionary<string, VirtualKey>
        {
            { "None", 0x00 },
            { "F13", VirtualKey.VK_F13 },
            { "F14", VirtualKey.VK_F14 },
            { "F15", VirtualKey.VK_F15 },
            { "F16", VirtualKey.VK_F16 },
            { "F17", VirtualKey.VK_F17 },
            { "F18", VirtualKey.VK_F18 },
            { "F19", VirtualKey.VK_F19 },
            { "F20", VirtualKey.VK_F20 },
            { "F21", VirtualKey.VK_F21 },
            { "F22", VirtualKey.VK_F22 },
            { "F23", VirtualKey.VK_F23 },
            { "F24", VirtualKey.VK_F24 },
        };

        /// <summary>
        /// A Dictionary of media keys and their virtual keycodes on Windows.
        /// </summary>
        internal static readonly Dictionary<string, VirtualKey> MediaKeys = new Dictionary<string, VirtualKey>
        {
            { "Volume Mute", VirtualKey.VK_VOLUME_MUTE },
            { "Volume Down", VirtualKey.VK_VOLUME_DOWN },
            { "Volume Up", VirtualKey.VK_VOLUME_UP },
            { "Media Play/Pause", VirtualKey.VK_MEDIA_PLAY_PAUSE },
            { "Media Play", VirtualKey.VK_MEDIA_PLAY_PAUSE },
            { "Media Stop", VirtualKey.VK_MEDIA_STOP },
            { "Media Previous", VirtualKey.VK_MEDIA_PREV_TRACK },
            { "Media Next", VirtualKey.VK_MEDIA_NEXT_TRACK },
        };

        /// <summary>
        /// A Dictionary containing all supported keys and their virtual keycodes on Windows.
        /// </summary>
        internal static readonly Dictionary<string, VirtualKey> AllKeys = new Dictionary<string, VirtualKey>()
        {
            { "None", 0x00 },
            { "F13", VirtualKey.VK_F13 },
            { "F14", VirtualKey.VK_F14 },
            { "F15", VirtualKey.VK_F15 },
            { "F16", VirtualKey.VK_F16 },
            { "F17", VirtualKey.VK_F17 },
            { "F18", VirtualKey.VK_F18 },
            { "F19", VirtualKey.VK_F19 },
            { "F20", VirtualKey.VK_F20 },
            { "F21", VirtualKey.VK_F21 },
            { "F22", VirtualKey.VK_F22 },
            { "F23", VirtualKey.VK_F23 },
            { "F24", VirtualKey.VK_F24 },
            { "Volume Mute", VirtualKey.VK_VOLUME_MUTE },
            { "Volume Down", VirtualKey.VK_VOLUME_DOWN },
            { "Volume Up", VirtualKey.VK_VOLUME_UP },
            { "Media Play/Pause", VirtualKey.VK_MEDIA_PLAY_PAUSE },
            { "Media Play", VirtualKey.VK_MEDIA_PLAY_PAUSE },
            { "Media Stop", VirtualKey.VK_MEDIA_STOP },
            { "Media Previous", VirtualKey.VK_MEDIA_PREV_TRACK },
            { "Media Next", VirtualKey.VK_MEDIA_NEXT_TRACK },
        };
    }
}