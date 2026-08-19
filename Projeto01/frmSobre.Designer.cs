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
            tituloSobre = new Label();
            p1Sobre = new Label();
            btnFecharSobre = new Button();
            SuspendLayout();
            // 
            // tituloSobre
            // 
            tituloSobre.AutoSize = true;
            tituloSobre.Font = new Font("Segoe UI", 13F);
            tituloSobre.Location = new Point(12, 65);
            tituloSobre.Name = "tituloSobre";
            tituloSobre.Size = new Size(173, 30);
            tituloSobre.TabIndex = 0;
            tituloSobre.Text = "Sobre o sistema:";
            // 
            // p1Sobre
            // 
            p1Sobre.AutoSize = true;
            p1Sobre.Font = new Font("Segoe UI", 9F);
            p1Sobre.Location = new Point(42, 137);
            p1Sobre.Name = "p1Sobre";
            p1Sobre.Size = new Size(450, 20);
            p1Sobre.TabIndex = 1;
            p1Sobre.Text = "- Sistema criado no intuito de aprendizagem de formulários no C#";
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
            // frmSobre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 308);
            Controls.Add(btnFecharSobre);
            Controls.Add(p1Sobre);
            Controls.Add(tituloSobre);
            Name = "frmSobre";
            Text = "Sobre o Sistema";
            Load += frmSobre_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloSobre;
        private Label p1Sobre;
        private Button btnFecharSobre;
    }
}