using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabla_de_multiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            int num, tabla, resultado;
            tabla = int.Parse(txt_numero.Text);

            for (num = 1; num <= 12; num++)
            {
                resultado = num * tabla;
                lst_tabla.Items.Add(tabla + "x" + num + "=" + resultado);
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            lst_tabla.Items.Clear();
            txt_numero.Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();

        }      
    } 
}
