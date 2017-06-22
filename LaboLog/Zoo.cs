using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboLog
{
    public class Zoo
    {

        private List<Animal> ListeAnimaux = new List<Animal>();
        Logger Message;



        public Zoo()
        {
            //log
            Message = Logger.Instance;
            Message.LogTrace("Création du zoo");
        }


        public void AjouterAnimal(Animal a)
        {
            //log trace 

            ListeAnimaux.Add(a);
            Message.LogTrace("Création de l'animal" + a.Nom);

        }

        public Animal this[int index]
        {
            //get; //log trace 
            get
            {
                Animal a = null;
                if (index <= (ListeAnimaux.Count - 1))
                {

                    a = ListeAnimaux[index];
                    Message.LogTrace(ListeAnimaux[index].Nom);
                }

                return a;

            }

            //set; //log trace
            set
            {
                if (index <= (ListeAnimaux.Count))
                {

                    ListeAnimaux.Insert(index, value);
                    Message.LogTrace(ListeAnimaux[index].Nom);
                }

            }


        }

        public Animal this[string nom]
        {
            //get // log trace
            get
            {
                Animal a = null;
                foreach (Animal x in ListeAnimaux)
                {
                    if (x.Nom == nom)
                    {
                        a = x;
                    }
                }
                Message.LogTrace("On retourne l'animal " + a.Nom);
                return a;


            }
        }

        public bool SupprimerAnimal(string nom)
        {
            //log trace
            Animal a = ListeAnimaux.FirstOrDefault(x => x.Nom == nom);
            if (a != null)
            {
                Message.LogTrace("L'animnal" + a.Nom + "a été supprimé");
                ListeAnimaux.Remove(a);
                return true;

            }
            return false;
        }

        public override string ToString()
        {
            string stResult = "";
            foreach (Animal x in ListeAnimaux)
            {
                stResult += x.GetType().Name + " " + x.Nom + " " + x.Poids + " " + x.DernierRepas;
            }
            return stResult;
        }

    }
}
