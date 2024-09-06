namespace _06_09_24
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.TbTitulo = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LbLibros = new System.Windows.Forms.ListBox();
            this.LbCopia = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnMover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TbTitulo
            // 
            this.TbTitulo.Location = new System.Drawing.Point(509, 47);
            this.TbTitulo.Name = "TbTitulo";
            this.TbTitulo.Size = new System.Drawing.Size(284, 26);
            this.TbTitulo.TabIndex = 2;
            this.TbTitulo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TbTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTitulo_KeyPress);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(835, 49);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(86, 34);
            this.BtnAgregar.TabIndex = 3;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Libros agregados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LbLibros
            // 
            this.LbLibros.FormattingEnabled = true;
            this.LbLibros.ItemHeight = 20;
            this.LbLibros.Location = new System.Drawing.Point(611, 176);
            this.LbLibros.Name = "LbLibros";
            this.LbLibros.Size = new System.Drawing.Size(339, 224);
            this.LbLibros.TabIndex = 5;
            // 
            // LbCopia
            // 
            this.LbCopia.FormattingEnabled = true;
            this.LbCopia.ItemHeight = 20;
            this.LbCopia.Location = new System.Drawing.Point(81, 176);
            this.LbCopia.Name = "LbCopia";
            this.LbCopia.Size = new System.Drawing.Size(336, 224);
            this.LbCopia.TabIndex = 6;
            this.LbCopia.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Copiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnMover
            // 
            this.BtnMover.Location = new System.Drawing.Point(771, 110);
            this.BtnMover.Name = "BtnMover";
            this.BtnMover.Size = new System.Drawing.Size(93, 34);
            this.BtnMover.TabIndex = 8;
            this.BtnMover.Text = "Mover";
            this.BtnMover.UseVisualStyleBackColor = true;
            this.BtnMover.Click += new System.EventHandler(this.BtnMover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.BtnMover);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LbCopia);
            this.Controls.Add(this.LbLibros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TbTitulo);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Libros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbTitulo;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LbLibros;
        private System.Windows.Forms.ListBox LbCopia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnMover;
    }
}

