using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Banque
{
    class Banque
    {
        private List<Compte> mesComptes;
        private List<Type> mesTypes;
        public Banque()
        {
            mesComptes = new List<Compte>();
            mesTypes = new List<Type>();
        }


        public void ajouter(Compte c)
        {
            this.mesComptes.Add(c);
        }
        public void ajouter(int numero, string nom, int solde, int decouvert)
        {
            Compte c = new Compte(numero, nom, solde, decouvert);
            this.mesComptes.Add(c);

        }

        public Compte rendCompte(int num)
        {
            Compte Cnum = null;
            foreach (Compte cpt in this.mesComptes)
            {
                if (cpt.GetNum() == num)
                {
                    Cnum = cpt;
                }
            }
            return Cnum;
        }

        public void ajouterType(string code, string libelle)
        {
            mesTypes.Add(new Type(code, libelle));
        }
        public void ajouterType(Type unType)
        {
            mesTypes.Add(unType);
        }

        public override string ToString()
        {
            return $"Type : {mesTypes} ";

        }

        public Type GetType(string typ)
        {
            Type tip = new Type();
            foreach (Type tip2 in this.mesTypes)
            {
                if (tip2.getCode() == typ)
                {
                    tip = tip2;
                }

            }

            return tip;

        }

        public List<Type> GetListType()
        {
            return this.mesTypes;
        }
    }
}
