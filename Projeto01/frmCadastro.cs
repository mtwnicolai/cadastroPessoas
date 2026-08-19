using Projeto01.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto01
{
    public partial class frmCadastro : Form
    {
        List<Pessoa> pessoas = new List<Pessoa>();
        public frmCadastro()
        {
            InitializeComponent();
            ConfigurarListView();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            Pessoa ps = new Pessoa();

            if (cpfBox.Text.Length < 11 || cpfBox.Text.Length > 11)
            {
                MessageBox.Show("Opa!", "Parece que tem algo de errado com seu cpf...");
            }
            else
            {
                ps.cpf = cpfBox.Text;
            }

            ps.nome = nomeBox.Text;
            ps.data = dataNascBox.Text;
            if (telBox.Text.Length < 11 || telBox.Text.Length > 11)
            {
                MessageBox.Show("Opa!", "Parece que seu telefone ta errado...");
            }
            else
            {
                ps.telephone = telBox.Text;
            }
            ps.email = emailBox.Text;
            Endereco end = new Endereco();
            if (cpfBox.Text.Length < 11 || cpfBox.Text.Length > 11)
            {
                MessageBox.Show("Opa!", "Parece que tem algo de errado com seu CPF...");
            }
            else
            {
                end.cpf = cpfBox.Text;
            }

            end.cep = cepBox.Text;
            if (cepBox.Text.Length < 8 || cepBox.Text.Length > 8)
            {
                MessageBox.Show("Opa!", "Parece que tem algo de errado com seu CEP...");
            }
            else
            {
                end.cep = cepBox.Text;
            }
            end.estado = estadoBox.Text;
            end.cidade = cidadeBox.Text;
            end.bairro = bairroBox.Text;
            end.logra = lograBox.Text;
            if (numBox.Text.Length < 5 || numBox.Text.Length > 5)
            {
                MessageBox.Show("Opa!", "Parece que tem algo de errado com seu número...");
            }
            else
            {
                end.numero = numBox.Text;
            }
            end.complemento = compleBox.Text;

            ps.Endereco = end;

            pessoas.Add(ps);

            ListViewItem item = new ListViewItem(ps.cpf);
            item.SubItems.Add(ps.nome);
            item.SubItems.Add(ps.data);
            item.SubItems.Add(ps.telephone);
            item.SubItems.Add(ps.email);

            listaPessoas.Items.Add(item);

            ListViewItem endeItem = new ListViewItem(end.cpf);
            endeItem.SubItems.Add(end.cep);
            endeItem.SubItems.Add(end.estado);
            endeItem.SubItems.Add(end.cidade);
            endeItem.SubItems.Add(end.bairro);
            endeItem.SubItems.Add(end.logra);
            endeItem.SubItems.Add(end.numero);
            endeItem.SubItems.Add(end.complemento);

            listaEnde.Items.Add(endeItem);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cpfBox.Clear();
            idadeBox.Clear();
            nomeBox.Clear();
            funcaoBox.Clear();
            setorBox.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfigurarListView()
        {

            listaPessoas.View = View.Details;
            listaPessoas.FullRowSelect = true;
            listaPessoas.GridLines = true;
            listaPessoas.Columns.Add("CPF", 90);
            listaPessoas.Columns.Add("Nome", 90);
            listaPessoas.Columns.Add("Data de nascimento", 160);
            listaPessoas.Columns.Add("Telefone", 90);
            listaPessoas.Columns.Add("Email", 90);

            listaEnde.View = View.Details;
            listaEnde.FullRowSelect = true;
            listaEnde.GridLines = true;

            listaEnde.Columns.Add("CPF", 100);
            listaEnde.Columns.Add("CEP", 80);
            listaEnde.Columns.Add("Estado", 80);
            listaEnde.Columns.Add("Cidade", 100);
            listaEnde.Columns.Add("Bairro", 100);
            listaEnde.Columns.Add("Logradouro", 120);
            listaEnde.Columns.Add("Número", 40);
            listaEnde.Columns.Add("Complemento", 120);
        }

        private void tituloCPF_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            cpfBox.Clear();
            nomeBox.Clear();
            dataNascBox.Clear();
            telBox.Clear();
            emailBox.Clear();

            cepBox.Clear();
            estadoBox.Clear();
            cidadeBox.Clear();
            bairroBox.Clear();
            lograBox.Clear();
            numBox.Clear();
            compleBox.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
