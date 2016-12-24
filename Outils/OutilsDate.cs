using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outils
{
    public class OutilsDate
    {
        /// <summary>
        /// retourne un entier positif, etant le nombre d'années complete entre les deux dates
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static int anneeDiff(DateTime d1, DateTime d2)
        {
            int res = 0;

            if (d1>= d2)
            {
                res = d1.Year - d2.Year;
                if (d1.DayOfYear < d2.DayOfYear && res!=0)
                {
                    --res;
                }
            }
            else
            {
                res = d2.Year - d1.Year;
                if(d2.DayOfYear < d1.DayOfYear && res!=0)
                {
                    --res;
                }
            }


            return res;
        }

        /// <summary>
        /// Vérifie si une date est ultérieur à la date d'aujourd'hui
        /// </summary>
        /// <param name="d"></param>
        public static void verifDate(DateTime d)
        {
            if(d>DateTime.Now)
            {
                throw new ApplicationException("La date est ultérieure à la date d'aujourd'hui");
            }
        }
    }
}
