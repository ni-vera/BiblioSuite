using Escritorio;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Media;
using System.Net;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;
using nombre_isni = Escritorio.responseRecordISNIAssignedISNIMetadataIdentityPersonOrFictionPersonalName; 

namespace Escritorio
{
    public partial class Form1 : Form
    {
        string connection_string = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=BiblioSuite;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private BiblioContext? dbContext;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new BiblioContext();

            this.dbContext.Obras.Load();

            this.obraBindingSource.DataSource = dbContext.Obras.Local.ToBindingList();
            con = new SqlConnection(connection_string);
            con.Open();
            //TODAS_ORDENADAS = SELECT * FROM Obras ORDER BY Autor, Titulo
            adapter = new SqlDataAdapter($"EXEC TODAS_ORDENADAS", con);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            this.dataGridView1.AutoGenerateColumns = false;

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isbn = intro_isbn.Text;
            string noentiendo = string.Format($"https://www.googleapis.com/books/v1/volumes?q=isbn:{isbn}&key=AIzaSyDFNPFwicG3bCoPtKrZ5cFvRfbsssEYGDs");
            WebRequest requestObjGet = WebRequest.Create(noentiendo);
            HttpWebResponse responseObjGet = null;
            responseObjGet = (HttpWebResponse)requestObjGet.GetResponse();
            string noentiendo2 = null;
            using (Stream stream = responseObjGet.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream); 
                noentiendo2 = @sr.ReadToEnd();
                sr.Close();
            }
            Rootobject? resultados = JsonSerializer.Deserialize<Rootobject>(noentiendo2);
            if (resultados.totalItems > 0)
            {
                string titulo = resultados.items[0].volumeInfo.title;
                string autor = resultados.items[0].volumeInfo.authors[0];
                List<string> autores = new List<string>();
                foreach(string artifice in resultados.items[0].volumeInfo.authors)
                {
                    autores.Add(artifice);
                }
                string anno = resultados.items[0].volumeInfo.publishedDate;
                string editorial = resultados.items[0].volumeInfo.publisher;
                string npag = Convert.ToString(resultados.items[0].volumeInfo.pageCount);
                //API de autores
                /*
                requestObjGet = WebRequest.Create($"https://www.wikidata.org/w/api.php?action=wbsearchentities&format=json&language=es&type=item&continue=0&search={autor}");
                responseObjGet = null;
                responseObjGet = (HttpWebResponse)requestObjGet.GetResponse();
                Stream stream = responseObjGet.GetResponseStream();
                noentiendo2 = null;
                using (stream = responseObjGet.GetResponseStream())
                {
                    StreamReader sr = new StreamReader(stream);
                    noentiendo2 = @sr.ReadToEnd();
                    sr.Close();
                }
                WDSearch.objeto_raiz resultaos = JsonSerializer.Deserialize<WDSearch.objeto_raiz>(noentiendo2);
                string wikidata_ID = resultaos.search[0].id;

                requestObjGet = WebRequest.Create($"https://www.wikidata.org/wiki/Special:EntityData/{wikidata_ID}.json");
                responseObjGet = null;
                responseObjGet = (HttpWebResponse)requestObjGet.GetResponse();
                stream = responseObjGet.GetResponseStream();
                noentiendo2 = null;
                using (stream = responseObjGet.GetResponseStream())
                {
                    StreamReader sr = new StreamReader(stream);
                    noentiendo2 = @sr.ReadToEnd();
                    sr.Close();
                }
                entidad_raiz datos_autor = JsonSerializer.Deserialize<entidad_raiz>(noentiendo2);
                string anno_nac = datos_autor.entities.;
                */

                List<Autor> lista_autores = new List<Autor>();
                foreach (string artifice in autores)
                {
                    string variable_peticion = Regex.Replace(artifice, @"\s", "+");
                    requestObjGet = WebRequest.Create($"http://isni.oclc.org/sru/?query=pica.na+%3D+%22{variable_peticion}%22&operation=searchRetrieve&recordSchema=isni-b");
                    responseObjGet = null;
                    responseObjGet = (HttpWebResponse)requestObjGet.GetResponse();
                    Stream stream = responseObjGet.GetResponseStream();
                    var serializer = new XmlSerializer(typeof(searchRetrieveResponse));
                    try
                    {
                        searchRetrieveResponse? resultats = serializer.Deserialize(stream) as searchRetrieveResponse;
                        Autor auctor = null;
                        if (resultats.numberOfRecords > 0)
                        {
                            string issn = resultats.recordsField[0].recordData.responseRecord.ISNIAssigned.isniUnformatted;
                            string forename = resultats.recordsField[0].recordData.responseRecord.ISNIAssigned.ISNIMetadata.identity.personOrFiction.personalName[0].forename;
                            responseRecordISNIAssignedISNIMetadataIdentityPersonOrFictionPersonalName[] nombres = resultats.recordsField[0].recordData.responseRecord.ISNIAssigned.ISNIMetadata.identity.personOrFiction.personalName;
                            string periodo_vital = "";
                            foreach (responseRecordISNIAssignedISNIMetadataIdentityPersonOrFictionPersonalName nombre in nombres)
                            {
                                if (!nombre.marcDate.IsNullOrEmpty())
                                {
                                    periodo_vital = nombre.marcDate;
                                    break;
                                }
                            }
                            //string periodo_vital = resultats.recordsField[0].recordData.responseRecord.ISNIAssigned.ISNIMetadata.identity.personOrFiction.personalName[0].marcDate;
                            string[] nacimiento_defuncion = periodo_vital.Split("-");
                            int? annus_nacendi = Convert.ToInt32(nacimiento_defuncion[0]);
                            int? annus_defunctio = null;
                            if (nacimiento_defuncion[1] != "")
                            {
                                annus_defunctio = Convert.ToInt32(nacimiento_defuncion[1]);
                            }
                            auctor = new Autor(issn, forename, annus_nacendi, annus_defunctio);
                            lista_autores.Add(auctor);
                        }
                    }catch(Exception ex)
                    {

                    }
                }
                autor = string.Join("; ",autores);
                
                Form2 frm2 = new Form2(this, autor, titulo, editorial, anno,npag,isbn,lista_autores);
                frm2.Show();
            }
            else
            {
                label6.Text = "Por favor, introduzca un número ISBN correcto";
            }
            intro_isbn.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(this);
            frm2.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void otra_obra_Click(object sender, EventArgs e)
        {
            switch (panel_intro.Visible)
            {
                case true:
                    panel_intro.Visible = false;
                    otra_obra.Text = "Añadir obra";
                    break;
                case false:
                    panel_intro.Visible = true;
                    otra_obra.Text = "Ocultar";
                    break;
            }
        }

        private void editar_registro_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection fila = dataGridView1.CurrentRow.Cells;
            string titulo = fila["titulo_"].Value.ToString();
            string autor = fila["autor_"].Value.ToString();
            string anno = fila["anno_"].Value.ToString();
            string editorial = fila["editorial_"].Value.ToString();
            string npag = fila["npag_"].Value.ToString();
            string isbn = fila["isbn_"].Value.ToString();
            Form2 frm2 = new Form2(this, autor, titulo, editorial, anno, npag, isbn);
            frm2.Show();
        }

        private void buscar_autor_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(connection_string);
            con.Open();
            adapter = new SqlDataAdapter($"SELECT * FROM Obras WHERE Autor LIKE '%{buscar_autor.Text}%' AND Titulo LIKE '%{buscar_titulo.Text}%' ", con);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void buscar_titulo_TextChanged(object sender, EventArgs e)
        {
            buscar_autor_TextChanged(sender, e);
        }

        private void borrar_registro_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id_delete = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
                string titulo = dataGridView1.SelectedRows[0].Cells["titulo_"].Value.ToString();
                string autor = dataGridView1.SelectedRows[0].Cells["autor_"].Value.ToString();
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                SystemSounds.Beep.Play();
                var desea_borrar = MessageBox.Show($"¿Desea borrar \"{titulo}\" de {autor}?","Confirmación",botones);
                if (desea_borrar == DialogResult.Yes)
                {
                    con = new SqlConnection(connection_string);
                    con.Open();
                    SqlCommand command = new SqlCommand($"DELETE FROM Obras WHERE Id='{id_delete}'", con);
                    command.ExecuteNonQuery();
                    adapter = new SqlDataAdapter("EXEC TODAS_ORDENADAS", con);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
            }
            else
            {
                no_seleccionado.Text = "Ningún registro seleccionado";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_avanzada frmav = new Form_avanzada(this);
            frmav.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connection_string);
            con.Open();
            adapter = new SqlDataAdapter("EXEC TODAS_ORDENADAS", con);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}