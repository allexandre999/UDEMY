using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioRetangulo
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return Largura * 2 + Altura * 2;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

        public override string ToString()
        {
            return $"\nAREA: = {Area().ToString("F2",CultureInfo.InvariantCulture)}\n" +
                $"PERÍMETRO = {Perimetro().ToString("F2",CultureInfo.InvariantCulture)}\n" +
                $"DIAGONAL = {Diagonal().ToString("F2",CultureInfo.InvariantCulture)}\n";
        }
    }
}
