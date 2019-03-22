namespace ConsultaBD
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
            this.btnAgregarNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.dtView1 = new System.Windows.Forms.DataGridView();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.txtIdCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreContact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTituloContact = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.Fax = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCompaniModifi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarNuevo
            // 
            this.btnAgregarNuevo.Location = new System.Drawing.Point(23, 65);
            this.btnAgregarNuevo.Name = "btnAgregarNuevo";
            this.btnAgregarNuevo.Size = new System.Drawing.Size(112, 23);
            this.btnAgregarNuevo.TabIndex = 0;
            this.btnAgregarNuevo.Text = "Agregar Nuevo";
            this.btnAgregarNuevo.UseVisualStyleBackColor = true;
            this.btnAgregarNuevo.Click += new System.EventHandler(this.btnAgregarNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(23, 119);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(23, 176);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Modificar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(23, 235);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "CLIENTES";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.btnVer);
            this.groupBox1.Controls.Add(this.btnAgregarNuevo);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Location = new System.Drawing.Point(617, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 277);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(23, 19);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(112, 23);
            this.btnVer.TabIndex = 7;
            this.btnVer.Text = "Ver tabla";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.button5_Click);
            // 
            // dtView1
            // 
            this.dtView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtView1.Location = new System.Drawing.Point(12, 44);
            this.dtView1.Name = "dtView1";
            this.dtView1.Size = new System.Drawing.Size(582, 350);
            this.dtView1.TabIndex = 6;
            this.dtView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(25, 35);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(183, 20);
            this.txtDato.TabIndex = 7;
            this.txtDato.TextChanged += new System.EventHandler(this.txtDato_TextChanged);
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.Location = new System.Drawing.Point(12, 499);
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtIdCustomer.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Id Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre Contacto";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNombreContact
            // 
            this.txtNombreContact.Location = new System.Drawing.Point(160, 499);
            this.txtNombreContact.Name = "txtNombreContact";
            this.txtNombreContact.Size = new System.Drawing.Size(100, 20);
            this.txtNombreContact.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nombre Compañia";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(14, 561);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyName.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 542);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Titulo contacto";
            // 
            // txtTituloContact
            // 
            this.txtTituloContact.Location = new System.Drawing.Point(160, 561);
            this.txtTituloContact.Name = "txtTituloContact";
            this.txtTituloContact.Size = new System.Drawing.Size(100, 20);
            this.txtTituloContact.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Postal Code";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(328, 499);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCode.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 542);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(328, 561);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(468, 480);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(468, 499);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 20;
            // 
            // Fax
            // 
            this.Fax.AutoSize = true;
            this.Fax.Location = new System.Drawing.Point(468, 542);
            this.Fax.Name = "Fax";
            this.Fax.Size = new System.Drawing.Size(24, 13);
            this.Fax.TabIndex = 23;
            this.Fax.Text = "Fax";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(468, 561);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(100, 20);
            this.txtFax.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(608, 480);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(608, 499);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(608, 542);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(608, 561);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Id";
            this.label11.Click += new System.EventHandler(this.label11_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Nombre Compañia";
            // 
            // txtCompaniModifi
            // 
            this.txtCompaniModifi.Location = new System.Drawing.Point(25, 78);
            this.txtCompaniModifi.Name = "txtCompaniModifi";
            this.txtCompaniModifi.Size = new System.Drawing.Size(183, 20);
            this.txtCompaniModifi.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDato);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtCompaniModifi);
            this.groupBox2.Location = new System.Drawing.Point(599, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 130);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingresa para eliminar, buscar y modificar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(838, 597);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.Fax);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTituloContact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreContact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdCustomer);
            this.Controls.Add(this.dtView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtView1;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.TextBox txtIdCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreContact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTituloContact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label Fax;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCompaniModifi;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

