using AdditionalKeys.Platform.Linux;
using AdditionalKeys.Platform.MacOS;
using AdditionalKeys.Platform.Windows;
using OpenTabletDriver.Desktop.Interop;
using OpenTabletDriver.Plugin;
using OpenTabletDriver.Plugin.Platform.Keyboard;

namespace AdditionalKeys.Platform
{
    public class Shared
    {
        /// <summary>
        /// Gets the virtual keyboard for the current platform.
        /// </summary>
        public static readonly IVirtualKeyboard Keyboard = DesktopInterop.CurrentPlatform switch
        {
            PluginPlatform.Windows => new WindowsVirtualKeyboard(),
            PluginPlatform.Linux => new EvdevVirtualKeyboard(),
            PluginPlatform.MacOS => new MacOSVirtualKeyboard(),
            _ => null!
        };
    }
}