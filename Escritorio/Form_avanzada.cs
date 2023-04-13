using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Escritorio
{
    public partial class Form_avanzada : Form
    {
        string connection_string = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=BiblioSuite;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable dt;
        private readonly Form1 frm1;
        public Form_avanzada(Form1 form1)
        {
            frm1 = form1;
            InitializeComponent();
            mayor_menor.SelectedItem = ">";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            string aut = cajetin_autor.Text;
            string tit = cajetin_titulo.Text;
            string edi = cajetin_editorial.Text;
            string ann = cajetin_anno.Text;
            string npag = cajetin_paginas.Text;
            int? annus = null;
            try
            {
               annus = Convert.ToInt32(ann);
            }
            catch
            {
                if (cajetin_anno.Text != "")
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Introduzca un año correcto");
                    return;
                }
            }
            int? pag = null;
            try
            {
                pag = Convert.ToInt32(npag);
            }
            catch
            {
                if (cajetin_paginas.Text != "")
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Introduzca un número correcto");
                    return;
                }
            }
            //ORDEN en caso de que se indique esta condición
            string signo = mayor_menor.SelectedItem.ToString();
            string inst_pag;
            inst_pag = pag == null ? "" : $"AND Npag {signo} {pag}";
            con = new SqlConnection(connection_string);
            con.Open();
            adapter = new SqlDataAdapter($"SELECT * FROM Obras WHERE Autor LIKE '%{aut}%' AND " +
                $"Titulo LIKE '%{tit}%' AND " +
                $"Editorial LIKE '%{edi}%' AND " +
                $"Anno LIKE '%{ann}%'" +
                $"{inst_pag}", con);
            dt = new DataTable();
            adapter.Fill(dt);
            frm1.dataGridView1.DataSource = dt;
            con.Close();
            this.Close();
        }

        private void cajetin_paginas_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_avanzada_Load(object sender, EventArgs e)
        {

        }
    }
}
