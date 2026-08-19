namespace Projeto01
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tituloCadastro = new Label();
            label2 = new Label();
            btnSobre = new Button();
            btnCad = new Button();
            BottomToolStripPanel = new ToolStripPanel();
            TopToolStripPanel = new ToolStripPanel();
            RightToolStripPanel = new ToolStripPanel();
            LeftToolStripPanel = new ToolStripPanel();
            ContentPanel = new ToolStripContentPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(24, 53);
            label1.Name = "label1";
            label1.Size = new Size(497, 92);
            label1.TabIndex = 24;
            label1.Text = "Bem vindo(a)! Aqui você pode cadastrar pessoas com facilidade.\r\n\r\n\r\n\r\n";
            // 
            // tituloCadastro
            // 
            tituloCadastro.AutoSize = true;
            tituloCadastro.Font = new Font("Segoe UI", 13F);
            tituloCadastro.Location = new Point(24, 23);
            tituloCadastro.Name = "tituloCadastro";
            tituloCadastro.Size = new Size(192, 30);
            tituloCadastro.TabIndex = 23;
            tituloCadastro.Text = "Menu de Cadastro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(24, 130);
            label2.Name = "label2";
            label2.Size = new Size(372, 40);
            label2.TabIndex = 25;
            label2.Text = "Bom, para saber mais sobre o programa ou ir direto\r\npara as funções você pode prescionar os botõs abaixo:\r\n";
            // 
            // btnSobre
            // 
            btnSobre.Location = new Point(24, 229);
            btnSobre.Name = "btnSobre";
            btnSobre.Size = new Size(143, 29);
            btnSobre.TabIndex = 27;
            btnSobre.Text = "Sobre o Sistema";
            btnSobre.UseVisualStyleBackColor = true;
            // 
            // btnCad
            // 
            btnCad.Location = new Point(24, 194);
            btnCad.Name = "btnCad";
            btnCad.Size = new Size(148, 29);
            btnCad.TabIndex = 26;
            btnCad.Text = "Menu de Cadastro";
            btnCad.UseVisualStyleBackColor = true;
            btnCad.Click += btnCad_Click;
            // 
            // BottomToolStripPanel
            // 
            BottomToolStripPanel.Location = new Point(0, 0);
            BottomToolStripPanel.Name = "BottomToolStripPanel";
            BottomToolStripPanel.Orientation = Orientation.Horizontal;
            BottomToolStripPanel.RowMargin = new Padding(4, 0, 0, 0);
            BottomToolStripPanel.Size = new Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            TopToolStripPanel.Location = new Point(0, 0);
            TopToolStripPanel.Name = "TopToolStripPanel";
            TopToolStripPanel.Orientation = Orientation.Horizontal;
            TopToolStripPanel.RowMargin = new Padding(4, 0, 0, 0);
            TopToolStripPanel.Size = new Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            RightToolStripPanel.Location = new Point(0, 0);
            RightToolStripPanel.Name = "RightToolStripPanel";
            RightToolStripPanel.Orientation = Orientation.Horizontal;
            RightToolStripPanel.RowMargin = new Padding(4, 0, 0, 0);
            RightToolStripPanel.Size = new Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            LeftToolStripPanel.Location = new Point(0, 0);
            LeftToolStripPanel.Name = "LeftToolStripPanel";
            LeftToolStripPanel.Orientation = Orientation.Horizontal;
            LeftToolStripPanel.RowMargin = new Padding(4, 0, 0, 0);
            LeftToolStripPanel.Size = new Size(0, 0);
            // 
            // ContentPanel
            // 
            ContentPanel.Size = new Size(163, 96);
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(btnSobre);
            Controls.Add(btnCad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tituloCadastro);
            Margin = new Padding(2);
            Name = "frmPrincipal";
            Text = "Página Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label tituloCadastro;
        private Label label2;
        private Button btnSobre;
        private Button btnCad;
        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
    }
}
