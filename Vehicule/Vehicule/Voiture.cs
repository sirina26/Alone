using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicule
{
    class Voiture : Vehic
    {
        public Voiture(int model, double prix) : base(model, prix) { }
       
        public override void Accelerer()
        {
            Console.Out.WriteLine("La voiture va accelerer");
        }

        public override void Demarrer()
        {
            Console.Out.WriteLine("La voiture va demarrer");
        }

        public override string ToString()
        {
            return "Voiture" + base.ToString();
        }
    }
}
