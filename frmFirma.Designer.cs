namespace ProyectoCoseaniAndres
{
    partial class frmFirma
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
            picFirma = new PictureBox();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)picFirma).BeginInit();
            SuspendLayout();
            // 
            // picFirma
            // 
            picFirma.Location = new Point(13, 13);
            picFirma.Name = "picFirma";
            picFirma.Size = new Size(772, 388);
            picFirma.TabIndex = 0;
            picFirma.TabStop = false;
            picFirma.MouseMove += picFirma_MouseMove;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(356, 407);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(111, 31);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmFirma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(picFirma);
            Name = "frmFirma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFirma";
            ((System.ComponentModel.ISupportInitialize)picFirma).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picFirma;
        private Button btnGuardar;
    }
}