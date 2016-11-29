namespace Nomina
{
    partial class Form1
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
            this.lbl_sala = new System.Windows.Forms.Label();
            this.btn_calc_edad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.lbl_fecha_nac = new System.Windows.Forms.Label();
            this.pic_foto = new System.Windows.Forms.PictureBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_fecha_nac = new System.Windows.Forms.TextBox();
            this.lbl_sala2 = new System.Windows.Forms.Label();
            this.txt_salario = new System.Windows.Forms.TextBox();
            this.lbl_calculos = new System.Windows.Forms.Label();
            this.txt_calc_edad = new System.Windows.Forms.TextBox();
            this.txt_calc_anti = new System.Windows.Forms.TextBox();
            this.btn_calc_anti = new System.Windows.Forms.Button();
            this.btn_crear = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_imp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.lbl_cedula = new System.Windows.Forms.Label();
            this.lbl_estatus = new System.Windows.Forms.Label();
            this.cmb_sexo = new System.Windows.Forms.ComboBox();
            this.cmb_estatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_sala
            // 
            this.lbl_sala.AutoSize = true;
            this.lbl_sala.Location = new System.Drawing.Point(27, 213);
            this.lbl_sala.Name = "lbl_sala";
            this.lbl_sala.Size = new System.Drawing.Size(39, 13);
            this.lbl_sala.TabIndex = 0;
            this.lbl_sala.Text = "Salario";
            // 
            // btn_calc_edad
            // 
            this.btn_calc_edad.Location = new System.Drawing.Point(384, 290);
            this.btn_calc_edad.Name = "btn_calc_edad";
            this.btn_calc_edad.Size = new System.Drawing.Size(119, 23);
            this.btn_calc_edad.TabIndex = 1;
            this.btn_calc_edad.Text = "Calcular Edad";
            this.btn_calc_edad.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datos Generales";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(31, 43);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 3;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(31, 71);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(47, 13);
            this.lbl_apellido.TabIndex = 4;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Location = new System.Drawing.Point(31, 99);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(31, 13);
            this.lbl_sexo.TabIndex = 5;
            this.lbl_sexo.Text = "Sexo";
            // 
            // lbl_fecha_nac
            // 
            this.lbl_fecha_nac.AutoSize = true;
            this.lbl_fecha_nac.Location = new System.Drawing.Point(31, 128);
            this.lbl_fecha_nac.Name = "lbl_fecha_nac";
            this.lbl_fecha_nac.Size = new System.Drawing.Size(111, 13);
            this.lbl_fecha_nac.TabIndex = 6;
            this.lbl_fecha_nac.Text = "Fecha de Nacimiento ";
            // 
            // pic_foto
            // 
            this.pic_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_foto.Location = new System.Drawing.Point(401, 7);
            this.pic_foto.Name = "pic_foto";
            this.pic_foto.Size = new System.Drawing.Size(146, 138);
            this.pic_foto.TabIndex = 7;
            this.pic_foto.TabStop = false;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(148, 40);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(230, 20);
            this.txt_nombre.TabIndex = 8;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(148, 68);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(230, 20);
            this.txt_apellido.TabIndex = 9;
            // 
            // txt_fecha_nac
            // 
            this.txt_fecha_nac.Location = new System.Drawing.Point(148, 125);
            this.txt_fecha_nac.Name = "txt_fecha_nac";
            this.txt_fecha_nac.Size = new System.Drawing.Size(230, 20);
            this.txt_fecha_nac.TabIndex = 11;
            // 
            // lbl_sala2
            // 
            this.lbl_sala2.AutoSize = true;
            this.lbl_sala2.Location = new System.Drawing.Point(145, 224);
            this.lbl_sala2.Name = "lbl_sala2";
            this.lbl_sala2.Size = new System.Drawing.Size(42, 13);
            this.lbl_sala2.TabIndex = 12;
            this.lbl_sala2.Text = "Salario:";
            // 
            // txt_salario
            // 
            this.txt_salario.Location = new System.Drawing.Point(190, 221);
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(188, 20);
            this.txt_salario.TabIndex = 13;
            // 
            // lbl_calculos
            // 
            this.lbl_calculos.AutoSize = true;
            this.lbl_calculos.Location = new System.Drawing.Point(27, 272);
            this.lbl_calculos.Name = "lbl_calculos";
            this.lbl_calculos.Size = new System.Drawing.Size(47, 13);
            this.lbl_calculos.TabIndex = 14;
            this.lbl_calculos.Text = "Cálculos";
            // 
            // txt_calc_edad
            // 
            this.txt_calc_edad.Location = new System.Drawing.Point(148, 293);
            this.txt_calc_edad.Name = "txt_calc_edad";
            this.txt_calc_edad.Size = new System.Drawing.Size(230, 20);
            this.txt_calc_edad.TabIndex = 15;
            // 
            // txt_calc_anti
            // 
            this.txt_calc_anti.Location = new System.Drawing.Point(148, 319);
            this.txt_calc_anti.Name = "txt_calc_anti";
            this.txt_calc_anti.Size = new System.Drawing.Size(230, 20);
            this.txt_calc_anti.TabIndex = 16;
            // 
            // btn_calc_anti
            // 
            this.btn_calc_anti.Location = new System.Drawing.Point(384, 317);
            this.btn_calc_anti.Name = "btn_calc_anti";
            this.btn_calc_anti.Size = new System.Drawing.Size(119, 23);
            this.btn_calc_anti.TabIndex = 17;
            this.btn_calc_anti.Text = "Calcular Antiguedad";
            this.btn_calc_anti.UseVisualStyleBackColor = true;
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(30, 383);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(75, 23);
            this.btn_crear.TabIndex = 18;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(110, 383);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 19;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(191, 383);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(75, 23);
            this.btn_borrar.TabIndex = 20;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_imp
            // 
            this.btn_imp.Location = new System.Drawing.Point(272, 383);
            this.btn_imp.Name = "btn_imp";
            this.btn_imp.Size = new System.Drawing.Size(75, 23);
            this.btn_imp.TabIndex = 21;
            this.btn_imp.Text = "Imprimir";
            this.btn_imp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mensaje";
            // 
            // txt_cedula
            // 
            this.txt_cedula.Location = new System.Drawing.Point(148, 151);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(118, 20);
            this.txt_cedula.TabIndex = 23;
            // 
            // lbl_cedula
            // 
            this.lbl_cedula.AutoSize = true;
            this.lbl_cedula.Location = new System.Drawing.Point(31, 154);
            this.lbl_cedula.Name = "lbl_cedula";
            this.lbl_cedula.Size = new System.Drawing.Size(40, 13);
            this.lbl_cedula.TabIndex = 24;
            this.lbl_cedula.Text = "Cédula";
            // 
            // lbl_estatus
            // 
            this.lbl_estatus.AutoSize = true;
            this.lbl_estatus.Location = new System.Drawing.Point(31, 181);
            this.lbl_estatus.Name = "lbl_estatus";
            this.lbl_estatus.Size = new System.Drawing.Size(37, 13);
            this.lbl_estatus.TabIndex = 25;
            this.lbl_estatus.Text = "Activo";
            // 
            // cmb_sexo
            // 
            this.cmb_sexo.FormattingEnabled = true;
            this.cmb_sexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cmb_sexo.Location = new System.Drawing.Point(148, 96);
            this.cmb_sexo.Name = "cmb_sexo";
            this.cmb_sexo.Size = new System.Drawing.Size(121, 21);
            this.cmb_sexo.TabIndex = 27;
            // 
            // cmb_estatus
            // 
            this.cmb_estatus.FormattingEnabled = true;
            this.cmb_estatus.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmb_estatus.Location = new System.Drawing.Point(148, 178);
            this.cmb_estatus.Name = "cmb_estatus";
            this.cmb_estatus.Size = new System.Drawing.Size(61, 21);
            this.cmb_estatus.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 433);
            this.Controls.Add(this.cmb_estatus);
            this.Controls.Add(this.cmb_sexo);
            this.Controls.Add(this.lbl_estatus);
            this.Controls.Add(this.lbl_cedula);
            this.Controls.Add(this.txt_cedula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_imp);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.btn_calc_anti);
            this.Controls.Add(this.txt_calc_anti);
            this.Controls.Add(this.txt_calc_edad);
            this.Controls.Add(this.lbl_calculos);
            this.Controls.Add(this.txt_salario);
            this.Controls.Add(this.lbl_sala2);
            this.Controls.Add(this.txt_fecha_nac);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.pic_foto);
            this.Controls.Add(this.lbl_fecha_nac);
            this.Controls.Add(this.lbl_sexo);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_calc_edad);
            this.Controls.Add(this.lbl_sala);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sala;
        private System.Windows.Forms.Button btn_calc_edad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.Label lbl_fecha_nac;
        private System.Windows.Forms.PictureBox pic_foto;
        private System.Windows.Forms.Label lbl_sala2;
        private System.Windows.Forms.Label lbl_calculos;
        private System.Windows.Forms.TextBox txt_calc_edad;
        private System.Windows.Forms.TextBox txt_calc_anti;
        private System.Windows.Forms.Button btn_calc_anti;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_imp;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_fecha_nac;
        private System.Windows.Forms.TextBox txt_salario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.Label lbl_cedula;
        private System.Windows.Forms.Label lbl_estatus;
        private System.Windows.Forms.ComboBox cmb_sexo;
        private System.Windows.Forms.ComboBox cmb_estatus;
    }
}

