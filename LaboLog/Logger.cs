using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Windows.Forms;

namespace LaboLog
{
    //Exemple de Singleton - creer une classe Logger pour la partie 1 

    public class Logger
    {
        private static Logger instance;
        private string path = Path.GetDirectoryName(Application.ExecutablePath);
        private string fichier = "Log.txt";

        private Logger()
        {
            //...
          //  ouverturefichier(path, fichier,"Début de la form");
        }

        private FileStream ouverturefichier(string fichier, string nomFichier, string text)
        {
            string chemin = fichier + @"\" + nomFichier;
            FileStream fs;

            StreamWriter sw;

            if (File.Exists(chemin))
            {
                fs = new FileStream(chemin, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(chemin, FileMode.Create, FileAccess.Write);
            }

            sw = new StreamWriter(fs);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.WriteLine(text);
            sw.Flush();
            sw.Close();
            return fs;
        }
        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
        }


        public void LogError(Exception ex)
        {

          

            ouverturefichier(path, fichier,"***ERREUR***"+ex.Message);

        }
        public void LogTrace(string message)
        {
            ouverturefichier(path, fichier, message);


        }

        public string ReadLogFIle()
        {
           string result = "";

            FileStream fs;
            string chemin = path + @"\" + fichier;
            try
            {

                fs = new FileStream(chemin, FileMode.Open, FileAccess.Read);
                //fs = File.OpenRead(fileName);

                byte[] b = new byte[fs.Length];
                UTF8Encoding tmp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    result += tmp.GetString(b);
                }

                fs.Close();

            }
            catch (Exception e)
            {
                result = "Error : " + e.Message;
            }

            return result;

        }
    }
}
