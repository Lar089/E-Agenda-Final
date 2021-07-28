using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.ContatoModule;
using eAgenda.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Features.Contatos
{
    public class OperacoesContato : ICadastravel
    {
        private readonly ControladorContato controlador = null;
        private readonly TabelaContatoControl tabelaContatos = null;

        public OperacoesContato(ControladorContato ctrlContato)
        {
            this.controlador = ctrlContato;
            tabelaContatos = new TabelaContatoControl();
        }

        public void InserirNovoRegistro()
        {
            TelaContatoForm tela = new TelaContatoForm();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Contato);

                List<Contato> contatos = controlador.SelecionarTodos();

                tabelaContatos.AtualizarRegistros(contatos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Contato: [{tela.Contato.Nome}] inserido com sucesso");
            }
        }

        public void EditarRegistro()
        {
            int id = tabelaContatos.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um contato para poder editar!", "Edição de Contatos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Contato contatoSelecionada = controlador.SelecionarPorId(id);
            TelaContatoForm tela = new TelaContatoForm();

            tela.Contato = contatoSelecionada;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Contato);

                List<Contato> contatos = controlador.SelecionarTodos();

                tabelaContatos.AtualizarRegistros(contatos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Contato: [{tela.Contato.Nome}] editada com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaContatos.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um contato para poder excluir!", "Exclusão de Tarefas",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Contato contatoSelecionada = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o contato: [{contatoSelecionada.Nome}] ?",
                "Exclusão de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<Contato> contatos = controlador.SelecionarTodos();

                tabelaContatos.AtualizarRegistros(contatos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Contato: [{contatoSelecionada.Nome}] removido com sucesso");
            }
        }        

        public UserControl ObterTabela()
        {
            List<Contato> contatos = controlador.SelecionarTodos();

            tabelaContatos.AtualizarRegistros(contatos);

            return tabelaContatos;
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void AgruparRegistros()
        {
            AgruparContatoForm telaFiltro = new AgruparContatoForm();

            if (telaFiltro.ShowDialog() == DialogResult.OK)
            {
                tabelaContatos.AgruparContatos(telaFiltro.TipoAgrupar);
            }
        }

        public void DesagruparRegistros()
        {
            tabelaContatos.DesagruparContatos();
        }
    }
}
