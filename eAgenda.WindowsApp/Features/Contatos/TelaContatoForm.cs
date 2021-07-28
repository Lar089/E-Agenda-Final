using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Features.Contatos
{
    public partial class TelaContatoForm : Form
    {
        private Contato contato;
        public TelaContatoForm()
        {
            InitializeComponent();
        }

        public Contato Contato
        {
            get { return contato; }

            set
            {
                contato = value;

                txtId.Text = contato.Id.ToString();
                txtNome.Text = contato.Nome;
                txtEmail.Text = contato.Email;
                maskTxtTelefone.Text = contato.Telefone;
                txtEmpresa.Text = contato.Empresa;
                txtCargo.Text = contato.Cargo;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string Nome = txtNome.Text, 
                Email = txtEmail.Text, 
                Telefone = maskTxtTelefone.Text,
                Empresa = txtEmpresa.Text,
                Cargo = txtCargo.Text;

            contato = new Contato(Nome, Email, Telefone, Empresa, Cargo);

            string resultadoValidacao = contato.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }

        private void TelaContatoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }
    }
}
