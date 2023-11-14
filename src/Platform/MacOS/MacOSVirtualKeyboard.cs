using System;
using System.Collections.Generic;
using OpenTabletDriver.Native.OSX.Generic;
using OpenTabletDriver.Plugin.Platform.Keyboard;

namespace AdditionalKeys.Platform.MacOS
{
    using static AdditionalKeys.Platform.MacOS.OSX.OSX;

    public class MacOSVirtualKeyboard : IVirtualKeyboard
    {
        /// <summary>
        /// Sends a key event to the system. (Press or Release)
        /// </summary>
        private void KeyEvent(string key, bool isPress)
        {
            if (MacOSKeys.AllKeys.TryGetValue(key, out var code))
            {
                var keyEvent = CGEventCreateKeyboardEvent(IntPtr.Zero, code, isPress);
                CGEventPost(CGEventTapLocation.kCGHIDEventTap, keyEvent);
                CFRelease(keyEvent);
            }
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

        public IEnumerable<string> SupportedKeys => MacOSKeys.AllKeys.Keys;
    }
}
