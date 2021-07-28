﻿using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.TarefaModule;
using eAgenda.WindowsApp.Features.Compromissos;
using eAgenda.WindowsApp.Features.Contatos;
using eAgenda.WindowsApp.Features.Tarefas;
using eAgenda.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ICadastravel operacoes;

        public static TelaPrincipalForm Instancia;

        public TelaPrincipalForm()
        {
            InitializeComponent();

            Instancia = this;
        }

        public  void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        private void menuItemTarefas_Click(object sender, EventArgs e)
        {
            toolboxAcoes.Enabled = true;
            btnFiltrar.Enabled = true;
            btnAgrupar.Enabled = false;
            btnDesagrupar.Enabled = false;

            ConfiguracaoTarefaToolBox configuracao = new ConfiguracaoTarefaToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = new OperacoesTarefa(new ControladorTarefa());

            ConfigurarPainelRegistros();            
        }

        private void menuItemContato_Click(object sender, EventArgs e)
        {
            toolboxAcoes.Enabled = true;
            btnFiltrar.Enabled = false;
            btnAgrupar.Enabled = true;
            btnDesagrupar.Enabled = true;

            ConfiguracaoContatoToolBox configuracao = new ConfiguracaoContatoToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = new OperacoesContato(new ControladorContato());

            ConfigurarPainelRegistros();
        }

        private void menuItemCompromissos_Click(object sender, EventArgs e)
        {
            toolboxAcoes.Enabled = true;
            btnFiltrar.Enabled = true;
            btnAgrupar.Enabled = false;
            btnDesagrupar.Enabled = false;

            ConfiguracaoCompromissoToolBox configuracao = new ConfiguracaoCompromissoToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = new OperacoesCompromisso(new ControladorCompromisso());

            ConfigurarPainelRegistros();
        }
              
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            operacoes.InserirNovoRegistro();
        }
       
        private void btnEditar_Click(object sender, EventArgs e)
        {
            operacoes.EditarRegistro();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            operacoes.ExcluirRegistro();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            operacoes.FiltrarRegistros();
        }

        private void btnAgrupar_Click(object sender, EventArgs e)
        {
            operacoes.AgruparRegistros();
        }

        private void btnDesagrupar_Click(object sender, EventArgs e)
        {
            operacoes.DesagruparRegistros();
        }

        private void ConfigurarPainelRegistros()
        {
            UserControl tabela = operacoes.ObterTabela();

            tabela.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(tabela);
        }

        private void ConfigurarToolBox(IConfiguracaoToolBox configuracao)
        {
            labelTipoCadastro.Text = configuracao.TipoCadastro;

            btnAdicionar.ToolTipText = configuracao.ToolTipAdicionar;
            btnEditar.ToolTipText = configuracao.ToolTipEditar;
            btnExcluir.ToolTipText = configuracao.ToolTipExcluir;
            btnFiltrar.ToolTipText = configuracao.ToolTipFiltrar;
            btnAgrupar.ToolTipText = configuracao.ToolTipAgrupar;
            btnDesagrupar.ToolTipText = configuracao.ToolTipDesagrupar;
        }
    }
}
