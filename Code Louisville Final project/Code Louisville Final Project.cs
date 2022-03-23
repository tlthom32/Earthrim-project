using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;
namespace Code_Louisville_Final_project
{
    public partial class appName : Form
    {
        private Player _player;


        public appName()
        {
            InitializeComponent();

            _player = new Player(10, 10, 20, 0, 1);


            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblXP.Text = _player.XP.ToString();
            lblLevel.Text = _player.Level.ToString();

        }

        private void btnNorth_Click(object sender, EventArgs e)
        {

        }

        private void btnWest_Click(object sender, EventArgs e)
        {

        }

        private void btnSouth_Click(object sender, EventArgs e)
        {

        }

        private void btnEast_Click(object sender, EventArgs e)
        {

        }

        private void btnUseWeapon_Click(object sender, EventArgs e)
        {

        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {

        }

        private void cboWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboPotions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
