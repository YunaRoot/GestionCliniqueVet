using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outils
{
    public static class OutilsString
    {
        /// <summary>
        /// Met en majuscule tous les premiers caractères de smots séparés par un espace
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string FirstInUpper(this string str)
        {

            string res = "";

            for (int i=0; i<str.Length; ++i)
            {
                
                if (i == 0)
                {
                    res += str[i].ToString().ToUpper();
                }

                else if(str[i] == ' ' && i!=str.Length-1)
                {
                    res += ' ';
                    res += str[i + 1].ToString().ToUpper();
                    ++i;
                }

                else
                {
                    res += str[i].ToString().ToLower();
                }
            }
            return res; 
        }

        /// <summary>
        /// Renvoie des exceptions si le code postal n'est pas confomr (5 caracteres numériques)
        /// </summary>
        /// <param name="cpo"></param>
        public static void VerifCodePostal(string cpo)
        {
            int a = 0;
            if (cpo.Length<5)
            {
                throw new ApplicationException("Code postal : nombre de caracteres invalide");
            }
            if(!int.TryParse(cpo, out a))
            {
                throw new ApplicationException("Code postal : type de caracteres invalide");
            }
        }

        /// <summary>
        /// Retourne une string former du paramètre séparer par des tirets tous les 'rang' caractères
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string SeparerParTirets(string str, int rang)
        {
            string res = "";
            str = str.Replace("-", "");
            int cpt = 0;
            for (int i = 0; i < str.Length; i++)
            {
                res += str[i];
                ++cpt;

                if(cpt % rang == 0)
                {
                    cpt = 0;
                    res += '-';
                }
            }
            if(res[res.Length-1]=='-')
            {
                res = res.Remove(res.Length - 1);
            }
            return res;
        }

        /// <summary>
        /// Supprime les tirets '-', les espaces ' ', et les points '.' de la chaine de caractère envoyée en paramètre
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string FormatageNumTel(string str)
        {
            str = str.Replace(".", "");
            str = str.Replace(" ", "");
            str = str.Replace("-", "");
            return str;

        }

        /// <summary>
        /// Renvoie des exceptions si le numéro de téléphone ne possède pas 10 chiffres;
        /// </summary>
        /// <param name="str"></param>
        public static void VerifNumTel(string str)
        {
            int a = 0;
            if (str.Length!=10)
            {
                throw new ApplicationException("Le numéro de téléphone n'est pas valide (nombre de caractères)");
            }

            foreach (char lettre in str)
            {
                if(!int.TryParse(lettre.ToString(), out a))
                {
                    throw new ApplicationException("Le numéro de téléphone n'est pas valide (saisir que des nombres)");
                }
            }
        }

        /// <summary>
        /// Verifie si la chaine de caractères envoyé en paramètre est au format date JJMMAAAA
        /// </summary>
        /// <param name="str"></param>
        public static void  VerifDateString(string str)
        {
            foreach (char caractere in str)
            {
                if(caractere <48 && caractere > 57)
                {
                    throw new ApplicationException("Date enregistré invalide (objet mal formé)");
                }
            }
        }

    }
}
