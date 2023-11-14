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
    public class AdditionalFKeyBindings : IStateBinding
    {
        private const string PLUGIN_NAME = "Additional - F13-F24";

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
        /// A list of valid keys for this category (F Keys).
        /// </summary>
        public static IEnumerable<string> ValidKeys
        {
            get => validKeys ??= DesktopInterop.CurrentPlatform switch
            {
                PluginPlatform.Windows => WindowsKeys.FKeys.Keys,
                PluginPlatform.Linux => LinuxKeys.FKeys.Keys,
                PluginPlatform.MacOS => MacOSKeys.FKeys.Keys,
                _ => null!
            };
        }

        public override string ToString() => $"{PLUGIN_NAME}: {Key}";
    }
}
