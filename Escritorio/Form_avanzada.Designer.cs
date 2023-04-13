namespace Escritorio
{
    partial class Form_avanzada
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cajetin_autor = new System.Windows.Forms.TextBox();
            this.cajetin_titulo = new System.Windows.Forms.TextBox();
            this.cajetin_editorial = new System.Windows.Forms.TextBox();
            this.cajetin_anno = new System.Windows.Forms.TextBox();
            this.cajetin_paginas = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.Button();
            this.mayor_menor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Editorial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Año";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nº páginas";
            // 
            // cajetin_autor
            // 
            this.cajetin_autor.Location = new System.Drawing.Point(126, 36);
            this.cajetin_autor.Name = "cajetin_autor";
            this.cajetin_autor.Size = new System.Drawing.Size(100, 23);
            this.cajetin_autor.TabIndex = 5;
            // 
            // cajetin_titulo
            // 
            this.cajetin_titulo.Location = new System.Drawing.Point(126, 73);
            this.cajetin_titulo.Name = "cajetin_titulo";
            this.cajetin_titulo.Size = new System.Drawing.Size(100, 23);
            this.cajetin_titulo.TabIndex = 6;
            // 
            // cajetin_editorial
            // 
            this.cajetin_editorial.Location = new System.Drawing.Point(126, 115);
            this.cajetin_editorial.Name = "cajetin_editorial";
            this.cajetin_editorial.Size = new System.Drawing.Size(100, 23);
            this.cajetin_editorial.TabIndex = 7;
            // 
            // cajetin_anno
            // 
            this.cajetin_anno.Location = new System.Drawing.Point(126, 150);
            this.cajetin_anno.Name = "cajetin_anno";
            this.cajetin_anno.Size = new System.Drawing.Size(100, 23);
            this.cajetin_anno.TabIndex = 8;
            // 
            // cajetin_paginas
            // 
            this.cajetin_paginas.Location = new System.Drawing.Point(126, 187);
            this.cajetin_paginas.Name = "cajetin_paginas";
            this.cajetin_paginas.Size = new System.Drawing.Size(100, 23);
            this.cajetin_paginas.TabIndex = 9;
            this.cajetin_paginas.TextChanged += new System.EventHandler(this.cajetin_paginas_TextChanged);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(31, 248);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 10;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // mayor_menor
            // 
            this.mayor_menor.FormattingEnabled = true;
            this.mayor_menor.Items.AddRange(new object[] {
            ">",
            "<"});
            this.mayor_menor.Location = new System.Drawing.Point(249, 187);
            this.mayor_menor.Name = "mayor_menor";
            this.mayor_menor.Size = new System.Drawing.Size(35, 23);
            this.mayor_menor.TabIndex = 11;
            // 
            // Form_avanzada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mayor_menor);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.cajetin_paginas);
            this.Controls.Add(this.cajetin_anno);
            this.Controls.Add(this.cajetin_editorial);
            this.Controls.Add(this.cajetin_titulo);
            this.Controls.Add(this.cajetin_autor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_avanzada";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form_avanzada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox cajetin_autor;
        private TextBox cajetin_titulo;
        private TextBox cajetin_editorial;
        private TextBox cajetin_anno;
        private TextBox cajetin_paginas;
        private Button buscar;
        private ComboBox mayor_menor;
    }
}