namespace Nomina
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rad_Id = new System.Windows.Forms.RadioButton();
            this.rad_Nom = new System.Windows.Forms.RadioButton();
            this.rad_Ape = new System.Windows.Forms.RadioButton();
            this.rad_Cedu = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(953, 359);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // rad_Id
            // 
            this.rad_Id.AutoSize = true;
            this.rad_Id.Location = new System.Drawing.Point(25, 23);
            this.rad_Id.Name = "rad_Id";
            this.rad_Id.Size = new System.Drawing.Size(34, 17);
            this.rad_Id.TabIndex = 1;
            this.rad_Id.TabStop = true;
            this.rad_Id.Text = "Id";
            this.rad_Id.UseVisualStyleBackColor = true;
            this.rad_Id.CheckedChanged += new System.EventHandler(this.rad_Id_CheckedChanged);
            // 
            // rad_Nom
            // 
            this.rad_Nom.AutoSize = true;
            this.rad_Nom.Location = new System.Drawing.Point(116, 23);
            this.rad_Nom.Name = "rad_Nom";
            this.rad_Nom.Size = new System.Drawing.Size(62, 17);
            this.rad_Nom.TabIndex = 2;
            this.rad_Nom.TabStop = true;
            this.rad_Nom.Text = "Nombre";
            this.rad_Nom.UseVisualStyleBackColor = true;
            // 
            // rad_Ape
            // 
            this.rad_Ape.AutoSize = true;
            this.rad_Ape.Location = new System.Drawing.Point(207, 23);
            this.rad_Ape.Name = "rad_Ape";
            this.rad_Ape.Size = new System.Drawing.Size(67, 17);
            this.rad_Ape.TabIndex = 3;
            this.rad_Ape.TabStop = true;
            this.rad_Ape.Text = "Apellidos";
            this.rad_Ape.UseVisualStyleBackColor = true;
            // 
            // rad_Cedu
            // 
            this.rad_Cedu.AutoSize = true;
            this.rad_Cedu.Location = new System.Drawing.Point(298, 23);
            this.rad_Cedu.Name = "rad_Cedu";
            this.rad_Cedu.Size = new System.Drawing.Size(58, 17);
            this.rad_Cedu.TabIndex = 4;
            this.rad_Cedu.TabStop = true;
            this.rad_Cedu.Text = "Cédula";
            this.rad_Cedu.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(375, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 5;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Image = global::Nomina.Properties.Resources._1479603303_document_16;
            this.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevo.Location = new System.Drawing.Point(727, 12);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(74, 42);
            this.btn_nuevo.TabIndex = 8;
            this.btn_nuevo.Text = "Crear";
            this.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Image = global::Nomina.Properties.Resources._1479603053_vector_66_15;
            this.btn_imprimir.Location = new System.Drawing.Point(675, 12);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(46, 42);
            this.btn_imprimir.TabIndex = 7;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = global::Nomina.Properties.Resources._1479603626_Gnome_Edit_Find_32;
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(584, 16);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(85, 31);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(375, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 20);
            this.textBox2.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 452);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rad_Cedu);
            this.Controls.Add(this.rad_Ape);
            this.Controls.Add(this.rad_Nom);
            this.Controls.Add(this.rad_Id);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rad_Id;
        private System.Windows.Forms.RadioButton rad_Nom;
        private System.Windows.Forms.RadioButton rad_Ape;
        private System.Windows.Forms.RadioButton rad_Cedu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.TextBox textBox2;
    }
}