using Outils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Représente un animal
    /// </summary>
    public class Animal
    {
        #region champs
        private string nomAnimal;
        private char sexe;
        private string couleur;
        private string race;
        private string espece;
        private string tatouage;
        #endregion

        #region props
        /// <summary>
        /// Identifiant unique de l'animal
        /// </summary>
        public Guid CodeAnimal { get; set; }

        /// <summary>
        /// Identifiant unique du propriétaire
        /// </summary>
        public Guid CodeClient { get; set; }

        /// <summary>
        /// Description des antécédents de l'animal
        /// </summary>
        public string Antecedent { get; set; }

        /// <summary>
        /// Determine si le dossier est archivé ou non
        /// </summary>
        public bool Archive { get; set; }

        /// <summary>
        /// Nom de l'animal
        /// </summary>
        public string NomAnimal
        {
            get { return nomAnimal; }
            set { nomAnimal = value.ToUpper(); }
        }

        /// <summary>
        /// Determine le sex de l'animal, M pour masculin, F pour feminin, H pour hermaphrodite
        /// </summary>
        public char Sexe
        {
            get { return sexe; }
            set { sexe = char.Parse(value.ToString().ToUpper()); }
        }

        /// <summary>
        /// Couleur de l'animal
        /// </summary>
        public string Couleur
        {
            get { return couleur; }
            set { couleur = OutilsString.FirstInUpper(value); }
        }

        /// <summary>
        /// Race de l'animal
        /// </summary>
        public string Race
        {
            get { return race; }
            set { race = value.ToUpper(); ; }
        }

        /// <summary>
        /// Espece de l'animal
        /// </summary>
        public string Espece
        {
            get { return espece; }
            set { espece = OutilsString.FirstInUpper(value); }
        }

        /// <summary>
        /// Tatouage de l'animal
        /// </summary>
        public string Tatouage
        {
            get { return tatouage; }
            set { tatouage = value.ToUpper(); }
        }
        #endregion

        #region constructeurs
        /// <summary>
        /// Constructeur vide de la classe Animal
        /// </summary>
        public Animal()
        {

        }

        /// <summary>
        /// Constructeur assignant uniquement l'ID d'un Animal, utile pour le DELETE du CRUD
        /// </summary>
        /// <param name="id"></param>
        public Animal(Guid id) : this()
        {
            this.CodeAnimal = id;
        }

        /// <summary>
        /// Constructeur assignant tous les champs et propirétés de la classe Animal
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nomAnimal"></param>
        /// <param name="sexe"></param>
        /// <param name="couleur"></param>
        /// <param name="race"></param>
        /// <param name="espece"></param>
        /// <param name="tatouage"></param>
        public Animal(Guid id, string nomAnimal, char sexe, string couleur, string race, string espece, string tatouage) : this(id)
        {
            this.NomAnimal = nomAnimal;
            this.Sexe = sexe;
            this.Couleur = couleur;
            this.Race = race;
            this.Espece = espece;
            this.Tatouage = tatouage;
        }
        #endregion

        #region methodes
        public override string ToString()
        {
            return this.nomAnimal;
        }
        #endregion
    }
}
