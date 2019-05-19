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
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            int fact = 1,n;
            n = Convert.ToInt32(IngresetextBox.Text);
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                ResultadotextBox.Text = fact.ToString();
            }
        }
    }
}
