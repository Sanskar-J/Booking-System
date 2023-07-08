using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //LoadCustomFont("bebas-neue.ttf");
            //LoadCustomFont("bahnschrift.ttf");
            Application.Run(new Login(""));
        }
        private static void LoadCustomFont(string name)
        {
            string fontPath = Path.Combine(Application.StartupPath, name);
            // Replace "YourFont.ttf" with the actual name of your font file

            if (File.Exists(fontPath))
            {
                FontFamily fontFamily = new FontFamily(Path.GetFileNameWithoutExtension(fontPath));
                // Create a FontFamily object using the font file's name (without extension)

                Font customFont = new Font(fontFamily, 12f, FontStyle.Regular);
                // Create a Font object using the custom font family, size, and style

            }
        }
    }
}
