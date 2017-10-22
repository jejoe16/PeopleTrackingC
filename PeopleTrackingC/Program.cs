using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleTrackingC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*User.User Jesper = new User.User();
            String farvel = "A4";
            Check.Check check = new Check.Check();
            Jesper.SetPossition("på land");
            Console.WriteLine(Jesper.GetPossition());
            Console.ReadLine();
            check.CheckIn(Jesper, farvel);
            Console.Write(Jesper.GetPossition());
            Console.ReadLine(); */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form map = new Map.Overview();
            map.Show();
            Application.Run(new Form1());

        }
    }
}
