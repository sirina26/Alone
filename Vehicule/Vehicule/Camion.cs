using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicule
{
    class Camion : Vehic
    {
        public Camion(int model, double prix) : base(model, prix) { }
        public override void Accelerer()
        {
            Console.Out.WriteLine("Le camion va accelerer");
        }

        public override void Demarrer()
        {
            Console.Out.WriteLine("Le camion va demarrer");
        }

        public override string ToString()
        {
            return "Camion" + base.ToString();
        }
    }
}
