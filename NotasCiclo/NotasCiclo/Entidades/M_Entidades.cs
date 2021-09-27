using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasCiclo.Entidades
{
    class M_Entidades
    {
        private double lab;
        private double parcial;
        private double lab2;
        private double parcial2;
        private double lab3;
        private double parcial3;
        private double resultado;
        private double trimestre1;
        private double trimestre2;
        private double trimestre3;

        public double Lab { get => lab; set => lab = value; }
        public double Parcial { get => parcial; set => parcial = value; }
        public double Lab2 { get => lab2; set => lab2 = value; }
        public double Parcial2 { get => parcial2; set => parcial2 = value; }
        public double Lab3 { get => lab3; set => lab3 = value; }
        public double Parcial3 { get => parcial3; set => parcial3 = value; }
        public double Resultado { get => resultado; set => resultado = value; }
        public double Trimestre1 { get => trimestre1; set => trimestre1 = value; }
        public double Trimestre2 { get => trimestre2; set => trimestre2 = value; }
        public double Trimestre3 { get => trimestre3; set => trimestre3 = value; }


        public M_Entidades() { }

        public M_Entidades(double lab, double parcial, double lab2, double parcial2, double lab3, double parcial3, double resultado, double trimestre1, double trimestre2, double trimestre3)
        {
            this.Lab = lab;
            this.Parcial = parcial;
            this.Lab2 = lab2;
            this.Parcial2 = parcial2;
            this.Lab3 = lab3;
            this.Parcial3 = parcial3;
            this.Resultado = resultado;
            this.Trimestre1 = trimestre1;
            this.Trimestre2 = trimestre2;
            this.Trimestre3 = trimestre3;
        }

       
    }
}
