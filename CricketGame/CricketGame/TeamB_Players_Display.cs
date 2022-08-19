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
    public partial class TeamB_Players_Display : Form
    {
        Team teamB;
        public TeamB_Players_Display()
        {
            InitializeComponent();
            teamB = new Team();
        }

        private void TeamB_Players_Display_Load(object sender, EventArgs e)
        {
            //foreach (Player P in teamB.TeamB_prop)
            //{

            //    rtb_teamB_Display.Text = P.Display();
            //    rtb_teamB_Display.Text += "\n\n";

            //}
        }
    }
}
