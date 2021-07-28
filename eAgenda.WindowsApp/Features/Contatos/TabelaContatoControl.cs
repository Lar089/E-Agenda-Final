using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.ContatoModule;
using eAgenda.WindowsApp.Shared;

namespace eAgenda.WindowsApp.Features.Contatos
{
    public partial class TabelaContatoControl : UserControl
    {
        private Subro.Controls.DataGridViewGrouper gridContatosAgrupados;
        private AgruparContatoEnum tipoAgrupamento;

        public TabelaContatoControl()
        {
            InitializeComponent();
            gridContatos.ConfigurarGridZebrado();
            gridContatos.ConfigurarGridSomenteLeitura();
            gridContatos.Columns.AddRange(ObterColunas()); 
            
            tipoAgrupamento = AgruparContatoEnum.TodosContato;
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "E-mail"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Empresa", HeaderText = "Empresa"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Cargo", HeaderText = "Cargo"}
            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return gridContatos.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<Contato> contatos)
        {
            DesagruparContatos();

            /*
            gridContatos.Rows.Clear();
            foreach (Contato contato in contatos)
            {
                gridContatos.Rows.Add(contato.Id, contato.Nome, contato.Email, contato.Telefone, 
                    contato.Empresa, contato.Cargo);
            }*/

            gridContatos.DataSource = contatos;

            gridContatosAgrupados = new Subro.Controls.DataGridViewGrouper(gridContatos);

            TipoAgruparContatos();
        }

        private void TipoAgruparContatos()
        {
            switch (tipoAgrupamento)
            {

                case AgruparContatoEnum.AgruparCargoContato:
                    AgruparContatos("Cargo");
                    break;

                case AgruparContatoEnum.AgruparEmpresaContato:
                    AgruparContatos("Empresa");
                    break;

                case AgruparContatoEnum.TodosContato:
                    DesagruparContatos();
                    break;

                default:
                    break;
            }
        }

        private void AgruparContatos(string campo)
        {
            if (gridContatosAgrupados == null)
                return;

            gridContatosAgrupados.RemoveGrouping();
            gridContatosAgrupados.SetGroupOn(campo);
            gridContatosAgrupados.Options.ShowGroupName = false;
            gridContatosAgrupados.Options.GroupSortOrder = SortOrder.None;

            foreach (DataGridViewColumn item in gridContatos.Columns)
                if (item.DataPropertyName == campo)
                    item.Visible = false;

            gridContatos.RowHeadersVisible = false;
            gridContatos.ClearSelection();
        }

        public void DesagruparContatos()
        {
            var campos = new string[] { "Cargo", "Empresa" };

            if (gridContatosAgrupados == null)
                return;

            gridContatos.RowHeadersVisible = true;
            gridContatosAgrupados.RemoveGrouping();
            foreach (var campo in campos)
                foreach (DataGridViewColumn item in gridContatos.Columns)
                    if (item.DataPropertyName == campo)
                        item.Visible = true;
        }

        public void AgruparContatos(AgruparContatoEnum tipoAgrupamento)
        {
            this.tipoAgrupamento = tipoAgrupamento;

            TipoAgruparContatos();
        }
    }
}
