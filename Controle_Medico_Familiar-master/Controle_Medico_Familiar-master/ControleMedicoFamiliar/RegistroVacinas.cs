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
    public partial class RegistroVacinas : Form
    {
        RegistroVacina regVacina = new RegistroVacina();
        Vacinas vacina = new Vacinas();
        Familiares familiar = new Familiares();
        HomePage home = new HomePage();
        public RegistroVacinas()
        {
            InitializeComponent();
            List<Vacinas> vacinas = new List<Vacinas>();
            vacinas = vacina.Listar();
            foreach (var item in vacinas)
            {
                cbVacina.Items.Add(item.nome +" - "+ item.tipo);
            }

            List<Familiares> familiares = new List<Familiares>();
            familiares = familiar.Listar();
            foreach (var item in familiares)
            {
                cbPessoas.Items.Add(item.Nome);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.cbPessoas.Text == "")
            {
                MessageBox.Show("Cadastre algum familiar para ser o paciente da consulta.");

                this.Close();
                HomePage home = new HomePage();
                home.Show();
            }
            else if (this.cbVacina.Text == "")
            {
                MessageBox.Show("Cadastre alguma vacina que será aplicada.");

                this.Close();
                HomePage home = new HomePage();
                home.Show();
            }
            else
            {
                string pessoa = cbPessoas.SelectedItem.ToString();
                string vacina = cbVacina.SelectedItem.ToString();

                try
                {
                    regVacina.Adicionar(pessoa, vacina);
                    MessageBox.Show("Vacina registrada com sucesso!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao registrar vacina!");
                    throw;
                }
            }
                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Show();
        }

        private void RegistroVacinas_Load(object sender, EventArgs e)
        {
            cbPessoas.SelectedIndex = 0;
        }
    }
}
