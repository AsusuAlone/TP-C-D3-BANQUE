using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Banque
{
    class Mouvement
    {
        private DateTime datemvt;
        private int montant;
        private Type Type;

        public Mouvement(DateTime datemvt, int montant, Type type)
        {
            this.datemvt = datemvt;
            this.montant = montant;
            this.Type = type;
        }
        public Mouvement()
        {
            DateTime date = new DateTime(0000, 01, 00);
            this.datemvt = date;
            this.montant = 0;
        }
    }
}
