using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHM
{
    /// <summary>
    /// Représente la fenetre de modification de mot de passe d'un vétérinaire, accessible
    /// depuis la fenetre GestionVeterinaire
    /// </summary>
    public partial class EcranReinitialisationMdp : Form
    {
        /// <summary>
        /// Nouveau mot de passe du vétérinaire
        /// </summary>
        public string Password { get; private set; }

        /// <summary>
        /// Constructeur par défaut de la fenetre de modification de mot de passe
        /// </summary>
        public EcranReinitialisationMdp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Une fois le bouton de validation effectué, on verifie si les caracteres des deux textboxes 
        /// sont identiques, si le MDP n'est pas trop court, et si les caracteres utilisés sont
        /// valides
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if(tbNewPass.Text.Length<5)
            {
                MessageBox.Show("Mot de passe saisie trop court (5 caractères minimum)");
            }
            else if(tbCheckPass.Text != tbNewPass.Text)
            {
                MessageBox.Show("Les deux mots de passe saisies ne sont pas identiques");
            }
            else
            {
                this.Password = tbNewPass.Text;
                this.Close();
            }
            foreach (char caractere in tbCheckPass.Text)
            {
                if(caractere<48 || (caractere>57 && caractere<65) || (caractere>90 && caractere<97)
                    || caractere>122)
                {
                    throw new ApplicationException("Utilisez que des caractères Alpha-numérique SVP");
                }
            }
        }
    }
}
