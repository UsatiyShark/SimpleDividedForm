using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DividedFormPractics
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller picture = new Controller();
            pictureBox1.ImageLocation = picture.ShowPic();
            
        }
    }
}
