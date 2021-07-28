using eAgenda.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WindowsApp.Features.Compromissos
{
    public class ConfiguracaoCompromissoToolBox : IConfiguracaoToolBox
    {
        public string TipoCadastro
        {
            get { return "Cadastro de Compromissos"; }
        }

        public string ToolTipAdicionar
        {
            get { return "Adicionar um novo Compromisso"; }
        }

        public string ToolTipEditar
        {
            get { return "Editar um Compromisso existente"; }
        }

        public string ToolTipExcluir
        {
            get { return "Excluir um Compromisso existente"; }
        }

        public string ToolTipFiltrar
        {
            get { return "Filtrar os Compromissos"; }
        }

        public string ToolTipAgrupar
        {
            get { return "Agrupar os Compromissos"; }
        }

        public string ToolTipDesagrupar
        {
            get { return "Desagrupar os Compromissos"; }
        }
    }
}
