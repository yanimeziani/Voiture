using System;
namespace Voiture
{

    public class Voiture
    {
        private string marque;
        private string modele;
        private double vitesse;
        private bool estDemarre;

        public string Marque
        {
            get { return marque; }
            set { marque = value; }
        }
        public string Modele
        {
            get { return modele; }
            set { modele = value; }
        }
        public double Vitesse
        {
            get { return vitesse; }
            set { vitesse = value; }
        }
        public bool EstDemarre
        {
            get { return estDemarre; }
            set { estDemarre = value; }
        }

        public Voiture(string marque, string modele)
        {
            this.Marque = marque;
            this.Modele = modele;
        }

        public string ObtenirIdentifiant()
        {
            return $"[ {this.Marque} | {this.Modele} ]";
        }

        public void Demarrer()
        {
            if (!this.EstDemarre)
            {
                this.EstDemarre = true;
            }
            else
            {
                Console.WriteLine($"{ObtenirIdentifiant()} Véhicule déja en marche.");
            }

        }

        public void Arreter()
        {
            if (this.EstDemarre)
            {
                this.EstDemarre = false;
            }
            else
            {
                Console.WriteLine($"{ObtenirIdentifiant()} Véhicule déja à l'arrêt.");
            }
        }

        public void Accelerer(double vitesseGagnee)
        {
            this.Vitesse += vitesseGagnee;
            Console.WriteLine($"{ObtenirIdentifiant()} Véhicule maintenant à la vitesse : {this.Vitesse} km/h.");
        }

        public void Freiner(double vitessePerdue)
        {
            this.Vitesse -= vitessePerdue;
            Console.WriteLine($"{ObtenirIdentifiant()} Véhicule maintenant à la vitesse : {this.Vitesse} km/h.");
        }

        public override string ToString()
        {
            return $"Marque : {this.Marque} \nModèle : {this.Modele} \nVitesse : {this.Vitesse} \nEst démarrée : {this.EstDemarre}";
        }
    }
}

