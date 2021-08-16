﻿using LocadoraDeVeiculos.Controladores.ServicoModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
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

namespace LocadoraDeVeiculos.WindowsApp.Features.Serviços
{
    public partial class AdicionarServico : Form
    {
        private Servico servico;

        public AdicionarServico()
        {
            InitializeComponent();
        }

        public Servico Servico
        {
            get { return servico; }
            set
            {
                servico = value;

                txtId.Text = servico.Id.ToString();
                txtNome.Text = servico.Nome.ToString();
                txtValor.Text = servico.Valor.ToString();
                if (servico.Tipo == "Calculo Diario")
                    rdbCalcDiaria.Checked = true;
                else
                    rdbTaxaFixa.Checked = true;
            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtNome.Text;
            double valor = Convert.ToDouble(txtNome.Text);
            string tipo = "";
            if (rdbCalcDiaria.Checked)
                tipo = "Calculo Diario";
            else
                tipo = "Calculo Fixo";

            servico = new Servico(id, nome, tipo, valor);

            string resultadoValidacao = servico.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (this.Text.IndexOf(".") >= 0 || this.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void AdicionarServico_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }
    }
}
