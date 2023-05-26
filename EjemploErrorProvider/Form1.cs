using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploErrorProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            bool error = false;
            foreach(char caracter in txtDato.Text)
            {
                if (char.IsDigit(caracter))
                {
                    error = true;
                    break;
                }

            }
            //Verificamos por la condición de error

            if (error)

                epTxt.SetError(txtDato, "No se admiten números");

            else
                epTxt.Clear();
        }

        private void txtDato_TextChanged(object sender, EventArgs e)
        {
            bool error = false;
            foreach (char caracter in txtDato.Text)
            {
                if (char.IsDigit(caracter))
                {
                    error = true;
                    break;
                }

            }
            //verificamos por la condición de error

            if (error)

                epTxt.SetError(txtDato, "no se admiten números");

            else
                epTxt.Clear();
        }

        private void txtDato2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false; //para indicar que no se debe tener en cuenta la pulsación de dicha tecla, esto en .NET se hace asignando un valor verdadero a la propiedad Handled del objeto e:
                epTxt.Clear();
            }

            else
            {
                e.Handled = true;

                epTxt.SetError(txtDato2, "Sólo se admiten números");
            }

        }

       
    }
 }

