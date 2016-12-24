using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHM
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region objets a la volé pour test sans bdd
            Client proprietaire = new Client();
            proprietaire.NomClient = "NomTest";
            proprietaire.PrenomClient = "PrenomTest";
            proprietaire.CodeClient = Guid.NewGuid();
            proprietaire.CodePostal = "123456";
            proprietaire.Adresse1 = "adresse";
            proprietaire.Adresse2 = "";
            proprietaire.Assurance = "Assurance";
            proprietaire.Archive = false;
            proprietaire.Email = "adresse mail";
            proprietaire.NumTel = "0102030405";
            proprietaire.Remarque = "une remarque au hasard";
            proprietaire.Ville = "Une Ville";

            Animal chien = new Animal();
            chien.CodeAnimal = Guid.NewGuid();
            chien.Antecedent = "Probleme de diabete";
            chien.Archive = false;
            chien.CodeClient = proprietaire.CodeClient;
            chien.Couleur = "noir";
            chien.Espece = "Canis Canis";
            chien.Race = "Labrador";
            chien.NomAnimal = "Rex";
            chien.Sexe = 'M';
            chien.Tatouage = "123-456-OP";

            Veterinaire veto = new Veterinaire();
            veto.Archive = false;
            veto.CodeVeto = Guid.NewGuid();
            veto.MotPasse = "8426poiu";
            veto.NomVeto = "NomVetoTest";

            Facture facture = new Facture();
            facture.Archive = false;
            facture.Client = proprietaire;
            facture.DateFacture = new DateTime(2016, 10, 24);
            facture.Etat = 0;
            facture.NumFacture = Guid.NewGuid();
            facture.RappelEnvoye = new DateTime(2016, 11, 10);
            facture.TotalFacture = 95.90;

            Consultation consultation = new Consultation();
            consultation.AnimalConsulte = chien;
            consultation.Archive = false;
            consultation.CodeConsultation = Guid.NewGuid();
            consultation.Commentaire = "Ceci est un commentaire très pertinent";
            consultation.Date = new DateTime(2016, 10, 25);
            consultation.Etat = EEtatConsultation.FacturationPossible;
            consultation.facture = facture;
            consultation.Veto = veto;
            #endregion
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GestionVeterinaire());
            //Application.Run(new MenuPrincipal());
            //Application.Run(new GestionClients());
            //Application.Run(new EcranConsultation(consultation));
            Application.Run(new MenuPrincipal());
        }
    }
}
