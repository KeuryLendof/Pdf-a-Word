namespace Pdf_a_Word
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtArchivoOrigen = new System.Windows.Forms.TextBox();
            this.btnArchivoOrigen = new Guna.UI.WinForms.GunaButton();
            this.btnCarpetaDestino = new Guna.UI.WinForms.GunaButton();
            this.btnConvertirWord = new Guna.UI.WinForms.GunaButton();
            this.txtCarpetaDestino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archivo Origen :";
            // 
            // txtArchivoOrigen
            // 
            this.txtArchivoOrigen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchivoOrigen.Location = new System.Drawing.Point(15, 53);
            this.txtArchivoOrigen.Name = "txtArchivoOrigen";
            this.txtArchivoOrigen.Size = new System.Drawing.Size(279, 27);
            this.txtArchivoOrigen.TabIndex = 1;
            // 
            // btnArchivoOrigen
            // 
            this.btnArchivoOrigen.AnimationHoverSpeed = 0.07F;
            this.btnArchivoOrigen.AnimationSpeed = 0.03F;
            this.btnArchivoOrigen.BaseColor = System.Drawing.SystemColors.Control;
            this.btnArchivoOrigen.BorderColor = System.Drawing.Color.Black;
            this.btnArchivoOrigen.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnArchivoOrigen.FocusedColor = System.Drawing.Color.Empty;
            this.btnArchivoOrigen.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchivoOrigen.ForeColor = System.Drawing.Color.Black;
            this.btnArchivoOrigen.Image = ((System.Drawing.Image)(resources.GetObject("btnArchivoOrigen.Image")));
            this.btnArchivoOrigen.ImageSize = new System.Drawing.Size(20, 20);
            this.btnArchivoOrigen.Location = new System.Drawing.Point(324, 53);
            this.btnArchivoOrigen.Name = "btnArchivoOrigen";
            this.btnArchivoOrigen.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnArchivoOrigen.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnArchivoOrigen.OnHoverForeColor = System.Drawing.Color.White;
            this.btnArchivoOrigen.OnHoverImage = null;
            this.btnArchivoOrigen.OnPressedColor = System.Drawing.Color.Black;
            this.btnArchivoOrigen.Size = new System.Drawing.Size(160, 37);
            this.btnArchivoOrigen.TabIndex = 2;
            this.btnArchivoOrigen.Text = "Elegir Archivo";
            this.btnArchivoOrigen.Click += new System.EventHandler(this.btnArchivoOrigen_Click);
            // 
            // btnCarpetaDestino
            // 
            this.btnCarpetaDestino.AnimationHoverSpeed = 0.07F;
            this.btnCarpetaDestino.AnimationSpeed = 0.03F;
            this.btnCarpetaDestino.BaseColor = System.Drawing.SystemColors.Control;
            this.btnCarpetaDestino.BorderColor = System.Drawing.Color.Black;
            this.btnCarpetaDestino.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCarpetaDestino.FocusedColor = System.Drawing.Color.Empty;
            this.btnCarpetaDestino.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarpetaDestino.ForeColor = System.Drawing.Color.Black;
            this.btnCarpetaDestino.Image = ((System.Drawing.Image)(resources.GetObject("btnCarpetaDestino.Image")));
            this.btnCarpetaDestino.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCarpetaDestino.Location = new System.Drawing.Point(324, 100);
            this.btnCarpetaDestino.Name = "btnCarpetaDestino";
            this.btnCarpetaDestino.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCarpetaDestino.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCarpetaDestino.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCarpetaDestino.OnHoverImage = null;
            this.btnCarpetaDestino.OnPressedColor = System.Drawing.Color.Black;
            this.btnCarpetaDestino.Size = new System.Drawing.Size(160, 37);
            this.btnCarpetaDestino.TabIndex = 5;
            this.btnCarpetaDestino.Text = "Carpeta Destino";
            this.btnCarpetaDestino.Click += new System.EventHandler(this.btnCarpetaDestino_Click);
            // 
            // btnConvertirWord
            // 
            this.btnConvertirWord.AnimationHoverSpeed = 0.07F;
            this.btnConvertirWord.AnimationSpeed = 0.03F;
            this.btnConvertirWord.BaseColor = System.Drawing.SystemColors.Control;
            this.btnConvertirWord.BorderColor = System.Drawing.Color.Black;
            this.btnConvertirWord.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConvertirWord.FocusedColor = System.Drawing.Color.Empty;
            this.btnConvertirWord.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirWord.ForeColor = System.Drawing.Color.Black;
            this.btnConvertirWord.Image = ((System.Drawing.Image)(resources.GetObject("btnConvertirWord.Image")));
            this.btnConvertirWord.ImageSize = new System.Drawing.Size(20, 20);
            this.btnConvertirWord.Location = new System.Drawing.Point(58, 162);
            this.btnConvertirWord.Name = "btnConvertirWord";
            this.btnConvertirWord.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnConvertirWord.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConvertirWord.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConvertirWord.OnHoverImage = null;
            this.btnConvertirWord.OnPressedColor = System.Drawing.Color.Black;
            this.btnConvertirWord.Size = new System.Drawing.Size(178, 39);
            this.btnConvertirWord.TabIndex = 6;
            this.btnConvertirWord.Text = "Convertir A Word";
            this.btnConvertirWord.Click += new System.EventHandler(this.btnConvertirWord_Click);
            // 
            // txtCarpetaDestino
            // 
            this.txtCarpetaDestino.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarpetaDestino.Location = new System.Drawing.Point(15, 110);
            this.txtCarpetaDestino.Name = "txtCarpetaDestino";
            this.txtCarpetaDestino.Size = new System.Drawing.Size(279, 27);
            this.txtCarpetaDestino.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Carpeta Destino :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(611, 278);
            this.Controls.Add(this.txtCarpetaDestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConvertirWord);
            this.Controls.Add(this.btnCarpetaDestino);
            this.Controls.Add(this.btnArchivoOrigen);
            this.Controls.Add(this.txtArchivoOrigen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArchivoOrigen;
        private Guna.UI.WinForms.GunaButton btnArchivoOrigen;
        private Guna.UI.WinForms.GunaButton btnCarpetaDestino;
        private Guna.UI.WinForms.GunaButton btnConvertirWord;
        private System.Windows.Forms.TextBox txtCarpetaDestino;
        private System.Windows.Forms.Label label2;
    }
}

