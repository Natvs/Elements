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
    public partial class PeriodicTable : Form
    {
        public List<Elements.Controls.AtomBox> AtomsBoxesList = new List<Controls.AtomBox>();

        /// <summary>
        /// Déclare une nouvelle fenètre "Tableau des éléments".
        /// </summary>
        public PeriodicTable()
        {
            InitializeComponent();
            colorModeBox.TextChanged += new EventHandler(ColorModeBox_TextChanged);
            temperatureUpDown.ValueChanged += new EventHandler(TemperatureUpDown_ValueChanged);

            var datas = new Elements.Datas.MainDatas();

            temperatureUpDown.Maximum = (decimal)datas.MaxTemperature;

            var atoms = datas.AtomsList;
            for (int i = 0; i < atoms.Count; i++)
            {
                var atom = atoms[i];
                var atombox = new Elements.Controls.AtomBox(atom, false);
                AtomsBoxesList.Add(atombox);
                if (atom.Period > 0 && atom.Column > 0)
                {
                    mainAtomsPanel.Controls.Add(atombox, atom.Column - 1, atom.Period - 1);
                }
                else if (atom.Serie != Datas.Atom.SpecialSeries.None && atom.SerieNumber > 0)
                {
                    if (atom.Serie == Datas.Atom.SpecialSeries.Lathanides)
                    {
                        lathanidesPanel.Controls.Add(atombox, atom.SerieNumber, 0);
                    }
                    else if (atom.Serie == Datas.Atom.SpecialSeries.Actinindes)
                    {
                        actinidesPanel.Controls.Add(atombox, atom.SerieNumber, 0);
                    }
                }
            }
        }

        private void ColorModeBox_TextChanged(object sender, EventArgs e)
        {
            if (colorModeBox.Text == "Par famille")
            {
                temperaturePanel.Enabled = false;
                for (int i = 0; i < AtomsBoxesList.Count; i++) { AtomsBoxesList[i].SetColorByFamily(); }
            }
            else if (colorModeBox.Text == "Par état")
            {
                temperaturePanel.Enabled = true;
                for (int i = 0; i < AtomsBoxesList.Count; i++) { AtomsBoxesList[i].SetColorByState(temperatureUpDown.Value); }
            }
        }
        private void TemperatureUpDown_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < AtomsBoxesList.Count; i++) { AtomsBoxesList[i].SetColorByState(temperatureUpDown.Value); }
        }
    }
}
