using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using Elements.Dialogs.Atoms;

namespace Elements.Controls
{
    public partial class AtomBox : UserControl
    {
        private static readonly Size DefSize = new Size(175, 175);
        private static readonly int SymbolFontSize = 25;
        private static readonly int InfosFontSize = 8;

        #region Properties

        /// <summary>
        /// Classe Elements.Datas.Atom qui contient les données de l'atome
        /// </summary>
        private Elements.Datas.Atom Datas { get; }

        /// <summary>
        /// Définit s'il faut montrer seulement le numéro atomique et le nombre de masse, ou plus.
        /// </summary>
        private bool ShowDetails { get; }

        #endregion

        /// <summary>
        /// Délare une nouvelle instance de Elements.Controls.Atom.
        /// Pour déclarer une nouvelle instance depuis le code, préférer la deuxième définition.
        /// </summary>
        public AtomBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Délare une nouvelle instance de Elements.Controls.Atom.
        /// </summary>
        /// <param name="atom">Eléments Elements.Datas.Atom contenant les données de l'atome.</param>
        /// <param name="showdetails">Définit s'il faut montrer seulement le numéro atomique et le nombre de masse, ou plus.</param>
        public AtomBox(Elements.Datas.Atom atom, bool showdetails)
        {
            InitializeComponent();
            mainLayoutPanel.Click += new EventHandler(Child_Click);
            symbolLabel.Click += new EventHandler(Child_Click);
            atomicNumberLabel.Click += new EventHandler(Child_Click);
            massesNumberLabel.Click += new EventHandler(Child_Click);
            electronegativityLabel.Click += new EventHandler(Child_Click);
            molarMassLabel.Click += new EventHandler(Child_Click);
            Resize += new EventHandler(Resized);

            Datas = atom;
            ShowDetails = showdetails;
            InitializeAtom();
        }

        #region Voids

        /// <summary>
        /// Rend visible les données de l'atome
        /// </summary>
        private void InitializeAtom()
        {
            if (Datas != null)
            {
                symbolLabel.Text = Datas.Symbol;
                atomicNumberLabel.Text = Datas.AtomicNumber.ToString();
                massesNumberLabel.Text = Datas.MassesNumber.ToString();
                if (Datas.MassesNumber >= 0) { massesNumberLabel.Text = Datas.MassesNumber.ToString(); }
                else { massesNumberLabel.Text = ""; }

                if (ShowDetails)
                {
                    if (Datas.Electronegativity >= 0) { electronegativityLabel.Text = Datas.Electronegativity.ToString(); }
                    else { electronegativityLabel.Text = ""; }
                    if (Datas.MassesNumber >= 0) { molarMassLabel.Text = Datas.MolarMass.ToString(); }
                    else { molarMassLabel.Text = ""; }
                }
                else
                {
                    electronegativityLabel.Text = "";
                    molarMassLabel.Text = "";
                }

                SetColorByFamily();
            }
        }

        /// <summary>
        /// Assigne une couleur à l'atome en fonction de sa famille
        /// </summary>
        public void SetColorByFamily()
        {
            if (Datas.Family != Elements.Datas.Atom.AtomsFamily.None)
            {
                BackColor = Datas.GetFamilyColor();
            }
        }

        /// <summary>
        /// Assigne une couleur à l'atome en fonction de son état à une température donné
        /// </summary>
        /// <param name="temperature">La temérature de l'atome</param>
        public void SetColorByState(decimal temperature)
        {
            var state = Datas.GetState((double)temperature);

            if (state == Elements.Datas.Atom.States.Solid) { BackColor = Color.Maroon; }
            else if (state == Elements.Datas.Atom.States.Liquid) { BackColor = Color.Orange; }
            else if (state == Elements.Datas.Atom.States.Gas) { BackColor = Color.Yellow; }
            else { BackColor = Color.White; }
        }

        #endregion

        #region Events

        private void Child_Click(object sender, EventArgs e)
        {
            this.OnClick(new EventArgs());

            var description = new AtomDescriptionForm(Datas);
            description.Show();
        }

        private void Resized(object sender, EventArgs e)
        {
            double coef = ((float)Size.Width / (float)DefSize.Width);
            symbolLabel.Font = new Font(FontFamily.GenericSansSerif, (int)((coef * SymbolFontSize) * 1.0));

            var infosnewsize = (int)((coef * InfosFontSize) * 1.8);

            atomicNumberLabel.Font = new Font(FontFamily.GenericSansSerif, infosnewsize);
            massesNumberLabel.Font = new Font(FontFamily.GenericSansSerif, infosnewsize);
            electronegativityLabel.Font = new Font(FontFamily.GenericSansSerif, infosnewsize);
            molarMassLabel.Font = new Font(FontFamily.GenericSansSerif, infosnewsize);
        }

        #endregion
    }
}
