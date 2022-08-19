using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricketGame
{
    public partial class TeamA_Players_Display : Form
    {
        Team teamA;

        public TeamA_Players_Display()
        {
            InitializeComponent();
            teamA = new Team();

        }

        private void TeamA_Players_Display_Load(object sender, EventArgs e)
        {

            //foreach (Player P in teamA.TeamA_prop)
            //{

            //    rtb_teamA_Display.Text = P.Display();
            //    rtb_teamA_Display.Text += "\n\n";

            //}
        }

    }
}
