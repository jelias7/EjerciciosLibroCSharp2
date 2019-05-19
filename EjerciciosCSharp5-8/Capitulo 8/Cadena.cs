using System;
using System.Collections;
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
    public partial class Cadena : Form
    {
        public Cadena()
        {
            InitializeComponent();
        }

        private void Ordenbutton1_Click(object sender, EventArgs e)
        {
            ArrayList array = new ArrayList();
            array.Add(CadtextBox1.Text);
            array.Add(CadtextBox2.Text);
            array.Sort();

            int i = 0;
            foreach(String cadena in array){
                Console.WriteLine("{0}", cadena);
                if (i == 0)
                {
                    CadtextBox3.Text = cadena;
                }
                else
                {
                    CadtextBox4.Text = cadena;
                }
                i = 1;
            }
        }
    }
}
