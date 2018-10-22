namespace SegundoParcial.UI.Registros
{
    partial class rVendedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rVendedores));
            this.label6 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PorcRetencionnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RetencionnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SueldonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.NombrestextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PorcRetencionnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetencionnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SueldonumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Fecha";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(79, 196);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.FechadateTimePicker.TabIndex = 30;
            // 
            // PorcRetencionnumericUpDown
            // 
            this.PorcRetencionnumericUpDown.Location = new System.Drawing.Point(79, 125);
            this.PorcRetencionnumericUpDown.Name = "PorcRetencionnumericUpDown";
            this.PorcRetencionnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.PorcRetencionnumericUpDown.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Retencion %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Retencion";
            // 
            // RetencionnumericUpDown
            // 
            this.RetencionnumericUpDown.Location = new System.Drawing.Point(79, 160);
            this.RetencionnumericUpDown.Name = "RetencionnumericUpDown";
            this.RetencionnumericUpDown.ReadOnly = true;
            this.RetencionnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.RetencionnumericUpDown.TabIndex = 26;
            // 
            // SueldonumericUpDown
            // 
            this.SueldonumericUpDown.DecimalPlaces = 2;
            this.SueldonumericUpDown.Location = new System.Drawing.Point(79, 91);
            this.SueldonumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.SueldonumericUpDown.Name = "SueldonumericUpDown";
            this.SueldonumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.SueldonumericUpDown.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Sueldo";
            // 
            // NombrestextBox
            // 
            this.NombrestextBox.Location = new System.Drawing.Point(79, 56);
            this.NombrestextBox.Name = "NombrestextBox";
            this.NombrestextBox.Size = new System.Drawing.Size(261, 20);
            this.NombrestextBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(79, 12);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(74, 20);
            this.IDnumericUpDown.TabIndex = 20;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.Location = new System.Drawing.Point(276, 234);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(103, 50);
            this.Eliminarbutton.TabIndex = 19;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Eliminarbutton.UseVisualStyleBackColor = false;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.Location = new System.Drawing.Point(145, 234);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(103, 50);
            this.Guardarbutton.TabIndex = 18;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Guardarbutton.UseVisualStyleBackColor = false;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.Location = new System.Drawing.Point(17, 234);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(103, 50);
            this.Nuevobutton.TabIndex = 17;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Nuevobutton.UseVisualStyleBackColor = false;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Buscarbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.BackgroundImage")));
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.Location = new System.Drawing.Point(289, -2);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(103, 44);
            this.Buscarbutton.TabIndex = 16;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buscarbutton.UseVisualStyleBackColor = false;
            // 
            // rVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(467, 295);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.PorcRetencionnumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RetencionnumericUpDown);
            this.Controls.Add(this.SueldonumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombrestextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Name = "rVendedores";
            this.Text = "rVendedores";
            ((System.ComponentModel.ISupportInitialize)(this.PorcRetencionnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetencionnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SueldonumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.NumericUpDown PorcRetencionnumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown RetencionnumericUpDown;
        private System.Windows.Forms.NumericUpDown SueldonumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombrestextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
    }
}