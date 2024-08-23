using preParcial1._1.Models;
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

namespace preParcial1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList envios = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            Envio envio = new Envio();
            Costo c;
            c = new Fijo("Peaje puente zarate", 300);
            envio.AgregarCosto(c);
            c = new Variable("Combustible - Listros", 1500.5, 500);
            envio.AgregarCosto(c);
            envios.Add(envio);
            Envio envio2 = new Envio();
            c = new Fijo("Peaje túnel", 300);
            envio2.AgregarCosto(c);
            c = new Variable("Horas de conducción", 500, 10);
            envio2.AgregarCosto(c);
            envios.Add(envio2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0;i< envios.Count; i++)
            {
                Envio env = ((Envio)envios[i]);
                textBox1.Text += env.VerDetalle();
                textBox1.Text += $"Total: {env.ValorTotal}";
            }
        }
    }
}
