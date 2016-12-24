using BLL;
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

namespace IHM
{
    public partial class Agenda : Form
    {
        private VeterinaireBLL instanceBllVeto = new VeterinaireBLL();

        public Agenda()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Charge la fenetre Agenda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Agenda_Load(object sender, EventArgs e)
        {
            comboBoxVeto.DataSource = instanceBllVeto.Get();
            //todo datagrid 


        }

        /// <summary>
        /// Ouvre le dossier medical de l'animal selectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDossierMedicale_Click(object sender, EventArgs e)
        {
            DossierMedical dossMed = new DossierMedical();
            dossMed.Show();
        }
    }
}
