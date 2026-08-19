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
            cpfBox = new TextBox();
            tituloCPF = new Label();
            tituloNome = new Label();
            listaPessoas = new ListView();
            btnLimpar = new Button();
            dtNascTitulo = new Label();
            telTitulo = new Label();
            emailTitulo = new Label();
            dataNascBox = new TextBox();
            telBox = new TextBox();
            emailBox = new TextBox();
            tituloCadastro = new Label();
            label1 = new Label();
            cidadeBox = new TextBox();
            cidTitulo = new Label();
            estadoTitulo = new Label();
            cepTitulo = new Label();
            cepBox = new TextBox();
            estadoBox = new TextBox();
            numBox = new TextBox();
            numTitulo = new Label();
            bairroTitulo = new Label();
            logTitulo = new Label();
            lograBox = new TextBox();
            bairroBox = new TextBox();
            compleBox = new TextBox();
            compleTitulo = new Label();
            listaEnde = new ListView();
            SuspendLayout();
            // 
            // btnCad
            // 
            btnCad.Location = new Point(578, 227);
            btnCad.Name = "btnCad";
            btnCad.Size = new Size(94, 29);
            btnCad.TabIndex = 0;
            btnCad.Text = "Cadastrar";
            btnCad.UseVisualStyleBackColor = true;
            btnCad.Click += btnCad_Click;
            // 
            // nomeBox
            // 
            nomeBox.Location = new Point(90, 147);
            nomeBox.Name = "nomeBox";
            nomeBox.Size = new Size(178, 27);
            nomeBox.TabIndex = 2;
            // 
            // cpfBox
            // 
            cpfBox.Location = new Point(73, 114);
            cpfBox.Name = "cpfBox";
            cpfBox.Size = new Size(195, 27);
            cpfBox.TabIndex = 4;
            // 
            // tituloCPF
            // 
            tituloCPF.AutoSize = true;
            tituloCPF.Location = new Point(31, 121);
            tituloCPF.Name = "tituloCPF";
            tituloCPF.Size = new Size(36, 20);
            tituloCPF.TabIndex = 5;
            tituloCPF.Text = "CPF:";
            tituloCPF.Click += tituloCPF_Click;
            // 
            // tituloNome
            // 
            tituloNome.AutoSize = true;
            tituloNome.Location = new Point(31, 150);
            tituloNome.Name = "tituloNome";
            tituloNome.Size = new Size(53, 20);
            tituloNome.TabIndex = 6;
            tituloNome.Text = "Nome:";
            // 
            // listaPessoas
            // 
            listaPessoas.Location = new Point(31, 298);
            listaPessoas.Name = "listaPessoas";
            listaPessoas.Size = new Size(368, 140);
            listaPessoas.TabIndex = 12;
            listaPessoas.UseCompatibleStateImageBehavior = false;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(678, 227);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click_1;
            // 
            // dtNascTitulo
            // 
            dtNascTitulo.AutoSize = true;
            dtNascTitulo.Location = new Point(31, 180);
            dtNascTitulo.Name = "dtNascTitulo";
            dtNascTitulo.Size = new Size(148, 20);
            dtNascTitulo.TabIndex = 15;
            dtNascTitulo.Text = "Data de Nascimento:";
            // 
            // telTitulo
            // 
            telTitulo.AutoSize = true;
            telTitulo.Location = new Point(31, 209);
            telTitulo.Name = "telTitulo";
            telTitulo.Size = new Size(69, 20);
            telTitulo.TabIndex = 16;
            telTitulo.Text = "Telefone:";
            // 
            // emailTitulo
            // 
            emailTitulo.AutoSize = true;
            emailTitulo.Location = new Point(31, 242);
            emailTitulo.Name = "emailTitulo";
            emailTitulo.Size = new Size(55, 20);
            emailTitulo.TabIndex = 17;
            emailTitulo.Text = "E-Mail:";
            // 
            // dataNascBox
            // 
            dataNascBox.Location = new Point(185, 178);
            dataNascBox.Name = "dataNascBox";
            dataNascBox.Size = new Size(125, 27);
            dataNascBox.TabIndex = 18;
            // 
            // telBox
            // 
            telBox.Location = new Point(105, 209);
            telBox.Name = "telBox";
            telBox.Size = new Size(163, 27);
            telBox.TabIndex = 19;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(92, 242);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(176, 27);
            emailBox.TabIndex = 20;
            // 
            // tituloCadastro
            // 
            tituloCadastro.AutoSize = true;
            tituloCadastro.Font = new Font("Segoe UI", 13F);
            tituloCadastro.Location = new Point(22, 23);
            tituloCadastro.Name = "tituloCadastro";
            tituloCadastro.Size = new Size(99, 30);
            tituloCadastro.TabIndex = 21;
            tituloCadastro.Text = "Cadastro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(22, 53);
            label1.Name = "label1";
            label1.Size = new Size(273, 23);
            label1.TabIndex = 22;
            label1.Text = "Aqui você pode cadastrar pessoas!";
            label1.Click += label1_Click;
            // 
            // cidadeBox
            // 
            cidadeBox.Location = new Point(398, 163);
            cidadeBox.Name = "cidadeBox";
            cidadeBox.Size = new Size(158, 27);
            cidadeBox.TabIndex = 28;
            // 
            // cidTitulo
            // 
            cidTitulo.AutoSize = true;
            cidTitulo.Location = new Point(333, 166);
            cidTitulo.Name = "cidTitulo";
            cidTitulo.Size = new Size(59, 20);
            cidTitulo.TabIndex = 27;
            cidTitulo.Text = "Cidade:";
            // 
            // estadoTitulo
            // 
            estadoTitulo.AutoSize = true;
            estadoTitulo.Location = new Point(333, 136);
            estadoTitulo.Name = "estadoTitulo";
            estadoTitulo.Size = new Size(57, 20);
            estadoTitulo.TabIndex = 26;
            estadoTitulo.Text = "Estado:";
            // 
            // cepTitulo
            // 
            cepTitulo.AutoSize = true;
            cepTitulo.Location = new Point(333, 107);
            cepTitulo.Name = "cepTitulo";
            cepTitulo.Size = new Size(37, 20);
            cepTitulo.TabIndex = 25;
            cepTitulo.Text = "CEP:";
            // 
            // cepBox
            // 
            cepBox.Location = new Point(375, 100);
            cepBox.Name = "cepBox";
            cepBox.Size = new Size(181, 27);
            cepBox.TabIndex = 24;
            // 
            // estadoBox
            // 
            estadoBox.Location = new Point(392, 133);
            estadoBox.Name = "estadoBox";
            estadoBox.Size = new Size(164, 27);
            estadoBox.TabIndex = 23;
            // 
            // numBox
            // 
            numBox.Location = new Point(405, 253);
            numBox.Name = "numBox";
            numBox.Size = new Size(151, 27);
            numBox.TabIndex = 34;
            // 
            // numTitulo
            // 
            numTitulo.AutoSize = true;
            numTitulo.Location = new Point(333, 254);
            numTitulo.Name = "numTitulo";
            numTitulo.Size = new Size(66, 20);
            numTitulo.TabIndex = 33;
            numTitulo.Text = "Número:";
            // 
            // bairroTitulo
            // 
            bairroTitulo.AutoSize = true;
            bairroTitulo.Location = new Point(333, 224);
            bairroTitulo.Name = "bairroTitulo";
            bairroTitulo.Size = new Size(52, 20);
            bairroTitulo.TabIndex = 32;
            bairroTitulo.Text = "Bairro:";
            // 
            // logTitulo
            // 
            logTitulo.AutoSize = true;
            logTitulo.Location = new Point(333, 195);
            logTitulo.Name = "logTitulo";
            logTitulo.Size = new Size(90, 20);
            logTitulo.TabIndex = 31;
            logTitulo.Text = "Logradouro:";
            // 
            // lograBox
            // 
            lograBox.Location = new Point(429, 192);
            lograBox.Name = "lograBox";
            lograBox.Size = new Size(127, 27);
            lograBox.TabIndex = 30;
            // 
            // bairroBox
            // 
            bairroBox.Location = new Point(392, 221);
            bairroBox.Name = "bairroBox";
            bairroBox.Size = new Size(164, 27);
            bairroBox.TabIndex = 29;
            // 
            // compleBox
            // 
            compleBox.Location = new Point(578, 160);
            compleBox.Multiline = true;
            compleBox.Name = "compleBox";
            compleBox.Size = new Size(194, 53);
            compleBox.TabIndex = 36;
            // 
            // compleTitulo
            // 
            compleTitulo.AutoSize = true;
            compleTitulo.Location = new Point(578, 130);
            compleTitulo.Name = "compleTitulo";
            compleTitulo.Size = new Size(107, 20);
            compleTitulo.TabIndex = 35;
            compleTitulo.Text = "Complemento:";
            // 
            // listaEnde
            // 
            listaEnde.Location = new Point(405, 298);
            listaEnde.Name = "listaEnde";
            listaEnde.Size = new Size(363, 140);
            listaEnde.TabIndex = 37;
            listaEnde.UseCompatibleStateImageBehavior = false;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listaEnde);
            Controls.Add(compleBox);
            Controls.Add(compleTitulo);
            Controls.Add(numBox);
            Controls.Add(numTitulo);
            Controls.Add(bairroTitulo);
            Controls.Add(logTitulo);
            Controls.Add(lograBox);
            Controls.Add(bairroBox);
            Controls.Add(cidadeBox);
            Controls.Add(cidTitulo);
            Controls.Add(estadoTitulo);
            Controls.Add(cepTitulo);
            Controls.Add(cepBox);
            Controls.Add(estadoBox);
            Controls.Add(label1);
            Controls.Add(tituloCadastro);
            Controls.Add(emailBox);
            Controls.Add(telBox);
            Controls.Add(dataNascBox);
            Controls.Add(emailTitulo);
            Controls.Add(telTitulo);
            Controls.Add(dtNascTitulo);
            Controls.Add(btnLimpar);
            Controls.Add(listaPessoas);
            Controls.Add(tituloNome);
            Controls.Add(tituloCPF);
            Controls.Add(cpfBox);
            Controls.Add(nomeBox);
            Controls.Add(btnCad);
            Name = "frmCadastro";
            Text = "Cadastro de Pessoas";
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
        private Label dtNascTitulo;
        private Label telTitulo;
        private Label emailTitulo;
        private TextBox dataNascBox;
        private TextBox telBox;
        private TextBox emailBox;
        private Label tituloCadastro;
        private Label label1;
        private TextBox cidadeBox;
        private Label cidTitulo;
        private Label estadoTitulo;
        private Label cepTitulo;
        private TextBox cepBox;
        private TextBox estadoBox;
        private TextBox numBox;
        private Label numTitulo;
        private Label bairroTitulo;
        private Label logTitulo;
        private TextBox lograBox;
        private TextBox bairroBox;
        private TextBox compleBox;
        private Label compleTitulo;
        private ListView listaEnde;
    }
}