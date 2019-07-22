using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicule
{
    abstract class Vehic
    {
        //Chaque véhicule est caractérisé par son matricule, l’année de son modèle, son prix.
        //Lors de la création d’un véhicule, son matricule est incrémenté selon le nombre de véhicules créés.
        int _matricule;
        int _model;
        double _prix;
        static int _nb_vehicule;

        public Vehic(int model, double prix)
        {
            this._model = model;
            this._prix = prix;
            _matricule = _nb_vehicule++;
        }

        public int Matricule
        {
            get { return _matricule; }
        }

        public int Modele 
        {
            get { return _model; }
            set { Modele = value; }
        }

        public double Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }

        public int NbVehicule
        {
            get { return _nb_vehicule; }
        }

        //La classe Véhicule possède également deux méthodes abstraites démarrer() et accélérer() qui seront définies dans
        //les classes dérivées et qui afficheront des messages personnalisés.
        public abstract void Demarrer();
        public abstract void Accelerer();

        public override string ToString()
        {
            return "Matricule: " + _matricule + " Model: " + _model + " Prix: " + _prix;
        }
       
    }
}
