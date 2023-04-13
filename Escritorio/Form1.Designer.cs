using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
namespace Escritorio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.intro_isbn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel_intro = new System.Windows.Forms.Panel();
            this.editar_registro = new System.Windows.Forms.Button();
            this.borrar_registro = new System.Windows.Forms.Button();
            this.otra_obra = new System.Windows.Forms.Button();
            this.no_seleccionado = new System.Windows.Forms.Label();
            this.buscar_autor = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buscar_titulo = new System.Windows.Forms.TextBox();
            this.obraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Npag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorial_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anno_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.npag_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.npagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.restablecer = new System.Windows.Forms.Button();
            this.panel_intro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca ISBN: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // intro_isbn
            // 
            this.intro_isbn.Location = new System.Drawing.Point(9, 39);
            this.intro_isbn.Name = "intro_isbn";
            this.intro_isbn.Size = new System.Drawing.Size(158, 23);
            this.intro_isbn.TabIndex = 1;
            this.intro_isbn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(9, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Añadir manualmente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel_intro
            // 
            this.panel_intro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_intro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_intro.Controls.Add(this.label1);
            this.panel_intro.Controls.Add(this.button3);
            this.panel_intro.Controls.Add(this.intro_isbn);
            this.panel_intro.Controls.Add(this.button1);
            this.panel_intro.Controls.Add(this.label6);
            this.panel_intro.Location = new System.Drawing.Point(804, 55);
            this.panel_intro.Name = "panel_intro";
            this.panel_intro.Size = new System.Drawing.Size(354, 132);
            this.panel_intro.TabIndex = 11;
            this.panel_intro.Visible = false;
            this.panel_intro.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // editar_registro
            // 
            this.editar_registro.Location = new System.Drawing.Point(674, 95);
            this.editar_registro.Name = "editar_registro";
            this.editar_registro.Size = new System.Drawing.Size(100, 23);
            this.editar_registro.TabIndex = 23;
            this.editar_registro.Text = "Editar registro";
            this.editar_registro.UseVisualStyleBackColor = true;
            this.editar_registro.Click += new System.EventHandler(this.editar_registro_Click);
            // 
            // borrar_registro
            // 
            this.borrar_registro.Location = new System.Drawing.Point(672, 137);
            this.borrar_registro.Name = "borrar_registro";
            this.borrar_registro.Size = new System.Drawing.Size(102, 43);
            this.borrar_registro.TabIndex = 22;
            this.borrar_registro.Text = "Borrar registros seleccionados";
            this.borrar_registro.UseVisualStyleBackColor = true;
            this.borrar_registro.Click += new System.EventHandler(this.borrar_registro_Click);
            // 
            // otra_obra
            // 
            this.otra_obra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.otra_obra.Location = new System.Drawing.Point(804, 23);
            this.otra_obra.Name = "otra_obra";
            this.otra_obra.Size = new System.Drawing.Size(87, 23);
            this.otra_obra.TabIndex = 12;
            this.otra_obra.Text = "Añadir obra";
            this.otra_obra.UseVisualStyleBackColor = true;
            this.otra_obra.Click += new System.EventHandler(this.otra_obra_Click);
            // 
            // no_seleccionado
            // 
            this.no_seleccionado.AutoSize = true;
            this.no_seleccionado.ForeColor = System.Drawing.Color.Red;
            this.no_seleccionado.Location = new System.Drawing.Point(674, 285);
            this.no_seleccionado.Name = "no_seleccionado";
            this.no_seleccionado.Size = new System.Drawing.Size(0, 15);
            this.no_seleccionado.TabIndex = 24;
            // 
            // buscar_autor
            // 
            this.buscar_autor.Location = new System.Drawing.Point(312, 28);
            this.buscar_autor.Name = "buscar_autor";
            this.buscar_autor.Size = new System.Drawing.Size(100, 23);
            this.buscar_autor.TabIndex = 21;
            this.buscar_autor.TextChanged += new System.EventHandler(this.buscar_autor_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(236, 31);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(37, 15);
            this.label.TabIndex = 20;
            this.label.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Título:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buscar_titulo
            // 
            this.buscar_titulo.Location = new System.Drawing.Point(105, 27);
            this.buscar_titulo.Name = "buscar_titulo";
            this.buscar_titulo.Size = new System.Drawing.Size(100, 23);
            this.buscar_titulo.TabIndex = 18;
            this.buscar_titulo.TextChanged += new System.EventHandler(this.buscar_titulo_TextChanged);
            // 
            // obraBindingSource
            // 
            this.obraBindingSource.DataSource = typeof(Escritorio.Obra);
            // 
            // autor
            // 
            this.autor.DataPropertyName = "Autor";
            this.autor.HeaderText = "Autor";
            this.autor.Name = "autor";
            // 
            // titulo
            // 
            this.titulo.DataPropertyName = "Titulo";
            this.titulo.HeaderText = "Título";
            this.titulo.Name = "titulo";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Autor";
            this.dataGridViewTextBoxColumn1.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Editorial
            // 
            this.Editorial.DataPropertyName = "Editorial";
            this.Editorial.HeaderText = "Editorial";
            this.Editorial.Name = "Editorial";
            // 
            // Anno
            // 
            this.Anno.DataPropertyName = "Anno";
            this.Anno.HeaderText = "Anno";
            this.Anno.Name = "Anno";
            // 
            // Npag
            // 
            this.Npag.DataPropertyName = "Npag";
            this.Npag.HeaderText = "Páginas";
            this.Npag.Name = "Npag";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "isbn";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Autor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Editorial";
            this.dataGridViewTextBoxColumn5.HeaderText = "Editorial";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Anno";
            this.dataGridViewTextBoxColumn6.HeaderText = "Anno";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Npag";
            this.dataGridViewTextBoxColumn7.HeaderText = "Npag";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.autor_,
            this.titulo_,
            this.editorial_,
            this.anno_,
            this.npag_,
            this.isbn_,
            this.idDataGridViewTextBoxColumn,
            this.isbnDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.editorialDataGridViewTextBoxColumn,
            this.annoDataGridViewTextBoxColumn,
            this.npagDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.obraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(636, 354);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 20;
            // 
            // autor_
            // 
            this.autor_.DataPropertyName = "Autor";
            this.autor_.HeaderText = "Autor";
            this.autor_.Name = "autor_";
            this.autor_.Width = 150;
            // 
            // titulo_
            // 
            this.titulo_.DataPropertyName = "Titulo";
            this.titulo_.HeaderText = "Titulo";
            this.titulo_.Name = "titulo_";
            this.titulo_.Width = 150;
            // 
            // editorial_
            // 
            this.editorial_.DataPropertyName = "Editorial";
            this.editorial_.HeaderText = "Editorial";
            this.editorial_.Name = "editorial_";
            this.editorial_.Width = 80;
            // 
            // anno_
            // 
            this.anno_.DataPropertyName = "Anno";
            this.anno_.HeaderText = "Anno";
            this.anno_.Name = "anno_";
            this.anno_.Width = 50;
            // 
            // npag_
            // 
            this.npag_.DataPropertyName = "Npag";
            this.npag_.HeaderText = "Npag";
            this.npag_.Name = "npag_";
            this.npag_.Width = 50;
            // 
            // isbn_
            // 
            this.isbn_.DataPropertyName = "isbn";
            this.isbn_.HeaderText = "ISBN";
            this.isbn_.Name = "isbn_";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "isbn";
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            // 
            // editorialDataGridViewTextBoxColumn
            // 
            this.editorialDataGridViewTextBoxColumn.DataPropertyName = "Editorial";
            this.editorialDataGridViewTextBoxColumn.HeaderText = "Editorial";
            this.editorialDataGridViewTextBoxColumn.Name = "editorialDataGridViewTextBoxColumn";
            // 
            // annoDataGridViewTextBoxColumn
            // 
            this.annoDataGridViewTextBoxColumn.DataPropertyName = "Anno";
            this.annoDataGridViewTextBoxColumn.HeaderText = "Anno";
            this.annoDataGridViewTextBoxColumn.Name = "annoDataGridViewTextBoxColumn";
            // 
            // npagDataGridViewTextBoxColumn
            // 
            this.npagDataGridViewTextBoxColumn.DataPropertyName = "Npag";
            this.npagDataGridViewTextBoxColumn.HeaderText = "Npag";
            this.npagDataGridViewTextBoxColumn.Name = "npagDataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(466, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Búsqueda avanzada";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // restablecer
            // 
            this.restablecer.Location = new System.Drawing.Point(599, 28);
            this.restablecer.Name = "restablecer";
            this.restablecer.Size = new System.Drawing.Size(75, 23);
            this.restablecer.TabIndex = 28;
            this.restablecer.Text = "Restablecer";
            this.restablecer.UseVisualStyleBackColor = true;
            this.restablecer.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1182, 450);
            this.Controls.Add(this.restablecer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.no_seleccionado);
            this.Controls.Add(this.editar_registro);
            this.Controls.Add(this.borrar_registro);
            this.Controls.Add(this.buscar_autor);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buscar_titulo);
            this.Controls.Add(this.otra_obra);
            this.Controls.Add(this.panel_intro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "BiblioSuite";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_intro.ResumeLayout(false);
            this.panel_intro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox intro_isbn;
        private Button button1;
        private Label label6;
        private Button button3;
        private Panel panel_intro;
        private Button otra_obra;
        private Label ya_existente;
        private Label no_seleccionado;
        private Button editar_registro;
        private Button borrar_registro;
        private TextBox buscar_autor;
        private Label label;
        private Label label2;
        private TextBox buscar_titulo;
        private BindingSource obraBindingSource;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn autor;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Editorial;
        private DataGridViewTextBoxColumn Anno;
        private DataGridViewTextBoxColumn Npag;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn autor_;
        private DataGridViewTextBoxColumn titulo_;
        private DataGridViewTextBoxColumn editorial_;
        private DataGridViewTextBoxColumn anno_;
        private DataGridViewTextBoxColumn npag_;
        private DataGridViewTextBoxColumn isbn_;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn editorialDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn annoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn npagDataGridViewTextBoxColumn;
        private Button button2;
        private Button restablecer;
    }
}