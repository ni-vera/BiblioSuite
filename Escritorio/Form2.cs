using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class Form2 : Form
    {
        string connection_string = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=BiblioSuite;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable dt;
        private readonly Form1 frm1;
        private readonly Autor escritor;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            frm1 = form1;
        }
        public Form2(Form1 form1,string autor, string titulo,string editorial, string anno, string npag, string isbn_save) : this(form1)
        {
            this.cajetin_autor.Text = autor;
            this.cajetin_titulo.Text = titulo;
            this.cajetin_anno.Text = Convert.ToString(anno);
            this.cajetin_editorial.Text = editorial;
            this.cajetin_npag.Text = Convert.ToString(npag);
            this.isbn_save.Text = isbn_save;
        }
        public Form2(Form1 form1, string autor, string titulo, string editorial, string anno, string npag, string isbn_save,List<Autor> lista_autores) : this (form1, autor,titulo,editorial,anno,npag,isbn_save)
        {
            if (lista_autores.Count() > 0) {
                this.escritor = lista_autores[0];
            }
            if (escritor is not null)
            {
                nacimiento.Text += escritor.annus_natio.ToString();
                muerte.Text += escritor.annus_defunctio.ToString();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void anno_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void agregar_libro_Click(object sender, EventArgs e)
        {
            using (var context = new BiblioContext())
            {
                int anno;
                try
                {
                    anno = Convert.ToInt32(cajetin_anno.Text);
                } catch (FormatException ex)
                {
                    if (Regex.IsMatch(cajetin_anno.Text, @"\d{4}-\d{2}-\d{2}"))
                    {
                        string[] fecha_partida = cajetin_anno.Text.Split("-");
                        anno = Convert.ToInt32(fecha_partida[0]);
                    }
                    else
                    {
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Introduzca el año de publicación en un formato adecuado");
                        return;
                    }
                }
                int npag = Convert.ToInt32(cajetin_npag.Text);
                Obra libro = new Obra(cajetin_autor.Text, cajetin_titulo.Text, cajetin_editorial.Text, anno, npag, isbn_save.Text);
                con = new SqlConnection(connection_string);
                con.Open();
                adapter = new SqlDataAdapter($"SELECT COUNT(*) FROM Obras WHERE isbn = '{isbn_save.Text}'", con);
                DataTable conteo = new DataTable();
                adapter.Fill(conteo);
                int conteo_int = Convert.ToInt32(conteo.Rows[0][0]);
                if (conteo_int == 0)
                {
                    context.Obras.Add(libro);
                    context.SaveChanges();
                }
                else
                {
                    SqlCommand command = new SqlCommand("UPDATE Obras SET " +
                        $"Autor = '{cajetin_autor.Text}'" +
                        $"Titulo = '{cajetin_titulo.Text}'+" +
                        $"Editorial = '{cajetin_editorial.Text}'+" +
                        $"Anno = '{cajetin_anno.Text}'+" +
                        $"Npag = '{cajetin_npag.Text}' +" +
                        $"WHERE isbn= '{isbn_save.Text}'",con);
                }
                adapter = new SqlDataAdapter("EXEC TODAS_ORDENADAS", con);
                dt = new DataTable();
                adapter.Fill(dt);
                frm1.dataGridView1.DataSource = dt;
                con.Close();
            }
            Close();
        }

        private void cajetin_anno_TextChanged(object sender, EventArgs e)
        {

        }

        private void cajetin_autor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
