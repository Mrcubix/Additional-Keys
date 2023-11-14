using System;
using System.Linq;
using AdditionalKeys.Platform;
using AdditionalKeys.Platform.Linux;
using AdditionalKeys.Platform.MacOS;
using AdditionalKeys.Platform.Windows;
using OpenTabletDriver.Desktop.Interop;
using OpenTabletDriver.Plugin;
using OpenTabletDriver.Plugin.Attributes;
using OpenTabletDriver.Plugin.Platform.Keyboard;

namespace AdditionalKeys
{
    [PluginName(PLUGIN_NAME)]
    public class AdditionalFKeyBindings : IBinding, IValidateBinding
    {
        private const string PLUGIN_NAME = "Additional - F13-F24";

        [Property("Property")]
        public string Property { set; get; } = String.Empty;

        public IVirtualKeyboard Keyboard { get; set; } = Shared.Keyboard;

        public Action Press
        {
            get => () => {
                if (!string.IsNullOrWhiteSpace(Property))
                    Keyboard.Press(Property);
            };
        }

        public Action Release
        {
            get => () => {
                if (!string.IsNullOrWhiteSpace(Property))
                    Keyboard.Release(Property);
            };
        }

        private string[] validProperties = null!;
        /// <summary>
        /// A list of valid keys for this category (F Keys).
        /// </summary>
        public string[] ValidProperties
        {
            get => validProperties ??= SystemInterop.CurrentPlatform switch
            {
                PluginPlatform.Windows => WindowsKeys.FKeys.Keys.ToArray(),
                PluginPlatform.Linux => LinuxKeys.FKeys.Keys.ToArray(),
                PluginPlatform.MacOS => MacOSKeys.FKeys.Keys.ToArray(),
                _ => null!
            };
        }

        public override string ToString() => $"{PLUGIN_NAME}: {Property}";
    }
}
