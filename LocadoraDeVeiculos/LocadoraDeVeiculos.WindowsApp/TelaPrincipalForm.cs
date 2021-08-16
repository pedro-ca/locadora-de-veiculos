﻿using System;
using System.Windows.Forms;
using LocadoraDeVeiculos.Controladores.ServicoModule;
using LocadoraDeVeiculos.WindowsApp.Clientes;
using LocadoraDeVeiculos.WindowsApp.ClientesModule;
using LocadoraDeVeiculos.WindowsApp.Features.Serviços;
using LocadoraDeVeiculos.WindowsApp.Shared;

namespace LocadoraDeVeiculos.WindowsApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ICadastravel operacoes;
        public static TelaPrincipalForm Instancia;
        public TelaPrincipalForm()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientesForm tarefas = new ClientesForm();
            tarefas.ShowDialog();
            this.Close();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ConfiguracaoFuncionarioToolBox configuracao = new ConfiguracaoFuncionarioToolBox();

            //ConfigurarToolBox(configuracao);

            //AtualizarRodape(configuracao.TipoCadastro);

            //operacoes = new OperacoesTarefa(new ControladorTarefa());

            //ConfigurarPainelRegistros();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ConfiguracaoTarefaToolBox configuracao = new ConfiguracaoTarefaToolBox();

            //ConfigurarToolBox(configuracao);

            //AtualizarRodape(configuracao.TipoCadastro);

            //operacoes = new OperacoesTarefa(new ControladorTarefa());

            //ConfigurarPainelRegistros();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarServico telAdicionarServico = new AdicionarServico();
            telAdicionarServico.ShowDialog();

            //ConfiguracaoTarefaToolBox configuracao = new ConfiguracaoTarefaToolBox();

            //ConfigurarToolBox(configuracao);

            //AtualizarRodape(configuracao.TipoCadastro);

            //operacoes = new OperacoesTarefa(new ControladorTarefa());

            //ConfigurarPainelRegistros();
        }

        private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ConfiguracaoTarefaToolBox configuracao = new ConfiguracaoTarefaToolBox();

            //ConfigurarToolBox(configuracao);

            //AtualizarRodape(configuracao.TipoCadastro);

            //operacoes = new OperacoesTarefa(new ControladorTarefa());

            //ConfigurarPainelRegistros();
        }

        private void grupoDeVeículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ConfiguracaoTarefaToolBox configuracao = new ConfiguracaoTarefaToolBox();

            //ConfigurarToolBox(configuracao);

            //AtualizarRodape(configuracao.TipoCadastro);

            //operacoes = new OperacoesTarefa(new ControladorTarefa());

            //ConfigurarPainelRegistros();
        }
        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            operacoes.InserirNovoRegistro();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            operacoes.EditarRegistro();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            operacoes.ExcluirRegistro();
        }
    }
}
