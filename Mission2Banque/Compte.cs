using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Banque
{
    class Compte
    {
        private int numero;
        private string nom;
        private double solde;
        private double decouvert;
        private Compte Cpt;
        private List<Mouvement> mesMouvements;

        /// <summary>
        /// Le constructeur de la classe compte
        /// </summary>
        /// <param name="num"></param>
        /// <param name="Nom"></param>
        /// <param name="Solde"></param>
        /// <param name="Decouvert"></param>

        public Compte(int num, string Nom, double Solde, double Decouvert)
        {
            this.numero = num;
            this.nom = Nom;
            this.solde = Solde;
            this.decouvert = Decouvert;
            this.mesMouvements = new List<Mouvement>();
        }

        public Compte()
        {
            this.numero = 0;
            this.nom = "";
            this.solde = 0;
            this.decouvert = 0;
            this.mesMouvements = new List<Mouvement>();
        }

        /// get le numero de compte

        public int GetNum()
        {
            return this.numero;
        }

        /// Get le nom de compte

        public string GetNom()
        {
            return this.nom;

        }

        /// Get le solde de compte

        public double GetSolde()
        {
            return this.solde;
        }
 
        /// Get le montant du decouvert autorisé

        public double GetDecouvertAutorise()
        {
            return this.decouvert;
        }

        public override string ToString()
        {
            return $"Numero : {numero} Nom : {nom} Solde : {solde} Découvert autorisé : {decouvert}";
        }

        /// Permet de créditer une somme au compte

        public void Crediter(double n)
        {

            this.solde = this.solde + n;

        }

        /// Permet de debiter une somme du compte

        public void Debiter(double n)
        {
            bool debiter = false;
            if (this.solde + (this.decouvert * (-1)) >= n)
            {
                debiter = true;
                if (this.solde > 0)
                {
                    this.solde = this.solde - n;
                }
                else
                {
                    this.solde = 0;
                    this.decouvert = this.decouvert + n;
                }
            }

        }

        /// Parmet de Transfere une somme d'un compte à un autre

        public void Transfere(double n, Compte cpt)
        {
            this.Debiter(n);
            cpt.Crediter(n);


        }

        /// Permet de savoir si le compte est supérieur à un autre

        public bool superieur(Compte cpt)
        {
            bool sup = false;
            if (this.solde > cpt.solde)
            {
                sup = true;
            }

            return sup;
        }

        /// Permet de savoir si le compte est inférieur à un autre compte
 
        public bool inferieur(Compte cpt)
        {
            bool sup = false;
            if (this.solde < cpt.solde)
            {
                sup = true;
            }

            return sup;
        }

        public List<Mouvement> GetMouvement()
        {
            return this.mesMouvements;
        }
        public void ajouterMouvement(int num, DateTime date, Type type)
        {
            Mouvement mouv = new Mouvement(date, num, type);
            this.mesMouvements.Add(mouv);

            string code = type.getCode();
            if (code == "dch" || code == "des" || code == "vir")
            {
                this.Crediter(num);
            }
            else
            {
                this.Debiter(num);
            }
        }
        public List<Mouvement> GetListMouv()
        {
            return this.mesMouvements;
        }
    }
}
