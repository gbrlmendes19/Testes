using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleMedicoFamiliar
{
    public partial class RegistroConsultas : Form
    {
        RegistroConsulta regConsulta = new RegistroConsulta();
        Medicos medico = new Medicos();
        Familiares familiar = new Familiares();
        HomePage home = new HomePage();
        public RegistroConsultas()
        {
            InitializeComponent();
            List<Medicos> medicos = medico.Listar();

            foreach (var item in medicos)
            {
                cbMedicos.Items.Add(item.nome + " - " + item.especialidade);
            }

            List<Familiares> familiares = new List<Familiares>();
            familiares = familiar.Listar();
            foreach (var item in familiares)
            {
                cbPessoas.Items.Add(item.Nome);
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (this.cbPessoas.Text == "")
            {
                MessageBox.Show("Cadastre algum familiar para ser o paciente da consulta.");

                this.Close();
                HomePage home = new HomePage();
                home.Show();
            }
            else if (this.cbMedicos.Text == "")
            {
                MessageBox.Show("Cadastre algum médico para ser o responsável da consulta.");

                this.Close();
                HomePage home = new HomePage();
                home.Show();
            }
            else
            {
                string pessoa = cbPessoas.SelectedItem.ToString();
                string medico = cbMedicos.SelectedItem.ToString();

                regConsulta.Adicionar(pessoa, medico);
                MessageBox.Show("Consulta registrada com sucesso:");
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage home = new HomePage();
            home.Show();
        }

        private void RegistroConsultas_Load(object sender, EventArgs e)
        {
            cbPessoas.SelectedIndex = 0;

        }
    }
}
