using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboLog
{
    public abstract class Canide : Animal
    {
        private Logger lg = Logger.Instance;
        public Canide(string nom) : base(nom)
        {
            //log trace
            lg.LogTrace("Création du canide " + this.Nom);
        }

        public override void Mange(string repas)
        {
            //log trace
            lg.LogTrace("On donne à manger au Canide: " + repas);
            switch (repas)
            {
                case "oiseau":
                    throw new CanideException("Je ne suis pas assez agile pour manger un oiseau");

                case "chien":
                    throw new CanideException("Je n'aime pas manger des chiens");

                default:
                    this.DernierRepas = repas;
                    break;
            }
        }
    }


}
