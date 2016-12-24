using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RendezVousBLL
    {
        private RendezVousDAL dalRendezVous = new RendezVousDAL();

        #region Méthodes du CRUD
        public List<RendezVous> Get()
        {
            return null;
        }

        public RendezVous Get(Guid idVeto)
        {
            return dalRendezVous.Get(idVeto);
        }
        #endregion
    }
}
