using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atendimento
{
    public partial class Form1 : Form
    {

        private Senhas senhas;
        private Guiches guiches;

        public Form1()
        {
            InitializeComponent();
            senhas = new Senhas();
            guiches = new Guiches();
        }

        private void btnGerarSenha_Click(object sender, EventArgs e)
        {
            senhas.gerar();
        }

        private void btnListarSenhas_Click(object sender, EventArgs e)
        {
            lstSenhasGeradas.Items.Clear();
            foreach (Senha senha in senhas.FilaSenhas)
                lstSenhasGeradas.Items.Add(senha.dadosParciais());

            BindingList<Senha> listaVinculada;
            listaVinculada = new BindingList<Senha>(senhas.FilaSenhas.ToList());

            dataGridView1.DataSource = listaVinculada;
        }

        private void btnChamadaGuiche1_Click(object sender, EventArgs e)
        {
            int idGuiche;
            idGuiche = int.Parse(txtIdGuiche.Text) - 1;
            if (!guiches.ListaGuiches[idGuiche].chamar(senhas.FilaSenhas))
                MessageBox.Show("Fila vazia");
        }

        private void btnListarChamadas_Click(object sender, EventArgs e)
        {
            int idGuiche;
            idGuiche = int.Parse(txtIdGuiche.Text) - 1;
            lstAtendimento1.Items.Clear();
            foreach (Senha senha in guiches.ListaGuiches[idGuiche].Atendimentos)
                lstAtendimento1.Items.Add(senha.dadosCompletos());

            BindingList<Senha> listaVinculada;
            listaVinculada = new BindingList<Senha>(guiches.ListaGuiches[idGuiche].Atendimentos.ToList());

            dataGridView1.DataSource = listaVinculada;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            guiches.adicionarGuiche(new Guiche(guiches.ListaGuiches.Count+1));
            lblQtdeGuiches.Text = guiches.ListaGuiches.Count.ToString();
        }
    }
}
