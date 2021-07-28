using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.WindowsApp.Shared;

namespace eAgenda.WindowsApp.Features.Compromissos
{
    public partial class TabelaCompromissoControl : UserControl
    {
        public TabelaCompromissoControl()
        {
            InitializeComponent();
            gridCompromissos.ConfigurarGridZebrado();
            gridCompromissos.ConfigurarGridSomenteLeitura();
            gridCompromissos.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Assunto", HeaderText = "Assunto"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Local", HeaderText = "Local"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Link", HeaderText = "Link"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Data", HeaderText = "Data"},

                new DataGridViewTextBoxColumn {DataPropertyName = "HoraInicio", HeaderText = "Hora de Inicio"},
                
                new DataGridViewTextBoxColumn {DataPropertyName = "HoraTermino", HeaderText = "Hora de Termino"}, 

                new DataGridViewTextBoxColumn {DataPropertyName = "Contato", HeaderText = "Nome do Contato"},
            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return gridCompromissos.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<Compromisso> compromissos)
        {
            gridCompromissos.Rows.Clear();
            foreach (Compromisso compromisso in compromissos)
            {
                string contatoNome = null;
                if (compromisso.Contato != null)
                    contatoNome = compromisso.Contato.Nome;

                gridCompromissos.Rows.Add(compromisso.Id, compromisso.Assunto, compromisso.Local, compromisso.Link, 
                    compromisso.Data, compromisso.HoraInicio, compromisso.HoraTermino, contatoNome);
            }
        }
    }
}
