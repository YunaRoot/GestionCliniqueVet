using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace IHM
{
    /// <summary>
    /// Représente la fenetre d'ajout de veterinaire, appeler depuis la GestionVeterinaire
    /// </summary>
    public partial class EcranAjoutVet : Form
    {
        public EcranAjoutVet()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ajoute un vétérinaire a la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btValiderVet_Click(object sender, EventArgs e)
        {
            try
            {
                Veterinaire vet = new Veterinaire();
                vet.NomVeto = tbNomVet.Text;
                vet.MotPasse = tbMotPasse.Text;
                VeterinaireBLL instance = new VeterinaireBLL();
                instance.Create(vet);
                MessageBox.Show("Ajout effectué");
                this.Close();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
