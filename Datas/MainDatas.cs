using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Elements.Datas
{
    class MainDatas
    {
        /// <summary>
        /// Température maximale gérée par le programme (en Kelvin)
        /// </summary>
        public readonly double MaxTemperature = 1000000000;

        public readonly Color AlkaliMetalColor = Color.Maroon;
        public readonly Color AlkalineEarthColor = Color.Orange;
        public readonly Color TransitionMetalColor = Color.Yellow;
        public readonly Color BasicMetalColor = Color.Green;
        public readonly Color MetalloidColor = Color.LightBlue;
        public readonly Color NonMetalColor = Color.Blue;
        public readonly Color HalogeneColor = Color.Magenta;
        public readonly Color NobleGazColor = Color.Purple;
        public readonly Color LathanidesColor = Color.LightGray;
        public readonly Color ActinidesColor = Color.Gray;

        public List<Elements.Datas.Atom> AtomsList
        {
            get
            {
                var newlist = new List<Elements.Datas.Atom>();

                // Période 1

                newlist.Add(new Atom("Hydrogène", "H", Atom.AtomsFamily.NonMetal, 1, 1, 1, 1, 1.0, 2.2, 13.81, 20.28));
                newlist.Add(new Atom("Hélium", "He", Atom.AtomsFamily.NobleGas, 1, 18, 2, 4, 4.0, -1, 0.95, 4.216));

                // Période 2

                newlist.Add(new Atom("Lithium", "Li", Atom.AtomsFamily.AlkaliMetal, 2, 1, 3, 7, 6.9, 1.0, 453.7, 1615));
                newlist.Add(new Atom("Beryllium", "Be", Atom.AtomsFamily.AlkalineEarth, 2, 2, 4, 9, 9.0, 1.6, 1560, 3243));
                newlist.Add(new Atom("Bore", "B", Atom.AtomsFamily.Metalloid, 2, 13, 5, 11, 10.8, 1.6, 2365, 4275));
                newlist.Add(new Atom("Carbone", "C", Atom.AtomsFamily.NonMetal, 2, 14, 6, 12, 12.0, 2.6, 3825, 5100));
                newlist.Add(new Atom("Azote", "N", Atom.AtomsFamily.NonMetal, 2, 15, 7, 14, 14.0, 3.0, 63.15, 77.344));
                newlist.Add(new Atom("Oxygène", "O", Atom.AtomsFamily.NonMetal, 2, 16, 8, 16, 16.0, 3.4, 54.8, 90.188));
                newlist.Add(new Atom("Fluor", "F", Atom.AtomsFamily.Halogen, 2, 17, 9, 19, 19.0, 4.0, 53.55, 85));
                newlist.Add(new Atom("Néon", "Ne", Atom.AtomsFamily.NobleGas, 2, 18, 10, 20, 20.2, -1, 24.55, 27.1));

                // Période 3

                newlist.Add(new Atom("Sodium", "Na", Atom.AtomsFamily.AlkaliMetal, 3, 1, 11, 23, 23.0, 0.9, 371, 1156));
                newlist.Add(new Atom("Magnésium", "Mg", Atom.AtomsFamily.AlkalineEarth, 3, 2, 12, 24, 24.3, 1.3, 922, 1380));
                newlist.Add(new Atom("Aluminium", "Al", Atom.AtomsFamily.BasicMetal, 3, 13, 13, 27, 27.0, 1.6, 933.5, 2740));
                newlist.Add(new Atom("Silicium", "Si", Atom.AtomsFamily.Metalloid, 3, 14, 14, 28, 28.1, 1.9, 1683, 2630));
                newlist.Add(new Atom("Phosphore", "P", Atom.AtomsFamily.NonMetal, 3, 15, 15, 31, 31.0, 2.2, 317.3, 553));
                newlist.Add(new Atom("Souffre", "S", Atom.AtomsFamily.NonMetal, 3, 16, 16, 32, 32.1, 2.6, 392.2, 717.82));
                newlist.Add(new Atom("Chlore", "Cl", Atom.AtomsFamily.Halogen, 3, 17, 17, 35, 35.5, 3.2, 172.17, 239.18));
                newlist.Add(new Atom("Argon", "Ar", Atom.AtomsFamily.NobleGas, 3, 18, 18, 40, 39.9, -1, 83.95, 87.45));

                // Période 4

                newlist.Add(new Atom("Potassium", "K", Atom.AtomsFamily.AlkaliMetal, 4, 1, 19, 39, 39.1, 0.8, 336.8, 1033));
                newlist.Add(new Atom("Calcium", "Ca", Atom.AtomsFamily.AlkalineEarth, 4, 2, 20, 40, 40.1, 1.0, 1112, 1757));
                newlist.Add(new Atom("Scandium", "Sc", Atom.AtomsFamily.TransitionMetal, 4, 3, 21, 45, 45.0, 1.4, 1814, 3109));
                newlist.Add(new Atom("Titane", "Ti", Atom.AtomsFamily.TransitionMetal, 4,4, 22, 48, 47.9, 1.5, 1945, 3560));
                newlist.Add(new Atom("Vanadium", "V", Atom.AtomsFamily.TransitionMetal, 4, 5, 23, 51, 50.9, 1.6, 2163, 3650));
                newlist.Add(new Atom("Chrome", "Cr", Atom.AtomsFamily.TransitionMetal, 4, 6, 24, 52, 52.0, 1.7, 2180, 2945));
                newlist.Add(new Atom("Manganèse", "Mn", Atom.AtomsFamily.TransitionMetal, 4, 7, 25, 55, 54.9, 1.6, 1518, 2335));
                newlist.Add(new Atom("Fer", "Fe", Atom.AtomsFamily.TransitionMetal, 4, 8, 26, 56, 55.8, 1.8, 1811, 3134));
                newlist.Add(new Atom("Cobalt", "Co", Atom.AtomsFamily.TransitionMetal, 4, 9, 27, 59, 58.9, 1.9, 1768, 3200));
                newlist.Add(new Atom("Nickel", "Ni", Atom.AtomsFamily.TransitionMetal, 4, 10, 28, 58, 58.7, 1.9, 1728, 3003));
                newlist.Add(new Atom("Cuivre", "Cu", Atom.AtomsFamily.TransitionMetal, 4, 11, 29, 64, 63.5, 1.9, 1356.6, 2840));
                newlist.Add(new Atom("Zinc", "Zn", Atom.AtomsFamily.TransitionMetal, 4, 12, 31, 64, 65.4, 1.7, 692.73, 1180));
                newlist.Add(new Atom("Gallium", "Ga", Atom.AtomsFamily.BasicMetal, 4, 13, 31, 69, 69.7, 1.6, 302.92, 2478));
                newlist.Add(new Atom("Germanium", "Ge", Atom.AtomsFamily.Metalloid, 4, 14, 32, 74, 72.6, 1.8, 1211.5, 3107));
                newlist.Add(new Atom("Arsenic", "As", Atom.AtomsFamily.Metalloid, 4, 15, 33, 75, 74.9, 2.0, 1090, 887));
                newlist.Add(new Atom("Selenium", "Se", Atom.AtomsFamily.NonMetal, 4, 16, 34, 80, 79.0, 2.4, 494, 958));
                newlist.Add(new Atom("Brome", "Br", Atom.AtomsFamily.Halogen, 4, 17, 35, 79, 79.9, 3.0, 265.95, 331.85));
                newlist.Add(new Atom("Krypton", "Kr", Atom.AtomsFamily.NobleGas, 4, 18, 36, 84, 83.8, -1, 116, 120.85));

                // Période 5

                newlist.Add(new Atom("Rubidium", "Rb", Atom.AtomsFamily.AlkaliMetal, 5, 1, 37, 85, 85.5, 0.8, 312.63, 961));
                newlist.Add(new Atom("Strontium", "Sr", Atom.AtomsFamily.AlkalineEarth, 5, 2, 38, 88, 87.6, 1.0, 1042, 1655));
                newlist.Add(new Atom("Yttrium", "Y", Atom.AtomsFamily.TransitionMetal, 5, 3, 39, 89, 88.9, 1.2, 1795, 3611));
                newlist.Add(new Atom("Zirconium", "Zr", Atom.AtomsFamily.TransitionMetal, 5, 4, 40, 90, 91.2, 1.3,2128, 4682));
                newlist.Add(new Atom("Niobium", "Nb", Atom.AtomsFamily.TransitionMetal, 5, 5, 41, 93, 92.9, 1.6, 2742, 5015));
                newlist.Add(new Atom("Molybdene", "Mo", Atom.AtomsFamily.TransitionMetal, 5, 6, 42, 98, 95.9, 2.2, 2896, 4912));
                newlist.Add(new Atom("Technetium", "Tc", Atom.AtomsFamily.TransitionMetal, 5, 7, 43, 98, 98, 2.1, 2477,  4538));
                newlist.Add(new Atom("Ruthenium", "Ru", Atom.AtomsFamily.TransitionMetal, 5, 8, 44, 102, 101.1, 2.2, 2610, 4425));
                newlist.Add(new Atom("Rhodium", "Rh", Atom.AtomsFamily.TransitionMetal, 5, 9, 45, 103, 102.9, 2.3, 2236, 3970));
                newlist.Add(new Atom("Palladium", "Pd", Atom.AtomsFamily.TransitionMetal, 5, 10, 46, 106, 106.4, 2.2, 1825, 3240));
                newlist.Add(new Atom("Argent", "Ag", Atom.AtomsFamily.TransitionMetal, 5, 11, 47, 107, 107.9, 1.9, 1235.08, 2436));
                newlist.Add(new Atom("Cadmium", "Cd", Atom.AtomsFamily.TransitionMetal, 5, 12, 48, 114, 112.4, 1.7, 594.26, 1040));
                newlist.Add(new Atom("Indium", "In", Atom.AtomsFamily.BasicMetal, 5, 13, 49, 115, 114.8, 1.7, 429.78, 2350));
                newlist.Add(new Atom("Etain", "Sn", Atom.AtomsFamily.BasicMetal, 5, 14, 50, 120, 118.7, 1.8, 505.12, 2876));
                newlist.Add(new Atom("Antimoine", "Sb",Atom.AtomsFamily.Metalloid, 5, 15, 51, 121, 121.7, 1.9, 903.91, 1860));
                newlist.Add(new Atom("Tellure", "Te", Atom.AtomsFamily.Metalloid, 5, 16, 52, 130, 127.6, 2.1, 722.66, 1261));
                newlist.Add(new Atom("Iode", "I", Atom.AtomsFamily.Halogen ,5, 17, 53, 127, 126.9, 2.7, 386.85, 457.4));
                newlist.Add(new Atom("Xenon", "Xe", Atom.AtomsFamily.NobleGas, 5, 18, 54, 129, 131.3, -1, 161.39, 165.1));

                // Période 6

                newlist.Add(new Atom("Cesium", "Cs", Atom.AtomsFamily.AlkaliMetal, 6, 1, 55, 133, 132.9, 0.8, 301.54, 944)) ;
                newlist.Add(new Atom("Baryum", "Ba", Atom.AtomsFamily.AlkalineEarth, 6, 2, 56, 138, 137.9, 0.9, 1002, 2118)) ;
                newlist.Add(new Atom("Lanthane", "La", Atom.AtomsFamily.Lathanides, 6, 3, 57, 139, 138.9, 1.1, 1191, 3737));

                newlist.Add(new Atom("Cerium", "Ce", Atom.AtomsFamily.Lathanides, Atom.SpecialSeries.Lathanides, 1, 58, 140, 140.1, 1.1, 1071, 3715));
                newlist.Add(new Atom("Praséodyme", "Pr", Atom.AtomsFamily.Lathanides, Atom.SpecialSeries.Lathanides, 2, 59, 141, 140.9, 1.1, 1204, 3785));
                newlist.Add(new Atom("éeodyme", "Nd", Atom.AtomsFamily.Lathanides, Atom.SpecialSeries.Lathanides, 3, 60, 142, 144.2, 1.1, 1294, 3347));
                newlist.Add(new Atom("Promethium", "Pm", Atom.AtomsFamily.Lathanides, Atom.SpecialSeries.Lathanides, 4, 61, 146, 145, -1, 1315, 3273));
                newlist.Add(new Atom("Samarium", "Sm", Atom.AtomsFamily.Lathanides, Atom.SpecialSeries.Lathanides, 5, 62, 152, 150.4, 1.2, 1347, 2067));
                newlist.Add(new Atom("Europium", "Eu", Atom.AtomsFamily.Lathanides, Atom.SpecialSeries.Lathanides, 6, 63, 153, 152.0, 1.2, 1095, 1800));
                newlist.Add(new Atom("Gadolinium", "Gd", Atom.AtomsFamily.Lathanides, Atom.SpecialSeries.Lathanides, 7, 64, 158, 157.3, 1.2, 1585, 3545));
                newlist.Add(new Atom("Terbium", "Tb", Atom.AtomsFamily.Lathanides, Atom.SpecialSeries.Lathanides, 8, 65, 159, 158.9, 1.2, 1629, 3500));
                newlist.Add(new Atom("Dysprosium", "Dy", Atom.AtomsFamily.Lathanides, Atom.SpecialSeries.Lathanides, 9, 66, 164, 162.5, 1.2, 1685, 2840));
                newlist.Add(new Atom("Holmium", "Ho", Atom.AtomsFamily.Lathanides, Atom.SpecialSeries.Lathanides, 10, 67, 165, 164.9, 1.2, 1747, 2968));
                newlist.Add(new Atom("Erbium", "Er", Atom.AtomsFamily.Lathanides, Atom.SpecialSeries.Lathanides, 11, 68, 166, 167.3, 1.2, 1802, 3140));
                newlist.Add(new Atom("Thulium", "Tm", Atom.AtomsFamily.Lathanides, Atom.SpecialSeries.Lathanides, 12, 69, 169, 168.9, 1.3, 1818, 2223));
                newlist.Add(new Atom("Ytterbium", "Yb", Atom.AtomsFamily.Lathanides, Atom.SpecialSeries.Lathanides, 13, 70, 174, 173.0, 1.3, 1092, 1469));
                newlist.Add(new Atom("Lutétium", "Lu", Atom.AtomsFamily.Lathanides, Atom.SpecialSeries.Lathanides, 14, 71, 175, 175.0, 1.0, 1936, 3668));

                newlist.Add(new Atom("Hafnium", "Hf", Atom.AtomsFamily.TransitionMetal, 6, 4, 72, 180, 178.5, 1.3, 2504, 4875));
                newlist.Add(new Atom("Tantale", "Ta", Atom.AtomsFamily.TransitionMetal, 6, 5, 73, 181, 180.9, 1.5, 3293, 5730));
                newlist.Add(new Atom("Tungstene", "W", Atom.AtomsFamily.TransitionMetal, 6, 6, 74, 184, 183.8, 1.7, 3695, 5825));
                newlist.Add(new Atom("Rhenium", "Re", Atom.AtomsFamily.TransitionMetal, 6, 7, 75, 187, 186.2, 1.9, 3455, 5870));
                newlist.Add(new Atom("Osmium", "Os", Atom.AtomsFamily.TransitionMetal, 6, 8, 76, 192, 190.2, 2.2, 3300, 5300));
                newlist.Add(new Atom("Iridium", "Ir", Atom.AtomsFamily.TransitionMetal, 6,9, 77, 193, 192.2, 2.2, 2720, 4700));
                newlist.Add(new Atom("Platine", "Pt", Atom.AtomsFamily.TransitionMetal, 6, 10, 78, 195, 195.1, 2.2, 2042.1, 4100));
                newlist.Add(new Atom("Or", "Au", Atom.AtomsFamily.TransitionMetal, 6, 11, 79, 197, 197.0, 2.4, 1337.58, 3243));
                newlist.Add(new Atom("Mercure", "Hg", Atom.AtomsFamily.TransitionMetal, 6, 12, 80, 202, 200.6, 1.9, 234.31, 629.88));
                newlist.Add(new Atom("Thallium", "Tl", Atom.AtomsFamily.BasicMetal, 6, 13, 81, 205, 204.4, 1.8, 577, 1746));
                newlist.Add(new Atom("Plomb", "Pb", Atom.AtomsFamily.BasicMetal, 6, 14, 82, 208, 207.2, 1.8, 600.65, 2023));
                newlist.Add(new Atom("Bismuth", "Bi", Atom.AtomsFamily.BasicMetal, 6, 15, 83, 209, 209.0, 1.9, 544.59, 1837));
                newlist.Add(new Atom("Polonium", "Po", Atom.AtomsFamily.Metalloid, 6, 16, 84, 210, 209, 2.0, 527, 1235));
                newlist.Add(new Atom("Asiate", "At", Atom.AtomsFamily.Halogen, 6, 17, 85, 210, 210, 2.2, 575, 610));
                newlist.Add(new Atom("Radon", "Rn", Atom.AtomsFamily.NobleGas, 6, 18, 86, 222, 222, -1, 202, 211.5));

                // Période 7

                newlist.Add(new Atom("Francium", "Fr", Atom.AtomsFamily.AlkaliMetal, 7, 1, 87, 223, 223, 0.7, 300, 950));
                newlist.Add(new Atom("Radium", "Ra", Atom.AtomsFamily.AlkalineEarth, 7, 2, 88, 226, 226, 0.9, 1233, 2010));
                newlist.Add(new Atom("Actinium", "Ac", Atom.AtomsFamily.Actinides, 7, 3, 89, 227, 227, 1.1, 1500, 3500));

                newlist.Add(new Atom("Thorium", "Th", Atom.AtomsFamily.Actinides, Atom.SpecialSeries.Actinindes, 1, 90, 232, 232.0, -1, 2023, 5961));
                newlist.Add(new Atom("Protactinium", "Pa", Atom.AtomsFamily.Actinides, Atom.SpecialSeries.Actinindes, 2, 91, 231, 231.0, -1, 1841, 4300));
                newlist.Add(new Atom("Uranium", "U", Atom.AtomsFamily.Actinides, Atom.SpecialSeries.Actinindes, 3, 92, 238, 238.0, -1, 1405, 4404));
                newlist.Add(new Atom("Neptunium", "Np", Atom.AtomsFamily.Actinides, Atom.SpecialSeries.Actinindes, 4, 93, 237, 237.0, -1, 913, 4447));
                newlist.Add(new Atom("Plutonium", "Pu", Atom.AtomsFamily.Actinides, Atom.SpecialSeries.Actinindes, 5, 94, 244, 244, -1, 912.5, 3505));
                newlist.Add(new Atom("Americium", "Am", Atom.AtomsFamily.Actinides, Atom.SpecialSeries.Actinindes, 6, 95, 243, 243, -1, 1449, 2880));
                newlist.Add(new Atom("Curium", "Cm", Atom.AtomsFamily.Actinides, Atom.SpecialSeries.Actinindes, 7, 96, 247, 247, -1, 1613, 3383));
                newlist.Add(new Atom("Berkelium", "Bk", Atom.AtomsFamily.Actinides, Atom.SpecialSeries.Actinindes, 8, 97, 247, 247, -1, 1259, 2900));
                newlist.Add(new Atom("Californium", "Cf", Atom.AtomsFamily.Actinides, Atom.SpecialSeries.Actinindes, 9, 98, 251, 251, -1, 1173, 1743));
                newlist.Add(new Atom("Einsteinium", "Es", Atom.AtomsFamily.Actinides, Atom.SpecialSeries.Actinindes, 10, 99, 254, 252, -1, 1133, 1269));
                newlist.Add(new Atom("Fermium", "Fm", Atom.AtomsFamily.Actinides, Atom.SpecialSeries.Actinindes, 11, 100, 257, 257, -1, 1800, -1));
                newlist.Add(new Atom("Mandevevium", "Md", Atom.AtomsFamily.Actinides, Atom.SpecialSeries.Actinindes, 12, 101, 258, 258, -1, 1100, -1));
                newlist.Add(new Atom("Nobelium", "No", Atom.AtomsFamily.Actinides, Atom.SpecialSeries.Actinindes, 13, 102, 259, 259, -1, 1100, -1));
                newlist.Add(new Atom("Lawrencium", "Lr", Atom.AtomsFamily.Actinides, Atom.SpecialSeries.Actinindes, 14, 103, 260, 262, -1, 1900, -1));

                newlist.Add(new Atom("Rutherfordium", "Rf", Atom.AtomsFamily.TransitionMetal, 7, 4, 104, -1, -1, -1, 2400, 5800));
                newlist.Add(new Atom("Dubnium", "Db", Atom.AtomsFamily.TransitionMetal, 7, 5, 105, -1, -1, -1, -1, -1));
                newlist.Add(new Atom("Searborgium", "Sg", Atom.AtomsFamily.TransitionMetal, 7, 6, 106, -1, -1, -1, -1, -1));
                newlist.Add(new Atom("Bohrium", "Bh", Atom.AtomsFamily.TransitionMetal, 7, 7, 107, -1, -1, -1, -1, -1));
                newlist.Add(new Atom("Hassium", "Hs", Atom.AtomsFamily.TransitionMetal, 7, 8, 108, -1, -1, -1, -1, -1));
                newlist.Add(new Atom("Meitnerium", "Mt", Atom.AtomsFamily.TransitionMetal, 7, 9, 109, -1, -1, -1, -1, -1));
                newlist.Add(new Atom("Darmstadtium", "Ds", Atom.AtomsFamily.TransitionMetal, 7, 10, 110, -1, -1, -1, -1, -1));
                newlist.Add(new Atom("Roentgenium", "Rg", Atom.AtomsFamily.TransitionMetal, 7, 11, 111, -1, -1, -1, -1, -1));
                newlist.Add(new Atom("Copernicium", "Cn", Atom.AtomsFamily.TransitionMetal, 7, 12, 112, -1, -1, -1, -1, 357));
                newlist.Add(new Atom("Nihonium", "Uut", Atom.AtomsFamily.BasicMetal, 7, 13, 113, -1, -1, -1, 700, 1430));
                newlist.Add(new Atom("Flerovium", "Fl", Atom.AtomsFamily.BasicMetal, 7, 14, 114, -1, -1, -1, 340, 420));
                newlist.Add(new Atom("Moscovium", "Uup", Atom.AtomsFamily.BasicMetal, 7, 15, 115, -1, -1, -1, 670, 1400));
                newlist.Add(new Atom("Livermorium", "Lv", Atom.AtomsFamily.BasicMetal, 7, 16, 116, -1, -1, -1, -1, -1));
                newlist.Add(new Atom("Tenesse", "Uus", Atom.AtomsFamily.Halogen, 7, 17, 117, -1, -1, -1, 623, 883));
                newlist.Add(new Atom("Oganesson", "Uuo", Atom.AtomsFamily.NobleGas, 7, 18, 118, -1, -1, -1, -1, -1));


                return newlist;
            }
        }

    }
}
