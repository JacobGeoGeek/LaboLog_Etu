using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboLog
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        Zoo zoo = new Zoo();
        Logger lg = Logger.Instance;

        private void btnAjouterZoo_Click(object sender, EventArgs e)
        {
            //log trace et log error
            try
            {
                lg.LogTrace("L'usager à appuyer sur le button Ajouter au Zoo");
                if (rbChat.Checked)
                {
                    Animal a = new Chat(txtNomAnimal.Text);
                    zoo.AjouterAnimal(a);
                }
                else
                {
                    Animal a = new Chien(txtNomAnimal.Text);
                    zoo.AjouterAnimal(a);
                }
             
                txtStatus.Text = "Vous avez ajouter un animal dans le zoo: "+txtNomAnimal.Text;
            }
            catch (FelideException ex)
            {
                lg.LogError(ex);
                txtStatus.Text = "***ERREUR FelideException****"+ ex.Message;

            }
            catch (CanideException ex)
            {
                lg.LogError(ex);
                txtStatus.Text = "***ERREUR CanideException****" + ex.Message;

            }
            catch (ChatException ex)
            {
                lg.LogError(ex);
                txtStatus.Text = "***ERREUR ChatException****" + ex.Message;
            }
            catch (ChienException ex)
            {
                lg.LogError(ex);
                txtStatus.Text = "***ERREUR ChienException****" + ex.Message;
            }
            catch (AnimalException ex)
            {

                lg.LogError(ex);
                txtStatus.Text = "***ERREUR AnimalException****" + ex.Message;
            }
            catch (Exception ex)
            {
                lg.LogError(ex);
                txtStatus.Text = "***ERREUR Exception****" + ex.Message;
            }


        }

        private void btnNourrir_Click(object sender, EventArgs e)
        {
            //log trace et log error
            try
            {
                lg.LogTrace("L'usager à appuyer sur le button Nourrir");
                lg.LogTrace("L'usager à nourrit l'animal" + txtNomNourrir.Text + ". La nourriture est: " + txtNourriture.Text);
              

                Animal Animalrechercher = zoo[txtNomNourrir.Text];
              
                    Animalrechercher.Mange(txtNourriture.Text);

                txtStatus.Text = "Vous avez nourrit " + txtNomNourrir.Text;
            }
            catch (FelideException ex)
            {
                lg.LogError(ex);
                txtStatus.Text = "***ERREUR FelideException****" + ex.Message;
            }
            catch (CanideException ex)
            {
                lg.LogError(ex);
                txtStatus.Text = "***ERREUR CanideException****" + ex.Message;
            }
            //catch (ChatException ex)
            //{
            //    lg.LogError(ex);
            //    txtStatus.Text = "***ERREUR ChatException****" + ex.Message;
            //}
            //catch (ChienException ex)
            //{
            //    lg.LogError(ex);
            //    txtStatus.Text = "***ERREUR ChienException****" + ex.Message;
            //}
            catch (Exception ex)
            {
                lg.LogError(ex);
                txtStatus.Text = "***ERREUR Exception****" + ex.Message;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //log trace et log error
            try
            {
                lg.LogTrace("L'usager à appuyer sur le button Définir un poids");
                lg.LogTrace("L'usager à défénit un poid à l'index"+txtIndexPoids.Text+"et le poids est de "+ txtPoids.Text);
                Animal aRechercher = zoo[int.Parse(txtIndexPoids.Text)];
            
                    aRechercher.Poids = int.Parse(txtPoids.Text);
                txtStatus.Text = "Vous défénit un poids à l'animal" + aRechercher.Nom;
            }
            //catch (FelideException ex)
            //{
            //    lg.LogError(ex);
            //    txtStatus.Text = "***ERREUR FelideException****" + ex.Message;
            //}
            //catch (CanideException ex)
            //{
            //    lg.LogError(ex);
            //    txtStatus.Text = "***ERREUR CanideException****" + ex.Message;
            //}
            catch (ChatException ex)
            {
                lg.LogError(ex);
                txtStatus.Text = "***ERREUR ChatException****" + ex.Message;
            }
            catch (ChienException ex)
            {
                lg.LogError(ex);
                txtStatus.Text = "***ERREUR ChienException****" + ex.Message;
            }
            catch (Exception ex)
            {
                lg.LogError(ex);
                txtStatus.Text = "***ERREUR Exception****" + ex.Message;
            }

        }

        private void btnafficherLeZoo_Click(object sender, EventArgs e)
        {
          richTextBox1.Text =  zoo.ToString();
        }

        private void btnReadLog_Click(object sender, EventArgs e)
        {
           richTextBox1.Text= lg.ReadLogFIle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
