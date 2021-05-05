using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFerme
{
    
    public class Cheval:Animal
    {
        public decimal PrixLocation { get; set; }
        public Cheval(string pNom, double pPoid, decimal pPrixLocation)
            :base(pNom,pPoid)
        {
            PrixLocation = pPrixLocation;
        }

        public override string Infos
        {
            get
            {
                return base.Infos + "Prix de location : " + PrixLocation.ToString("C0") + "/h";
            }
        }
    }
}
