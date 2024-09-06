using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_09_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }
        private void Agregar()
        {
            if(TbTitulo.Text.Trim().Length > 0)
            {
                string Titulo=TbTitulo.Text.Trim();
                LbLibros.Items.Add(Titulo);
                TbTitulo.Clear();
                TbTitulo.Focus();
            }

        }

        private void TbTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Agregar();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cant = LbLibros.Items.Count;
            for(int i = 0; i < cant; i++)
            {
                string titulo = LbLibros.Items[i].ToString();
                LbCopia.Items.Add(titulo);
            }
        }

        private void BtnMover_Click(object sender, EventArgs e)
        {
            if(LbLibros.Items.Count > 0)
            { 
                string titulo= LbLibros.SelectedItem.ToString();
                LbCopia.Items.Add(titulo);
                int index = LbLibros.SelectedIndex;
                LbLibros.Items.RemoveAt(index);
            }
        }
    }
}
