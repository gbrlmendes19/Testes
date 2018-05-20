using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicoFamiliar
{
    public class Vacinas
    {
        public string nome { get; set; }
        public string tipo { get; set; }

        public static List<Vacinas> listVacinas = new List<Vacinas>();

        public void Adicionar(string nomeVacina, string tipoVacina)
        {
            listVacinas.Add(new Vacinas() { nome = nomeVacina, tipo = tipoVacina });
        }

        public List<Vacinas> Listar()
        {
            return listVacinas;
        }
    }
}
