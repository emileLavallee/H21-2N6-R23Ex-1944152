using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFerme
{
    public class Vache:Animal
    {
        public double Production { get; set; }

        public Vache(string pNom, double pPoid, double pProduction)
           : base(pNom, pPoid)
        {
            Production = pProduction;
        }
        public override string Infos
        {
            get
            {
                return base.Infos + "Prix de location : " + Production.ToString() + "/h";
            }
        }
    }
}
