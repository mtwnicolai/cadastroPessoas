namespace Projeto01
{
    partial class frmCadastro
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
            btnCad = new Button();
            nomeBox = new TextBox();
            idadeBox = new TextBox();
            cpfBox = new TextBox();
            tituloCPF = new Label();
            tituloNome = new Label();
            tituloIdade = new Label();
            funcaoBox = new TextBox();
            setorBox = new TextBox();
            tituloFuncao = new Label();
            tituloSetor = new Label();
            listaPessoas = new ListView();
            btnLimpar = new Button();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // btnCad
            // 
            btnCad.Location = new Point(50, 64);
            btnCad.Name = "btnCad";
            btnCad.Size = new Size(94, 29);
            btnCad.TabIndex = 0;
            btnCad.Text = "Cadastrar";
            btnCad.UseVisualStyleBackColor = true;
            btnCad.Click += btnCad_Click;
            // 
            // nomeBox
            // 
            nomeBox.Location = new Point(301, 125);
            nomeBox.Name = "nomeBox";
            nomeBox.Size = new Size(125, 27);
            nomeBox.TabIndex = 2;
            // 
            // idadeBox
            // 
            idadeBox.Location = new Point(457, 64);
            idadeBox.Name = "idadeBox";
            idadeBox.Size = new Size(125, 27);
            idadeBox.TabIndex = 3;
            // 
            // cpfBox
            // 
            cpfBox.Location = new Point(302, 64);
            cpfBox.Name = "cpfBox";
            cpfBox.Size = new Size(125, 27);
            cpfBox.TabIndex = 4;
            // 
            // tituloCPF
            // 
            tituloCPF.AutoSize = true;
            tituloCPF.Location = new Point(301, 39);
            tituloCPF.Name = "tituloCPF";
            tituloCPF.Size = new Size(36, 20);
            tituloCPF.TabIndex = 5;
            tituloCPF.Text = "CPF:";
            // 
            // tituloNome
            // 
            tituloNome.AutoSize = true;
            tituloNome.Location = new Point(301, 102);
            tituloNome.Name = "tituloNome";
            tituloNome.Size = new Size(53, 20);
            tituloNome.TabIndex = 6;
            tituloNome.Text = "Nome:";
            // 
            // tituloIdade
            // 
            tituloIdade.AutoSize = true;
            tituloIdade.Location = new Point(457, 39);
            tituloIdade.Name = "tituloIdade";
            tituloIdade.Size = new Size(50, 20);
            tituloIdade.TabIndex = 7;
            tituloIdade.Text = "Idade:";
            // 
            // funcaoBox
            // 
            funcaoBox.Location = new Point(457, 125);
            funcaoBox.Name = "funcaoBox";
            funcaoBox.Size = new Size(125, 27);
            funcaoBox.TabIndex = 8;
            // 
            // setorBox
            // 
            setorBox.Location = new Point(629, 95);
            setorBox.Name = "setorBox";
            setorBox.Size = new Size(125, 27);
            setorBox.TabIndex = 9;
            // 
            // tituloFuncao
            // 
            tituloFuncao.AutoSize = true;
            tituloFuncao.Location = new Point(457, 102);
            tituloFuncao.Name = "tituloFuncao";
            tituloFuncao.Size = new Size(59, 20);
            tituloFuncao.TabIndex = 10;
            tituloFuncao.Text = "Função:";
            // 
            // tituloSetor
            // 
            tituloSetor.AutoSize = true;
            tituloSetor.Location = new Point(629, 64);
            tituloSetor.Name = "tituloSetor";
            tituloSetor.Size = new Size(47, 20);
            tituloSetor.TabIndex = 11;
            tituloSetor.Text = "Setor:";
            // 
            // listaPessoas
            // 
            listaPessoas.Location = new Point(31, 224);
            listaPessoas.Name = "listaPessoas";
            listaPessoas.Size = new Size(738, 152);
            listaPessoas.TabIndex = 12;
            listaPessoas.UseCompatibleStateImageBehavior = false;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(50, 113);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(694, 409);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(94, 29);
            btnFechar.TabIndex = 14;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFechar);
            Controls.Add(btnLimpar);
            Controls.Add(listaPessoas);
            Controls.Add(tituloSetor);
            Controls.Add(tituloFuncao);
            Controls.Add(setorBox);
            Controls.Add(funcaoBox);
            Controls.Add(tituloIdade);
            Controls.Add(tituloNome);
            Controls.Add(tituloCPF);
            Controls.Add(cpfBox);
            Controls.Add(idadeBox);
            Controls.Add(nomeBox);
            Controls.Add(btnCad);
            Name = "frmCadastro";
            Text = "Cadastro de Pessoas";
            //Load += frmCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCad;
        private TextBox nomeBox;
        private TextBox idadeBox;
        private TextBox cpfBox;
        private Label tituloCPF;
        private Label tituloNome;
        private Label tituloIdade;
        private TextBox funcaoBox;
        private TextBox setorBox;
        private Label tituloFuncao;
        private Label tituloSetor;
        private ListView listaPessoas;
        private Button btnLimpar;
        private Button btnFechar;
    }
}