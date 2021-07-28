using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
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

namespace eAgenda.WindowsApp.Features.Compromissos
{
    public partial class TelaCompromissoForm : Form
    {
        private Compromisso compromisso;
        private readonly ControladorContato controlador = null;

        public TelaCompromissoForm()
        {
            InitializeComponent();
            controlador = new ControladorContato();
            GerarContatos();
        }

        public Compromisso Compromisso
        {
            get { return compromisso; }

            set
            {
                compromisso = value;

                txtId.Text = compromisso.Id.ToString();
                txtAssunto.Text = compromisso.Assunto;
                if (compromisso.Local.Equals("Presencial"))
                {
                    rdbPresencial.Checked = true;
                    txtLink.Text = "";
                }
                else
                {
                    rdbRemoto.Checked = true;
                    txtLink.Text = compromisso.Link;
                }
                dateData.Text = compromisso.Data.ToShortDateString();
                maskTxtHoraInicio.Text = compromisso.HoraInicio.ToString();
                maskTxtHoraTermino.Text = compromisso.HoraTermino.ToString();
                if (compromisso.Contato != null)
                    cmbContato.SelectedItem = compromisso.Contato.Nome;
                else
                    cmbContato.SelectedIndex = 0;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string assunto = txtAssunto.Text;
            string local = "";

            if (rdbPresencial.Checked)
                local = "Presencial";
            else if (rdbRemoto.Checked)
                local = "Remoto";

            string link;

            if (string.IsNullOrEmpty(txtLink.Text))
                link = "";
            else
                link = txtLink.Text;

            DateTime data;

            if (string.IsNullOrEmpty(txtId.Text))
                data = DateTime.Now;
            else
                data = Convert.ToDateTime(dateData.Text);

            TimeSpan horaInicial = PegarHora(maskTxtHoraInicio.Text);
            TimeSpan horaTermino = PegarHora(maskTxtHoraTermino.Text);

            List<Contato> contatos = controlador.SelecionarTodos();

            Contato contatoNovo = null;
            string item = Convert.ToString(cmbContato.SelectedItem);
            foreach (Contato contato in contatos)
            {
                if (item == contato.Nome)
                    contatoNovo = contato;
            }

            compromisso = new Compromisso(assunto, local, link, data, horaInicial, horaTermino, contatoNovo);

            string resultadoValidacao = compromisso.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }

        private void TelaTarefaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private TimeSpan PegarHora(string hora)
        {
            string[] horaSplit = hora.Split(':');
            return new TimeSpan(int.Parse(horaSplit[0]), int.Parse(horaSplit[1]), 0);
        }

        private void GerarContatos()
        {
            List<Contato> contatos = controlador.SelecionarTodos();
            int index = 0;
            cmbContato.Items.Insert(index, "Nenhum");
            index++;
            foreach (Contato contato in contatos)
            {
                cmbContato.Items.Insert(index, contato.Nome);
                index++;
            }
        }

        private void rdbPresencial_CheckedChanged(object sender, EventArgs e)
        {
            txtLink.Enabled = false;
        }

        private void rdbRemoto_CheckedChanged(object sender, EventArgs e)
        {
            txtLink.Enabled = true;
        }
    }
}
