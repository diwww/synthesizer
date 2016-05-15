using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SoundGenerator
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //using (FileStream stream = new FileStream("SoundGenerator.exe.config", FileMode.Create))
            //{
            //    using (StreamWriter writer = new StreamWriter(stream))
            //    {
            //        writer.WriteLine(Properties.Resources.App);
            //    }
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
