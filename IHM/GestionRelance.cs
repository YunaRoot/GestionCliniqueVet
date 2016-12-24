using BLL;
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
    public partial class GestionRelances : Form
    {
        private RelancesBLL instanceRelancesBll = new RelancesBLL();
        public GestionRelances()
        {
            InitializeComponent();
        }

        private void GestionRelances_Load(object sender, EventArgs e)
        {
            dataGridViewRelances.AutoGenerateColumns = false;
            dataGridViewRelances.DataSource = instanceRelancesBll.Get();
        }
    }
}
