namespace Escritorio
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.autor = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.cajetin_autor = new System.Windows.Forms.TextBox();
            this.cajetin_titulo = new System.Windows.Forms.TextBox();
            this.agregar_libro = new System.Windows.Forms.Button();
            this.cajetin_anno = new System.Windows.Forms.TextBox();
            this.anno = new System.Windows.Forms.Label();
            this.cajetin_editorial = new System.Windows.Forms.TextBox();
            this.editorial = new System.Windows.Forms.Label();
            this.cajetin_npag = new System.Windows.Forms.TextBox();
            this.npag = new System.Windows.Forms.Label();
            this.isbn = new System.Windows.Forms.Label();
            this.isbn_save = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nacimiento = new System.Windows.Forms.Label();
            this.muerte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // autor
            // 
            this.autor.AutoSize = true;
            this.autor.Location = new System.Drawing.Point(60, 69);
            this.autor.Name = "autor";
            this.autor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.autor.Size = new System.Drawing.Size(40, 15);
            this.autor.TabIndex = 0;
            this.autor.Text = "Autor:";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Location = new System.Drawing.Point(60, 109);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(40, 15);
            this.titulo.TabIndex = 1;
            this.titulo.Text = "Título:";
            this.titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // cajetin_autor
            // 
            this.cajetin_autor.Location = new System.Drawing.Point(136, 61);
            this.cajetin_autor.Name = "cajetin_autor";
            this.cajetin_autor.Size = new System.Drawing.Size(275, 23);
            this.cajetin_autor.TabIndex = 2;
            this.cajetin_autor.TextChanged += new System.EventHandler(this.cajetin_autor_TextChanged);
            // 
            // cajetin_titulo
            // 
            this.cajetin_titulo.Location = new System.Drawing.Point(136, 101);
            this.cajetin_titulo.Name = "cajetin_titulo";
            this.cajetin_titulo.Size = new System.Drawing.Size(275, 23);
            this.cajetin_titulo.TabIndex = 3;
            // 
            // agregar_libro
            // 
            this.agregar_libro.Location = new System.Drawing.Point(136, 296);
            this.agregar_libro.Name = "agregar_libro";
            this.agregar_libro.Size = new System.Drawing.Size(114, 23);
            this.agregar_libro.TabIndex = 4;
            this.agregar_libro.Text = "Confirmar";
            this.agregar_libro.UseVisualStyleBackColor = true;
            this.agregar_libro.Click += new System.EventHandler(this.agregar_libro_Click);
            // 
            // cajetin_anno
            // 
            this.cajetin_anno.Location = new System.Drawing.Point(136, 148);
            this.cajetin_anno.Name = "cajetin_anno";
            this.cajetin_anno.Size = new System.Drawing.Size(275, 23);
            this.cajetin_anno.TabIndex = 6;
            this.cajetin_anno.TextChanged += new System.EventHandler(this.cajetin_anno_TextChanged);
            // 
            // anno
            // 
            this.anno.AutoSize = true;
            this.anno.Location = new System.Drawing.Point(60, 151);
            this.anno.Name = "anno";
            this.anno.Size = new System.Drawing.Size(32, 15);
            this.anno.TabIndex = 5;
            this.anno.Text = "Año:";
            this.anno.Click += new System.EventHandler(this.anno_Click);
            // 
            // cajetin_editorial
            // 
            this.cajetin_editorial.Location = new System.Drawing.Point(136, 188);
            this.cajetin_editorial.Name = "cajetin_editorial";
            this.cajetin_editorial.Size = new System.Drawing.Size(275, 23);
            this.cajetin_editorial.TabIndex = 8;
            // 
            // editorial
            // 
            this.editorial.AutoSize = true;
            this.editorial.Location = new System.Drawing.Point(60, 196);
            this.editorial.Name = "editorial";
            this.editorial.Size = new System.Drawing.Size(53, 15);
            this.editorial.TabIndex = 7;
            this.editorial.Text = "Editorial:";
            this.editorial.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cajetin_npag
            // 
            this.cajetin_npag.Location = new System.Drawing.Point(136, 217);
            this.cajetin_npag.Name = "cajetin_npag";
            this.cajetin_npag.Size = new System.Drawing.Size(275, 23);
            this.cajetin_npag.TabIndex = 12;
            // 
            // npag
            // 
            this.npag.AutoSize = true;
            this.npag.Location = new System.Drawing.Point(60, 225);
            this.npag.Name = "npag";
            this.npag.Size = new System.Drawing.Size(47, 15);
            this.npag.TabIndex = 11;
            this.npag.Text = "Nº pág.";
            this.npag.Click += new System.EventHandler(this.label2_Click);
            // 
            // isbn
            // 
            this.isbn.AutoSize = true;
            this.isbn.Location = new System.Drawing.Point(136, 259);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(0, 15);
            this.isbn.TabIndex = 13;
            // 
            // isbn_save
            // 
            this.isbn_save.AutoSize = true;
            this.isbn_save.Location = new System.Drawing.Point(137, 259);
            this.isbn_save.Name = "isbn_save";
            this.isbn_save.Size = new System.Drawing.Size(32, 15);
            this.isbn_save.TabIndex = 14;
            this.isbn_save.Text = "ISBN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Datos del autor";
            // 
            // nacimiento
            // 
            this.nacimiento.AutoSize = true;
            this.nacimiento.Location = new System.Drawing.Point(502, 69);
            this.nacimiento.Name = "nacimiento";
            this.nacimiento.Size = new System.Drawing.Size(123, 15);
            this.nacimiento.TabIndex = 17;
            this.nacimiento.Text = "Fecha de nacimiento: ";
            // 
            // muerte
            // 
            this.muerte.AutoSize = true;
            this.muerte.Location = new System.Drawing.Point(502, 109);
            this.muerte.Name = "muerte";
            this.muerte.Size = new System.Drawing.Size(114, 15);
            this.muerte.TabIndex = 18;
            this.muerte.Text = "Fecha de defunción:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.muerte);
            this.Controls.Add(this.nacimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isbn_save);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.cajetin_npag);
            this.Controls.Add(this.npag);
            this.Controls.Add(this.cajetin_editorial);
            this.Controls.Add(this.editorial);
            this.Controls.Add(this.cajetin_anno);
            this.Controls.Add(this.anno);
            this.Controls.Add(this.agregar_libro);
            this.Controls.Add(this.cajetin_titulo);
            this.Controls.Add(this.cajetin_autor);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.autor);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label autor;
        private Label titulo;
        private TextBox cajetin_autor;
        private TextBox cajetin_titulo;
        private Button agregar_libro;
        private TextBox cajetin_anno;
        private Label anno;
        private TextBox cajetin_editorial;
        private Label editorial;
        private TextBox cajetin_npag;
        private Label npag;
        private Label isbn;
        private Label isbn_save;
        private Label label1;
        private Label label2;
        private Label nacimiento;
        private Label muerte;
    }
}