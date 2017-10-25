using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleTrackingC
{
    public partial class GuiInterface : Form
        
    {
        User.User currentUser = new User.User();
        Check.Check checker = new Check.Check();
        String currentPoss = "Some place";
        String defaultPoss = "On the vessel";
        public GuiInterface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checker.CheckIn(currentUser, currentPoss);
            textBox1.Clear();
            textBox1.Text += "user possition = " + currentPoss;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checker.CheckOut(currentUser, currentPoss);
            textBox1.Clear();
            textBox1.Text += "user possition = " + defaultPoss;
        }
    }
}
