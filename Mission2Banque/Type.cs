using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Banque
{
    class Type
    {
        private string code;
        private string libelle;

        public Type(string code,string libelle)
        {
            this.code = code;
            this.libelle = libelle;
        }

        public Type()
        {
            this.code = "";
            this.libelle = "";
        }

        public string getCode()
        {
            return this.code;
        }

        public override string ToString()
        {
            return $"code : {code} libelle : {libelle}";
        }
    }
}
