namespace SegundoParcial.UI.Registros
{
    partial class rMetas
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
            this.components = new System.ComponentModel.Container();
            this.MetaID = new System.Windows.Forms.Label();
            this.MetaIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CuotaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MetaIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuotaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // MetaID
            // 
            this.MetaID.AutoSize = true;
            this.MetaID.Location = new System.Drawing.Point(12, 20);
            this.MetaID.Name = "MetaID";
            this.MetaID.Size = new System.Drawing.Size(45, 13);
            this.MetaID.TabIndex = 0;
            this.MetaID.Text = "Meta ID";
            // 
            // MetaIDNumericUpDown
            // 
            this.MetaIDNumericUpDown.Location = new System.Drawing.Point(91, 18);
            this.MetaIDNumericUpDown.Name = "MetaIDNumericUpDown";
            this.MetaIDNumericUpDown.Size = new System.Drawing.Size(72, 20);
            this.MetaIDNumericUpDown.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descripcion";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(91, 54);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(219, 20);
            this.DescripcionTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cuota";
            // 
            // CuotaNumericUpDown
            // 
            this.CuotaNumericUpDown.Location = new System.Drawing.Point(91, 90);
            this.CuotaNumericUpDown.Name = "CuotaNumericUpDown";
            this.CuotaNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.CuotaNumericUpDown.TabIndex = 5;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GuardarButton.Location = new System.Drawing.Point(104, 140);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(119, 35);
            this.GuardarButton.TabIndex = 6;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rMetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(388, 192);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.CuotaNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MetaIDNumericUpDown);
            this.Controls.Add(this.MetaID);
            this.Name = "rMetas";
            this.Text = "rCuota";
            ((System.ComponentModel.ISupportInitialize)(this.MetaIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuotaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MetaID;
        private System.Windows.Forms.NumericUpDown MetaIDNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown CuotaNumericUpDown;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}