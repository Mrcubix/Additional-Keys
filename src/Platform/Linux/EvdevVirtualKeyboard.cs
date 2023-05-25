using AdditionalKeys.Platform.Linux.Evdev;
using OpenTabletDriver.Native.Linux;
using OpenTabletDriver.Plugin;
using OpenTabletDriver.Plugin.Platform.Keyboard;

namespace AdditionalKeys.Platform.Linux
{
    public class EvdevVirtualKeyboard : IVirtualKeyboard, IDisposable
    {
        public EvdevVirtualKeyboard()
        {
            Device = new EvdevDevice("OpenTabletDriver Virtual Keyboard");

            Device.EnableTypeCodes(EventType.EV_KEY, LinuxKeys.AllKeys.Values.Distinct().ToArray());

            var result = Device.Initialize();
            switch (result)
            {
                case ERRNO.NONE:
                    Log.Debug("Evdev", $"Successfully initialized virtual keyboard. (code {result})");
                    break;
                default:
                    Log.Write("Evdev", $"Failed to initialize virtual keyboard. (error code {result})", LogLevel.Error);
                    break;
            }
        }

        private EvdevDevice Device { set; get; }

        /// <summary>
        /// Sends a key event to the system. (Press or Release)
        /// </summary>
        private void KeyEvent(string key, bool isPress)
        {
            var keyEventCode = LinuxKeys.AllKeys[key];

            Device.Write(EventType.EV_KEY, keyEventCode, isPress ? 1 : 0);
            Device.Sync();
        }

        public void Press(string key)
        {
            KeyEvent(key, true);
        }

        public void Release(string key)
        {
            KeyEvent(key, false);
        }

        public void Press(IEnumerable<string> keys)
        {
            foreach (var key in keys)
                KeyEvent(key, true);
        }

        public void Release(IEnumerable<string> keys)
        {
            foreach (var key in keys)
                KeyEvent(key, false);
        }

        public void Dispose()
        {
            Device?.Dispose();
        }

        public IEnumerable<string> SupportedKeys => LinuxKeys.AllKeys.Keys;
    }
}
