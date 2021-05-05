using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFerme
{
    public enum enuStyleDeChien { Compagnie, Garde}
    public class Chien:Animal
    {
        public enuStyleDeChien Style { get; set; }
         public Chien(string pNom, double pPoid, enuStyleDeChien pStyle)
            :base(pNom, pPoid)
        {
            Style = pStyle;
        }
        public override string Infos
        {
            get
            {
                return base.Infos + "Prix de location : " + Style.ToString() + "/h";
            }
        }
    }
}
