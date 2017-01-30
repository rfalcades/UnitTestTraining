using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MetodosAluno objAluno = new MetodosAluno();
             List<Int32> notas = new List<Int32>();
            notas.Add(Convert.ToInt32 (textBox2.Text));
            notas.Add(Convert.ToInt32 (textBox3.Text));
            ClasseCalculaNota calculo = new ClasseCalculaNota(objAluno);
            label4.Text = "Resultado: " + calculo.CalcularNota("Tanto Faz", notas);
        }
    }
}
