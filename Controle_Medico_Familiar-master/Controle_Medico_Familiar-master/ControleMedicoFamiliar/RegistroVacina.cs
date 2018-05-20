using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicoFamiliar
{
    public class RegistroVacina
    {
        public string Pessoa { get; set; }
        public string Vacina { get; set; }

        public static List<RegistroVacina> listRegVacinas = new List<RegistroVacina>();

        public void Adicionar(string pessoa, string vacina)
        {
            listRegVacinas.Add(new RegistroVacina { Pessoa = pessoa, Vacina = vacina });
        }

        public List<RegistroVacina> Listar() => listRegVacinas;
    }
}
