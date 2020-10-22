using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace SENotes5.Classes
{
    public class SystemSoundClass
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        public void VolumeUP()
        {
            keybd_event((byte)Keys.VolumeUp, 0, 0, 0); // increase volume
        }

        public void volumeDOWN()
        {
            keybd_event((byte)Keys.VolumeDown, 0, 0, 0); // decrease volume
        }
    }
}
