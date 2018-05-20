using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicoFamiliar
{
    public class RegistroConsulta
    {
        public string Pessoa { get; set; }
        public string Medico { get; set; }

        public static List<RegistroConsulta> listRegConsultas = new List<RegistroConsulta>();

        public void Adicionar(string pessoa, string medico)
        {
            listRegConsultas.Add(new RegistroConsulta { Pessoa = pessoa, Medico = medico });
        }

        public List<RegistroConsulta> Listar() => listRegConsultas;
    }
}
