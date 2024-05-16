namespace pryCoseaniAndres
{
    partial class frmUsuario
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
            btnEmpezar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // btnEmpezar
            // 
            btnEmpezar.Location = new Point(83, 142);
            btnEmpezar.Name = "btnEmpezar";
            btnEmpezar.Size = new Size(164, 57);
            btnEmpezar.TabIndex = 0;
            btnEmpezar.Text = "Comenzar";
            btnEmpezar.UseVisualStyleBackColor = true;
            btnEmpezar.Click += btnEmpezar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(61, 41);
            label1.Name = "label1";
            label1.Size = new Size(124, 19);
            label1.TabIndex = 1;
            label1.Text = "Ingrese su nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(73, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(176, 23);
            txtNombre.TabIndex = 2;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(336, 242);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnEmpezar);
            Name = "frmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEmpezar;
        private Label label1;
        private TextBox txtNombre;
    }
}