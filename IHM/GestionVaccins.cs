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
    /// <summary>
    /// Fenêtre GestionVaccins
    /// </summary>
    public partial class GestionVaccins : Form
    {
        private VaccinsBLL instanceVaccinsBll = new VaccinsBLL();
        /// <summary>
        /// Constructeur
        /// </summary>
        public GestionVaccins()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Chargement de la liste des vaccins à l'ouverture de la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GestionVaccins_Load(object sender, EventArgs e)
        {
            dataGridViewVaccins.AutoGenerateColumns = false;
            dataGridViewVaccins.DataSource = instanceVaccinsBll.Get();
            comboBoxNomVaccin.DataSource = instanceVaccinsBll.Get();
            //#######################################################################
            //#######################################################################
            //                      Pour mettre en rouge quand stock < 5
            //#######################################################################
            //for (int i = 0; i < dataGridViewVaccins.Rows.Count - 1; i++)
            //{
            //    if (((int)dataGridViewVaccins.Rows[i].Cells["QuantiteStock"].Value) < 5)
            //    {
            //        dataGridViewVaccins.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
            //    }
            //}
        }
        /// <summary>
        /// Vérifie la valeur du numericUpDownAjout : si supérieur à 0, numericUpdownSupp devient inaccessible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownAjout_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownSupp.Enabled = true;
            if (numericUpDownAjout.Value > 0)
            {
                numericUpDownSupp.Enabled = false;
            }
        }
        /// <summary>
        /// Vérifie la valeur du numericUpdownSupp : si supérieur à 0, numericUpDownAjout devient inaccessible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownSupp_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownAjout.Enabled = true;
            if (numericUpDownSupp.Value > 0)
            {
                numericUpDownAjout.Enabled = false;
            }
        }
        /// <summary>
        /// A la validation, ajoute le nombre de vaccins indiqué, ou vérifie que le stock est suffisant puis supprime
        /// le nombre de vaccins indiqué.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonValider_Click(object sender, EventArgs e)
        {
            Vaccin vaccinCourant = (Vaccin)comboBoxNomVaccin.SelectedItem;
            if (numericUpDownAjout.Enabled)
            {
                vaccinCourant.QuantiteStock += (int)numericUpDownAjout.Value;
            }
            else if (numericUpDownSupp.Enabled)
            {
                if (vaccinCourant.QuantiteStock >= numericUpDownSupp.Value)
                {
                    vaccinCourant.QuantiteStock -= (int)numericUpDownSupp.Value;
                }
                else
                {
                    throw new ApplicationException("Il n'y pas assez de vaccins en stock");
                }
            }
            instanceVaccinsBll.UpdateQuantite(vaccinCourant);
            dataGridViewVaccins.DataSource = instanceVaccinsBll.Get();
            numericUpDownAjout.Value = 0;
            numericUpDownSupp.Value = 0;
        }
    }
}
