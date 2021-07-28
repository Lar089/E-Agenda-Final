using eAgenda.Controladores.CompromissoModule;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Features.Compromissos
{
    public class OperacoesCompromisso : ICadastravel
    {
        private readonly ControladorCompromisso controlador = null;
        private readonly TabelaCompromissoControl tabelaCompromisso = null;

        public OperacoesCompromisso(ControladorCompromisso ctrlCompromisso)
        {
            controlador = ctrlCompromisso;
            tabelaCompromisso = new TabelaCompromissoControl();
        }

        public void InserirNovoRegistro()
        {
            TelaCompromissoForm tela = new TelaCompromissoForm();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Compromisso);

                List<Compromisso> compromisso = controlador.SelecionarTodos();

                tabelaCompromisso.AtualizarRegistros(compromisso);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Compromisso: [{tela.Compromisso.Assunto}] inserido com sucesso");
            }
        }

        public void EditarRegistro()
        {
            int id = tabelaCompromisso.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um compromisso para poder editar!", "Edição de Compromissos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Compromisso compromissoSelecionado = controlador.SelecionarPorId(id);

            if (compromissoSelecionado.EstaConcluida())
            {
                MessageBox.Show("Não é permitido a edição de compromissos já concluídos!", "Edição de Compromissos",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCompromissoForm tela = new TelaCompromissoForm();

            tela.Compromisso = compromissoSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Compromisso);

                List<Compromisso> compromissos = controlador.SelecionarTodos();

                tabelaCompromisso.AtualizarRegistros(compromissos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Compromisso: [{tela.Compromisso.Assunto}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaCompromisso.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um compromisso para poder excluir!", "Exclusão de Compromissos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Compromisso compromissoSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o compromisso: [{compromissoSelecionado.Assunto}] ?",
                "Exclusão de Compromissos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<Compromisso> compromissos = controlador.SelecionarTodos();

                tabelaCompromisso.AtualizarRegistros(compromissos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Compromisso: [{compromissoSelecionado.Assunto}] removido com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            FiltroCompromissoForm telaFiltro = new FiltroCompromissoForm();

            if (telaFiltro.ShowDialog() == DialogResult.OK)
            {
                List<Compromisso> compromissos = new List<Compromisso>();
                string tipoCompromisso = "";

                switch (telaFiltro.TipoFiltro)
                {
                    case FiltroCompromissoEnum.TodosCompromissos:
                        compromissos = controlador.SelecionarTodos();
                        break;

                    case FiltroCompromissoEnum.CompromissosFuturos:
                        {
                            compromissos = controlador.SelecionarCompromissosFuturos(telaFiltro.DataInicial, telaFiltro.DataInicial);
                            tipoCompromisso = "futuro(s)";
                            break;
                        }

                    case FiltroCompromissoEnum.CompromissosPassados:
                        {
                            compromissos = controlador.SelecionarCompromissosPassados(telaFiltro.DataFinal);
                            tipoCompromisso = "passado(s)";
                            break;
                        }

                    default:
                        break;
                }

                tabelaCompromisso.AtualizarRegistros(compromissos);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {compromissos.Count} compromisso(s) {tipoCompromisso}");
            }
        }

        public UserControl ObterTabela()
        {
            List<Compromisso> compromissos = controlador.SelecionarTodos();

            tabelaCompromisso.AtualizarRegistros(compromissos);

            return tabelaCompromisso;
        }

        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void DesagruparRegistros()
        {
            throw new NotImplementedException();
        }
    }
}
