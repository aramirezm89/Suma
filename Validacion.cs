﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suma
{
    class Validacion
    {
        public void Solo_Numeros(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo Puede ingresar Numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
