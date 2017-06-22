using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboLog
{
    public abstract class Felide : Animal
    {
        private Logger lg = Logger.Instance;
        public Felide(string nom) : base(nom)
        {
            //log trace
            lg.LogTrace("Création d'un Félide" + nom);
        }

        public override void Mange(string repas)
        {
            //log trace
            lg.LogTrace("On donne à manger au félin: " + repas);
            switch (repas)
            {
                case "oiseau":
                    this.DernierRepas = repas;
                    break;

                case "souris":
                    this.DernierRepas = repas;
                    break;

                case "chien":
                    throw new FelideException("Je n'aime pas manger des chiens");

                default:
                    this.DernierRepas = repas;
                    break;
            }
        }


    }

    
}
