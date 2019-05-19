using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2Ejercicios
{
    public partial class Fecha : Form
    {
        public Fecha()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("hh:mm:tt yyyy/dd/MM");
        }

        private void FechaLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
