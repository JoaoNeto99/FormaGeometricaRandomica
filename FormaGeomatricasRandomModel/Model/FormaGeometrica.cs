using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaGeometricaRandomica.Model
{
    public abstract class FormaGeometrica
    {

        public string Nome { get; set; }
        public List<int> Lados { get; set; }
        public int Comprimento { get; set; }
        public int Area { get; set; }

        public FormaGeometrica(List<int> lados, string nome)
        {
            Lados = lados;
            Nome = nome;
        }

        public abstract void CalculaArea();
        public void CalculaComprimento()
        {
            foreach(int item in Lados)
            {
                Comprimento += item;
            }
        }

        public override string ToString()
        {
            return $"{Nome}. A area e: {Area}. O comprimento e: {Comprimento}";
        }

    }
}
