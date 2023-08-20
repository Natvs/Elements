using MyLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elements.Dialogs.Atoms
{
    public partial class AtomDescriptionForm : Form
    {
        public AtomDescriptionForm(Elements.Datas.Atom datas)
        {
            InitializeComponent();

            nameLabel.Text = datas.Name;

            var boxeslist = new List<MyLibrary.CaracteristicBox>();

            boxeslist.Add(new CaracteristicBox("Symbôle de l'atome", datas.Symbol));
            boxeslist.Add(new CaracteristicBox("Numéro atomique", datas.AtomicNumber.ToString()));
            boxeslist.Add(new CaracteristicBox("Famille", datas.GetFamilyName()));

            //Nombre de masses
            if (datas.MassesNumber > 0) { boxeslist.Add(new CaracteristicBox("Nombre de masses", datas.MassesNumber.ToString())); }
            else { boxeslist.Add(new CaracteristicBox("Nombre de masses", "Donnée manquante")); }

            //Masse molaire
            if (datas.MassesNumber > 0) { boxeslist.Add(new CaracteristicBox("Masse molaire", datas.MolarMass.ToString() + " g/mol")); }
            else { boxeslist.Add(new CaracteristicBox("Masses molaire", "Donnée manquante")); }

            //Electronégativité
            if (datas.Electronegativity > 0) { boxeslist.Add(new CaracteristicBox("Electronégativité", datas.Electronegativity.ToString())); }
            else if (datas.Family != Datas.Atom.AtomsFamily.NobleGas) { boxeslist.Add(new CaracteristicBox("Electronégativité", "Donnée manquante")); }

            //Température de fusion
            if (datas.Fusion > 0) { boxeslist.Add(new CaracteristicBox("Température de fusion", datas.Fusion.ToString() + " K")); }
            else { boxeslist.Add(new CaracteristicBox("Température de fusion", "Donnée manquante")); }

            //Température d'ébulition
            if (datas.Ebulition > 0) { boxeslist.Add(new CaracteristicBox("Température d'ébulition", datas.Ebulition.ToString() + " K")); }
            else { boxeslist.Add(new CaracteristicBox("Température d'ébulition", "Donnée manquante")); }

            var boxescolor = datas.GetFamilyColor();
            for (int i = 0; i < boxeslist.Count; i++)
            {
                boxeslist[i].Size = new Size(caracteristicsPanel.Width - 15, 35);
                boxeslist[i].AutoForeColor = true;
                boxeslist[i].BackColor = boxescolor;

                caracteristicsPanel.Controls.Add(boxeslist[i]);
            }
        }

    }
}
