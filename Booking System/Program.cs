using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking_System
{
    internal static class Program
    {
        public static PrivateFontCollection pfc = new PrivateFontCollection();
        public static PrivateFontCollection pfc2 = new PrivateFontCollection();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            //Select your font from the resources.
            //My font here is "Digireu.ttf"
            int fontLength = Properties.Resources.bahnschrift.Length;
            int fontLength2 = Properties.Resources.bebasneue.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.bahnschrift;
            byte[] fontdata2 = Properties.Resources.bebasneue;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            System.IntPtr data2 = Marshal.AllocCoTaskMem(fontLength2);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);
            Marshal.Copy(fontdata2, 0, data2, fontLength2);

            // pass the font to the font collection
            pfc.AddMemoryFont(data, fontLength);
            pfc2.AddMemoryFont(data2, fontLength2);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //LoadCustomFont("bebas-neue.ttf");
            //LoadCustomFont("bahnschrift.ttf");
            Application.Run(new Login(""));
        }
        public static void ChangeFont(Control control)
        {
            control.Font = new Font(Program.pfc.Families[1], control.Font.Size);
            foreach (Control childControl in control.Controls)
            {
                ChangeFont(childControl);
            }
        }

    }
}
