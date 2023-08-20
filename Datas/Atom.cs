using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements.Datas
{
    public class Atom
    {

        /// <summary>
        /// Séries spéciales (présentées hors du tableau périodique)
        /// </summary>
        public enum SpecialSeries
        {
            None,
            Lathanides,
            Actinindes
        }

        /// <summary>
        /// Famille de l'atome
        /// </summary>
        public enum AtomsFamily
        {
            None,
            AlkaliMetal,
            AlkalineEarth,
            TransitionMetal,
            BasicMetal,
            Metalloid,
            NonMetal,
            Halogen,
            NobleGas,
            Lathanides,
            Actinides
        }

        /// <summary>
        /// Etat de l'atome
        /// </summary>
        public enum States
        {
            None,
            Gas,
            Liquid,
            Solid
        }

        /// <summary>
        /// Nom de l'atome
        /// </summary>
        public string Name { get; private set; } = "Unnamed";

        /// <summary>
        /// Symbôle de l'atome
        /// </summary>
        public string Symbol { get; private set; } = "Xxx";

        /// <summary>
        /// Période de l'atome
        /// </summary>
        public int Period { get; private set; } = 0;

        /// <summary>
        /// Numéro de la colonne
        /// </summary>
        public int Column { get; private set; } = 0;

        /// <summary>
        /// Série spéciale de l'atome
        /// </summary>
        public SpecialSeries Serie { get; private set; } = SpecialSeries.None;

        /// <summary>
        /// Numéro de l'atome dans la série
        /// </summary>
        public int SerieNumber { get; private set; } = 0;

        /// <summary>
        /// Famille de l'atome
        /// </summary>
        public AtomsFamily Family { get; private set; } = AtomsFamily.None;

        /// <summary>
        /// Numéro atomique de l'atome
        /// </summary>
        public int AtomicNumber { get; private set; } = 0;

        /// <summary>
        /// Nombre de masses de l'atome
        /// </summary>
        public int MassesNumber { get; private set; } = 0;

        /// <summary>
        /// Masse molaire de l'atome
        /// </summary>
        public double MolarMass { get; private set; } = 0;

        /// <summary>
        /// Electronégativité de l'atome
        /// </summary>
        public double Electronegativity { get; private set; } = 0;

        /// <summary>
        /// Température de fusion de l'atome
        /// </summary>
        public double Fusion { get; private set; } = 0;

        /// <summary>
        /// Température d'ébulition de l'atome
        /// </summary>
        public double Ebulition { get; private set; } = 0;

        /// <summary>
        /// Intervalle de l'atome en état solide
        /// </summary>
        public MyLibrary.Methods.Interval SolidInterval { get; private set; } = new MyLibrary.Methods.Interval(0, true, 0, true);

        /// <summary>
        /// Interval de l'atome en état liquide
        /// </summary>

        public MyLibrary.Methods.Interval LiquidInterval { get; private set; } = new MyLibrary.Methods.Interval(0, true, 0, true);

        /// <summary>
        /// Interval de l'atome en état gazeux
        /// </summary>
        public MyLibrary.Methods.Interval GasInterval { get; private set; } = new MyLibrary.Methods.Interval(0, true, 0, true);

        /// Nouvelles déclarations

        /// <summary>
        /// Déclare une nouvelle instance de Elements.Datas.Atom
        /// </summary>
        /// <param name="name">Nom</param>
        /// <param name="symbol">Symbôle</param>
        /// <param name="family">Famille</param>
        /// <param name="period">La période à laquelle appartient l'atome</param>
        /// <param name="column">La colonne à laquelle appartient l'atome</param>
        /// <param name="atomicnumber">Numéro atomique</param>
        /// <param name="massesnumber">Nombre de masses</param>
        /// <param name="molarmass">Masse molaire</param>
        /// <param name="electronegativity">Electronégativité</param>
        /// <param name="fusion">Température de fusion de l'atome</param>
        /// <param name="ebulition">Température d'ébulition de l'atome</param>
        public Atom(string name, string symbol, AtomsFamily family,
            int period, int column,
            int atomicnumber, int massesnumber,
            double molarmass, double electronegativity,
            double fusion, double ebulition)
        {
            Period = period; Column = column;
            Serie = SpecialSeries.None; SerieNumber = -1;

            InitialiseCommonDatas(name, symbol, family, atomicnumber, massesnumber, molarmass, electronegativity, fusion, ebulition);
        }

        /// <summary>
        /// Déclare une nouvelle instance de Elements.Datas.Atom
        /// </summary>
        /// <param name="name">Nom</param>
        /// <param name="symbol">Symbôle</param>
        /// <param name="family">Famille</param>
        /// <param name="serie">Série de l'atome (hors du tableau périodique)</param>
        /// <param name="serienumber">Numéro de série de l'atome</param>
        /// <param name="atomicnumber">Numéro atomique</param>
        /// <param name="massesnumber">Nombre de masses</param>
        /// <param name="molarmass">Masse molaire</param>
        /// <param name="electronegativity">Electronégativité</param>
        /// <param name="fusion">Température de fusion de l'atome</param>
        /// <param name="ebulition">Température d'ébulition de l'atome</param>
        public Atom(string name, string symbol, AtomsFamily family,
            SpecialSeries serie, int serienumber,
            int atomicnumber, int massesnumber,
            double molarmass, double electronegativity,
            double fusion, double ebulition)
        {
            Period = -1; Column = -1;
            Serie = serie; SerieNumber = serienumber;

            InitialiseCommonDatas(name, symbol, family, atomicnumber, massesnumber, molarmass, electronegativity, fusion, ebulition);
        }

        /// <summary>
        /// Déclare une nouvelle instance de Elements.Datas.Atom
        /// </summary>
        /// <param name="name">Nom</param>
        /// <param name="symbol">Symbôle</param>
        /// <param name="family">Famille</param>
        /// <param name="atomicnumber">Numéro atomique</param>
        /// <param name="massesnumber">Nombre de masses</param>
        /// <param name="molarmass">Masse molaire</param>
        /// <param name="electronegativity">Electronégativité</param>
        /// <param name="fusion">Température de fusion de l'atome</param>
        /// <param name="ebulition">Température d'ébulition de l'atome</param>
        public void InitialiseCommonDatas(string name, string symbol, AtomsFamily family,
            int atomicnumber, int massesnumber,
            double molarmass, double electronegativity,
            double fusion, double ebulition)
        {
            Name = name; Symbol = symbol; Family = family;
            AtomicNumber = atomicnumber; MassesNumber = massesnumber;
            MolarMass = molarmass; Electronegativity = electronegativity;
            Fusion = fusion; Ebulition = ebulition;

            var datas = new Elements.Datas.MainDatas();


            SolidInterval = new MyLibrary.Methods.Interval(-1, true, -1, true);
            LiquidInterval = new MyLibrary.Methods.Interval(-1, true, -1, true);
            GasInterval = new MyLibrary.Methods.Interval(-1, true, -1, true);
            if (Fusion > 0 && Ebulition > 0)
            {
                var minvalue = MyLibrary.Methods.Numeric.GetMin(Fusion, Ebulition);
                var maxvalue = MyLibrary.Methods.Numeric.GetNewValue(minvalue, Fusion, Ebulition);
                if (Fusion < Ebulition)
                {
                    SolidInterval = new MyLibrary.Methods.Interval(0, true, minvalue, false);
                    LiquidInterval = new MyLibrary.Methods.Interval(minvalue, true, maxvalue, false);
                    GasInterval = new MyLibrary.Methods.Interval(maxvalue, true, datas.MaxTemperature, true);
                }
                else
                {
                    SolidInterval = new MyLibrary.Methods.Interval(0, true, minvalue, false);
                    GasInterval = new MyLibrary.Methods.Interval(minvalue, true, maxvalue, false);
                    LiquidInterval = new MyLibrary.Methods.Interval(maxvalue, true, datas.MaxTemperature, true);
                }
            }

        }

        /// <summary>
        /// Obtient l'état de l'atome (solide, liquide ou gazeux).
        /// </summary>
        /// <param name="temperature">La température à laquelle est l'atome</param>
        /// <returns>L'état de l'atome</returns>
        public States GetState(double temperature)
        {
            if (SolidInterval.IsValueHeld(temperature)) { return States.Solid; }
            else if (LiquidInterval.IsValueHeld(temperature)) { return States.Liquid; }
            else if (GasInterval.IsValueHeld(temperature)) { return States.Gas; }
            return States.None;
        }

        /// <summary>
        /// Obtient la famille de l'atome.
        /// </summary>
        /// <returns>La famille de l'atome</returns>
        public string GetFamilyName()
        {
            if (Family == AtomsFamily.AlkaliMetal) { return "Métaux alcalins"; }
            else if (Family == AtomsFamily.AlkalineEarth) { return "Métaux alcalino-terreux"; }
            else if (Family == AtomsFamily.TransitionMetal) { return "Métaux de transition"; }
            else if (Family == AtomsFamily.BasicMetal) { return "Métaux pauvres"; }
            else if (Family == AtomsFamily.Metalloid) { return "Métalloïdes"; }
            else if (Family == AtomsFamily.NonMetal) { return "Non-métaux"; }
            else if (Family == AtomsFamily.Halogen) { return "Halogènes"; }
            else if (Family == AtomsFamily.NobleGas) { return "Gaz noble"; }
            else if (Family == AtomsFamily.Lathanides) { return "Lathanides"; }
            else if (Family == AtomsFamily.Actinides) { return "Actinides"; }
            return "Inconnue";
        }

        /// <summary>
        /// Obtient la couleur correspondante à la famille de l'atome.
        /// </summary>
        /// <returns>La couleur correspondate à la famille de l'atome</returns>
        public Color GetFamilyColor()
        {
            var datas = new Elements.Datas.MainDatas();
            if (Family == AtomsFamily.AlkaliMetal) { return datas.AlkaliMetalColor; }
            else if (Family == AtomsFamily.AlkalineEarth) { return datas.AlkalineEarthColor; }
            else if (Family == AtomsFamily.TransitionMetal) { return datas.TransitionMetalColor; }
            else if (Family == AtomsFamily.BasicMetal) { return datas.BasicMetalColor; }
            else if (Family == AtomsFamily.Metalloid) { return datas.MetalloidColor; }
            else if (Family == AtomsFamily.NonMetal) { return datas.NonMetalColor; }
            else if (Family == AtomsFamily.Halogen) { return datas.HalogeneColor; }
            else if (Family == AtomsFamily.NobleGas) { return datas.NobleGazColor; }
            else if (Family == AtomsFamily.Lathanides) { return datas.LathanidesColor; }
            else if (Family == AtomsFamily.Actinides) { return datas.ActinidesColor; }
            return Color.White;
        }
    }

}
