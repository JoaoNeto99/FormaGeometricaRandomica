using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaGeometricaRandomica.Model
{
    public class Quadrilatero : FormaGeometrica
    {

        public Quadrilatero(List<int> lados)
            : base(lados, "Quadrilatero")
        {
            CalculaArea();
            CalculaComprimento();
        }

        public override void CalculaArea()
        {
            int soma = 0;
            foreach (int item in Lados)
            {
                soma += item;
            }
            Area = soma / 4;
        }
    }
}
