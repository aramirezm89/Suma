using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suma
{
    public partial class Suma : Form
    {
        Validacion Validacion1= new Validacion();
        public Suma()
        {
            InitializeComponent();
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            int num1, num2, suma;
            num1 = 0;
            num2 = 0;
            suma = 0;
            num1 = int.Parse(TxtNum1.Text);
            num2 = int.Parse(TxtNum2.Text);
            suma = num1 + num2;

            TxtResult.Text =  suma.ToString();



        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion1.Solo_Numeros(e);   

        }

        private void TxtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion1.Solo_Numeros(e);
        }
    }
}
