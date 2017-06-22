using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboLog
{
    public class Chien : Canide
    {
        private int _poids;
        private Logger lg = Logger.Instance;
        public Chien(string nom) : base(nom)
        {
            //log trace
            lg.LogTrace("Création d'un chien " + this.Nom);
        }

        public override int Poids
        {
            get
            {
                return _poids;
            }

            set
            {
                //log trace
                lg.LogTrace("Assigniation du Poids du chien " + this.Poids + " pour le Chien" + this.Nom);
                if (value > 40)
                {
                    throw new ChienException("Erreur dans le poid du chien" + this.Nom);
                }
                else
                {
                    _poids = value;
                }
            }
        }
    }

}
