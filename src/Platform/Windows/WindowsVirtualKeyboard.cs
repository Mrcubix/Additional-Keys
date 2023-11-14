using OpenTabletDriver.Native.Windows.Input;
using OpenTabletDriver.Plugin.Platform.Keyboard;

namespace AdditionalKeys.Platform.Windows
{
    using static OpenTabletDriver.Native.Windows.Windows;

    public class WindowsVirtualKeyboard : IVirtualKeyboard
    {
        /// <summary>
        /// Sends a key event to the system. (Press or Release)
        /// </summary>
        private void KeyEvent(string key, bool isPress)
        {
            var vk = WindowsKeys.AllKeys[key];
            var input = new INPUT
            {
                type = INPUT_TYPE.KEYBD_INPUT,
                U = new InputUnion
                {
                    ki = new KEYBDINPUT
                    {
                        wVk = (short)vk,
                        wScan = 0,
                        dwFlags = isPress ? KEYEVENTF.KEYDOWN : KEYEVENTF.KEYUP,
                        time = 0,
                        dwExtraInfo = UIntPtr.Zero
                    }
                }
            };

            var inputs = new INPUT[] { input };
            SendInput((uint)inputs.Length, inputs, INPUT.Size);
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

        public IEnumerable<string> SupportedKeys => WindowsKeys.AllKeys.Keys;
    }
}