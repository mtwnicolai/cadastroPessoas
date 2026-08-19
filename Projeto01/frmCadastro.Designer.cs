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
            btnFechar = new Button();
            dtNascTitulo = new Label();
            telTitulo = new Label();
            emailTitulo = new Label();
            dataNascBox = new TextBox();
            telBox = new TextBox();
            emailBox = new TextBox();
            tituloCadastro = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            cidTitulo = new Label();
            EstadoTitulo = new Label();
            cepTitulo = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            numTitulo = new Label();
            bairroTitulo = new Label();
            logTitulo = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label2 = new Label();
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
            listaPessoas.Size = new Size(738, 140);
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
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(694, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(94, 29);
            btnFechar.TabIndex = 14;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
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
            label1.Size = new Size(258, 23);
            label1.TabIndex = 22;
            label1.Text = "Aqui você pode cadastr pessoas!";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(398, 163);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 27);
            textBox1.TabIndex = 28;
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
            // EstadoTitulo
            // 
            EstadoTitulo.AutoSize = true;
            EstadoTitulo.Location = new Point(333, 136);
            EstadoTitulo.Name = "EstadoTitulo";
            EstadoTitulo.Size = new Size(57, 20);
            EstadoTitulo.TabIndex = 26;
            EstadoTitulo.Text = "Estado:";
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
            // textBox2
            // 
            textBox2.Location = new Point(375, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(181, 27);
            textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(392, 133);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(164, 27);
            textBox3.TabIndex = 23;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(405, 253);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(151, 27);
            textBox4.TabIndex = 34;
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
            // textBox5
            // 
            textBox5.Location = new Point(429, 192);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(127, 27);
            textBox5.TabIndex = 30;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(392, 221);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(164, 27);
            textBox6.TabIndex = 29;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(578, 160);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(194, 53);
            textBox7.TabIndex = 36;
            //textBox7.TextChanged += textBox7_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(578, 130);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 35;
            label2.Text = "Complemento:";
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox7);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(numTitulo);
            Controls.Add(bairroTitulo);
            Controls.Add(logTitulo);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox1);
            Controls.Add(cidTitulo);
            Controls.Add(EstadoTitulo);
            Controls.Add(cepTitulo);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(tituloCadastro);
            Controls.Add(emailBox);
            Controls.Add(telBox);
            Controls.Add(dataNascBox);
            Controls.Add(emailTitulo);
            Controls.Add(telTitulo);
            Controls.Add(dtNascTitulo);
            Controls.Add(btnFechar);
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
        private Button btnFechar;
        private Label dtNascTitulo;
        private Label telTitulo;
        private Label emailTitulo;
        private TextBox dataNascBox;
        private TextBox telBox;
        private TextBox emailBox;
        private Label tituloCadastro;
        private Label label1;
        private TextBox textBox1;
        private Label cidTitulo;
        private Label EstadoTitulo;
        private Label cepTitulo;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label numTitulo;
        private Label bairroTitulo;
        private Label logTitulo;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label2;
    }
}