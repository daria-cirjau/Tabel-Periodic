using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabelulPeriodic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn = (Button)sender;
            string url="https://ro.wikipedia.org/wiki/";
            switch (Convert.ToInt32(btn.Tag))
            {
                case 1:url += "Bor";break;
                case 2:url += "Carbon";break;
                case 3:url += "Azot"; break;
                case 4: url += "Oxigen"; break;
                case 5: url += "Fluor"; break;
                case 6: url += "Sodiu"; break;
                case 7: url += "Hidrogen"; break;
                case 8: url += "Litiu"; break;
                case 9: url += "Beriliu"; break;
                case 10: url += "Magneziu"; break;
                case 11: url += "Potasiu"; break;
                case 12: url += "Calciu"; break;
                case 13: url += "Rubidiu"; break;
                case 14: url += "Stronțiu"; break;
                case 15: url += "Cesiu"; break;
                case 16: url += "Bariu"; break;
                case 17: url += "Franciu"; break;
                case 18: url += "Radiu"; break;
                case 19: url += "Scandiu"; break;
                case 20: url += "Titan"; break;
                case 21: url += "Vanadiu"; break;
                case 22: url += "Crom"; break;
                case 23: url += "Mangan"; break;
                case 24: url += "Fier"; break;
                case 25: url += "Cobalt"; break;
                case 26: url += "Nichel"; break;
                case 27: url += "Cupru"; break;
                case 28: url += "Zinc"; break;
                case 29: url += "Ytriu"; break;
                case 30: url += "Zirconiu"; break;
                case 31: url += "Niobiu"; break;
                case 32: url += "Molibden"; break;
                case 33: url += "Technețiu"; break;
                case 34: url += "Ruteniu"; break;
                case 35: url += "Rodiu"; break;
                case 36: url += "Paladiu"; break;
                case 37: url += "Argint"; break;
                case 38: url += "Cadmiu"; break;
                case 39: url += "Hafniu"; break;
                case 40: url += "Tantal"; break;
                case 41: url += "Wolfram"; break;
                case 42: url += "Reniu"; break;
                case 43: url += "Osmiu"; break;
                case 44: url += "Iridiu"; break;
                case 45: url += "Platină"; break;
                case 46: url += "Aur"; break;
                case 47: url += "Mercur"; break;
                case 48: url += "Rutherfordiu"; break;
                case 49: url += "Dubniu"; break;
                case 50: url += "Seaborgiu"; break;
                case 51: url += "Bohriu"; break;
                case 52: url += "Hassiu"; break;
                case 53: url += "Meitneriu"; break;
                case 54: url += "Darmstadtiu"; break;
                case 55: url += "Roentgeniu"; break;
                case 56: url += "Coperniciu"; break;
                case 57: url += "Aluminiu"; break;
                case 58: url += "Galiu"; break;
                case 59: url += "Indiu"; break;
                case 60: url += "Taliu"; break;
                case 61: url += "Nihoniu"; break;
                case 62: url += "Siliciu"; break;
                case 63: url += "Germaniu"; break;
                case 64: url += "Staniu"; break;
                case 65: url += "Plumb"; break;
                case 66: url += "Fleroviu"; break;
                case 67: url += "Fosfor"; break;
                case 68: url += "Arsen"; break;
                case 69: url += "Stibiu"; break;
                case 70: url += "Bismut"; break;
                case 71: url += "Moscoviu"; break;
                case 72: url += "Sulf"; break;
                case 73: url += "Seleniu"; break;
                case 74: url += "Telur"; break;
                case 75: url += "Poloniu"; break;
                case 76: url += "Livermoriu"; break;
                case 77: url += "Clor"; break;
                case 78: url += "Brom"; break;
                case 79: url += "Iod"; break;
                case 80: url += "Astatin"; break;
                case 81: url += "Tennessin"; break;
                case 82: url += "Heliu"; break;
                case 83: url += "Neon"; break;
                case 84: url += "Argon"; break;
                case 85: url += "Kripton"; break;
                case 86: url += "Xenon"; break;
                case 87: url += "Radon"; break;
                case 88: url += "Oganesson"; break;
                case 89: url += "Lantan"; break;
                case 90: url += "Ceriu"; break;
                case 91: url += "Praseodim"; break;
                case 92: url += "Neodim"; break;
                case 93: url += "Promețiu"; break;
                case 94: url += "Samariu"; break;
                case 95: url += "Europiu"; break;
                case 96: url += "Gadoliniu"; break;
                case 97: url += "Terbiu"; break;
                case 98: url += "Disprosiu"; break;
                case 99: url += "Holmiu"; break;
                case 100: url += "Erbiu"; break;
                case 101: url += "Tuliu"; break;
                case 102: url += "Yterbiu"; break;
                case 103: url += "Lutețiu"; break;
                case 104: url += "Actiniu"; break;
                case 105: url += "Toriu"; break;
                case 106: url += "Protactiniu"; break;
                case 107: url += "Uraniu"; break;
                case 108: url += "Neptuniu"; break;
                case 109: url += "Plutoniu"; break;
                case 110: url += "Americiu"; break;
                case 111: url += "Curiu"; break;
                case 112: url += "Berkeliu"; break;
                case 113: url += "Californiu"; break;
                case 114: url += "Einsteiniu"; break;
                case 115: url += "Fermiu"; break;
                case 116: url += "Mendeleviu"; break;
                case 117: url += "Nobeliu"; break;
                case 118: url += "Lawrenciu"; break;




            }
            Form f0rm = new Form2(url);
            f0rm.ShowDialog();

        }
    }
}
