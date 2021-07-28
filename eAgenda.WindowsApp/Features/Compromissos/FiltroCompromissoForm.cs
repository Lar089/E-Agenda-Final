using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Features.Compromissos
{
    public partial class FiltroCompromissoForm : Form
    {
        private DateTime dataInicial;
        private DateTime dataFinal;

        public DateTime DataInicial { get => dataInicial; set => dataInicial = value; }
        public DateTime DataFinal { get => dataFinal; set => dataFinal = value; }

        public FiltroCompromissoForm()
        {
            InitializeComponent();
        }

        public FiltroCompromissoEnum TipoFiltro
        {
            get
            {
                if (rdbCompromissosConcluidos.Checked)
                    return FiltroCompromissoEnum.CompromissosPassados;

                else if (rdbCompromissosPendentes.Checked)
                    return FiltroCompromissoEnum.CompromissosFuturos;

                else
                    return FiltroCompromissoEnum.TodosCompromissos;
            }
        }

        private void rdbCompromissosPendentes_CheckedChanged(object sender, EventArgs e)
        {
            dateDataInicial.Enabled = true;
            dateDataFinal.Enabled = true;
        }

        private void rdbCompromissosConcluidos_CheckedChanged(object sender, EventArgs e)
        {
            dateDataInicial.Enabled = false;
            dateDataFinal.Enabled = true;
        }

        private void rdbTodosCompromissos_CheckedChanged(object sender, EventArgs e)
        {
            dateDataInicial.Enabled = false;
            dateDataFinal.Enabled = false;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            DataInicial = dateDataInicial.Value;
            DataFinal = dateDataFinal.Value;
        }
    }
}
