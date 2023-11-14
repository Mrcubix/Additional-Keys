using AdditionalKeys.Platform;
using AdditionalKeys.Platform.Linux;
using AdditionalKeys.Platform.MacOS;
using AdditionalKeys.Platform.Windows;
using OpenTabletDriver.Desktop.Interop;
using OpenTabletDriver.Plugin;
using OpenTabletDriver.Plugin.Attributes;
using OpenTabletDriver.Plugin.Platform.Keyboard;
using OpenTabletDriver.Plugin.Tablet;

namespace AdditionalKeys
{
    [PluginName(PLUGIN_NAME)]
    public class AdditionalMediaKeyBindings : IStateBinding
    {
        private const string PLUGIN_NAME = "Additional - Media Keys";

        [Property("Key"), PropertyValidated(nameof(ValidKeys))]
        public string Key { set; get; } = string.Empty;

        public IVirtualKeyboard Keyboard { get; set; } = Shared.Keyboard;

        public void Press(TabletReference tablet, IDeviceReport report)
        {
            if (!string.IsNullOrWhiteSpace(Key))
                Keyboard.Press(Key);
        }

        public void Release(TabletReference tablet, IDeviceReport report)
        {
            if (!string.IsNullOrWhiteSpace(Key))
                Keyboard.Release(Key);
        }

        private static IEnumerable<string> validKeys = null!;
        /// <summary>
        /// A list of valid keys for this category (Media Keys).
        /// </summary>
        public static IEnumerable<string> ValidKeys
        {
            get => validKeys ??= DesktopInterop.CurrentPlatform switch
            {
                PluginPlatform.Windows => WindowsKeys.MediaKeys.Keys,
                PluginPlatform.Linux => LinuxKeys.MediaKeys.Keys,
                PluginPlatform.MacOS => MacOSKeys.MediaKeys.Keys,
                _ => null!
            };
        }

        public override string ToString() => $"{PLUGIN_NAME}: {Key}";
    }
}
