using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboLog
{
    public abstract class Animal
    {
        private string _nom;
        private string _dernierRepas;

        Logger lg = Logger.Instance;

        public Animal(string nom)
        {
            
            this.Nom = nom;
            //Log trace
            lg.LogTrace("Création de l'animal" + this.Nom);
    
        }

        public string Nom {
            get { return _nom; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _nom = value;
                }
                else
                {
                    //log trace
                    throw new AnimalException("Le nom de l'animal doit être non vide");
                }
            }
        }

        public abstract int Poids { get; set; }

        public string DernierRepas
        {
            get { return _dernierRepas; }
            set
            {
                //log trace 
                lg.LogTrace("Le dernier repas est " + this.DernierRepas);
                _dernierRepas = value;

            }
        }

        public abstract void Mange(string repas);
    }

}
