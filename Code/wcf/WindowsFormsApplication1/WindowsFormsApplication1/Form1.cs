using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.IService1 objTeste = new ServiceReference1.Service1Client();
            classeLocal objLocal = new classeLocal();
            textBox2.Text = objLocal.GetNomeFinal(objTeste, textBox1.Text);
        }
    }
}
