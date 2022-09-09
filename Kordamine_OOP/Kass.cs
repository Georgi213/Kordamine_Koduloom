using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP
{
    class Kass : Koduloom
    {
        public enum toug { Sfinks, Burma, Ragdoll };
        public toug Toug;


        public Kass(toug Toug, string nimi, string varv, sugu loomaSugu, double kaal, int vanus, bool elav) : base(nimi, varv, loomaSugu, kaal, vanus, elav)
        {
            this.Toug = Toug;
        }
        public Kass(Kass kass)
        {
            this.Toug = kass.Toug;
            this.nimi = kass.nimi;
            this.varv = kass.varv;
            this.loomaSugu = kass.loomaSugu;
            this.kaal = kass.kaal;
            this.vanus = kass.vanus;
            this.elav = kass.elav;

        }
        public override void print_Haal()
        {
            Console.WriteLine("Myauu, Myauuu");
        }

        public override void print_Info()
        {
            Console.WriteLine($"Toug:{Toug} hamsters.\nNimi: {nimi}\nVärv on {varv}\nTa on {loomaSugu} ja tema kaal on {kaal} gramm\n{vanus} aastat vana {elav}\n");
        }

        public void muudatNimi(string uusNimi) { nimi = uusNimi; }
        public void muudatVarv(string uusVarv) { varv = uusVarv; }
        public void muudatKaal(int uusKaal) { kaal = uusKaal; }
        public void muudatVanus(int uusVanus) { vanus = uusVanus; }
    }
}
