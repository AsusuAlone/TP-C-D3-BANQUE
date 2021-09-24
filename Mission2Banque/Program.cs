using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Banque
{
    class Program
    {
        static void Main(string[] args)
        {
            Banque b = new Banque();
            Compte c = new Compte(50, "Eric", 1500, -500);
            b.ajouter(c);
            b.ajouterType("ch", "chèque débité");
            b.ajouterType("pre", "prélèvement");
            b.ajouterType("dab", "retrait en distributeur");
            b.ajouterType("ret", "retrait guichet ");
            b.ajouterType("vir", "virement sur compte");
            b.ajouterType("dch", "chèque déposé");
            b.ajouterType("des", "dépôt d’espèce");
            b.rendCompte(45657).ajouterMouvement(200, new DateTime(2012, 09, 11),b.GetType("vir")); ; ;
            Console.ReadKey();
        }
    }
}
