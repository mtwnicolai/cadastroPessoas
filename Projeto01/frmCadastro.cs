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
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            Pessoa ps = new Pessoa();
            ps.cpf = cpfBox.Text;
            ps.idade = idadeBox.Text;
            ps.nome = nomeBox.Text;
            ps.funcao = funcaoBox.Text;
            ps.setor = setorBox.Text;

            pessoas.Add(ps);

            ListViewItem item = new ListViewItem(ps.cpf);

            item.SubItems.Add(ps.nome);
            item.SubItems.Add(ps.idade);
            item.SubItems.Add(ps.funcao);
            item.SubItems.Add(ps.setor);


            listaPessoas.Items.Add(item);
            ConfigurarListView();
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

            listaPessoas.Columns.Add("CPF", 100);
            listaPessoas.Columns.Add("Nome", 150);
            listaPessoas.Columns.Add("Idade", 60);
            listaPessoas.Columns.Add("Função", 100);
            listaPessoas.Columns.Add("Setor", 100);
        }


    }
}
