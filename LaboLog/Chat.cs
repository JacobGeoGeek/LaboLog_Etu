using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboLog
{
    public class Chat : Felide
    {
        private int _poids;
        private Logger lg = Logger.Instance;

        public Chat(string nom) : base(nom)
        {
            //log trace
            lg.LogTrace("Création d'un chat" + nom);
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
                lg.LogTrace("Assigniation du Poids du chat " + this.Poids + " pour le chat" + this.Nom);
                if (value > 10)
                {
                    throw new ChatException("Erreur dans le poid du chat" + this.Nom);
                }
                else
                {
                    _poids = value;
                }
            }
        }
    }


}
