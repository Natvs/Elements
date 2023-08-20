using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elements
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            atomsButton.Click += new EventHandler(AtomsButton_Click);

            var datas = new Elements.Datas.MainDatas();
        }

        public void AtomsButton_Click(object sender, EventArgs e)
        {
            var newperiodictable = new Elements.Dialogs.Atoms.PeriodicTable();
            newperiodictable.Show();
        }
    }
}
