using NotasCiclo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasCiclo.Negocios
{
    class M_Negocios
    {
        public string calculoCiclo(M_Entidades entidades)
        {

            entidades.Trimestre1 = (entidades.Lab * 0.4) + (entidades.Parcial * 0.6);
            entidades.Trimestre2 = (entidades.Lab2 * 0.4) + (entidades.Parcial2 * 0.6);
            entidades.Trimestre3 = (entidades.Lab3 * 0.4) + (entidades.Parcial3 * 0.6);
            entidades.Resultado = (entidades.Trimestre1 + entidades.Trimestre2 + entidades.Trimestre3) / 3;

            return "La nota de su primer timestre es de: " + entidades.Trimestre1.ToString("0.00") +
                "\nLa nota de su segundo trimestre es de: " + entidades.Trimestre2.ToString("0.00") +
                "\nLa nota de su tercer trimestre es de: " + entidades.Trimestre3.ToString("0.00") +
                "\nLa nota global de su ciclo es: " + entidades.Resultado.ToString("0.00");

        }
    }
}
