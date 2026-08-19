namespace Projeto01
{
    partial class frmSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSobre));
            btnFecharSobre = new Button();
            desSobre = new Label();
            tituloSobre = new Label();
            SuspendLayout();
            // 
            // btnFecharSobre
            // 
            btnFecharSobre.Location = new Point(454, 255);
            btnFecharSobre.Name = "btnFecharSobre";
            btnFecharSobre.Size = new Size(94, 29);
            btnFecharSobre.TabIndex = 2;
            btnFecharSobre.Text = "Fechar";
            btnFecharSobre.UseVisualStyleBackColor = true;
            btnFecharSobre.Click += btnFecharSobre_Click;
            // 
            // desSobre
            // 
            desSobre.AutoSize = true;
            desSobre.Font = new Font("Segoe UI", 9F);
            desSobre.Location = new Point(12, 80);
            desSobre.Name = "desSobre";
            desSobre.Size = new Size(552, 120);
            desSobre.TabIndex = 28;
            desSobre.Text = resources.GetString("desSobre.Text");
            // 
            // tituloSobre
            // 
            tituloSobre.AutoSize = true;
            tituloSobre.Font = new Font("Segoe UI", 13F);
            tituloSobre.Location = new Point(12, 20);
            tituloSobre.Name = "tituloSobre";
            tituloSobre.Size = new Size(192, 30);
            tituloSobre.TabIndex = 26;
            tituloSobre.Text = "Menu de Cadastro";
            // 
            // frmSobre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 308);
            Controls.Add(desSobre);
            Controls.Add(tituloSobre);
            Controls.Add(btnFecharSobre);
            Name = "frmSobre";
            Text = "Sobre o Sistema";
            Load += frmSobre_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnFecharSobre;
        private Label desSobre;
        private Label tituloSobre;
    }
}