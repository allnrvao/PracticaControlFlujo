using Evaluacion.clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class Form1 : Form
    {
        Numero num = new Numero();
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        //Se agregan los elementos del textbox al listbox
        public void AgregarBox ()
        {
            int max = 0;
            int min = num.GetElements()[(int)0];
            try
            {

                LbNum.Items.Clear();
                for (int i = 0; i < index; i++)
                {
                    //calcular numero mayor
                    LbNum.Items.Add(num.GetElements()[(int)i]);
                    if(num.GetElements()[(int)i] > max)
                    {
                        max = num.GetElements()[(int)i];
                    }
                    //calcular el numero menor
                    if (num.GetElements()[(int)i] < min)
                    {
                        min = num.GetElements()[(int)i];
                    }

                }
            }
            catch (Exception ex)
            {
                //mensaje de error
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // se muestran los resultados
            int suma = num.GetElements().Sum();
            lblsumadenum.Text = "La suma es: " + suma;
            Lblnummayor.Text = "El mayor es: " + max;
            Lblnummenor.Text = "El numero menor es: " + min;

        }
        //formar el boton
        private void button1_Click(object sender, EventArgs e)
        {
            int numero = 0;
            numero = int.Parse(TbNumero.Text);
            try
            {
                if (numero >= 0)
                {
                    num.IngresarNumero(numero, index);
                    index++;
                    AgregarBox();
                    TbNumero.Clear();
                    TbNumero.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblsumadenum_Click(object sender, EventArgs e)
        {

        }
    }
}
