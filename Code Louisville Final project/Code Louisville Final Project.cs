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

            Location location = new Location(1, "Home", "This is your house.");
            location.ID = 1;
            location.Name = "Home";
            location.Description = "This is your house.";

            _player = new Player();

            _player.currentHitPoints = 10;
            _player.maximumHitPoints = 10;
            _player.gold = 20;
            _player.XP = 0;
            _player.level = 1;

            lblHitPoints.Text = _player.currentHitPoints.ToString();
            lblGold.Text = _player.gold.ToString();
            lblXP.Text = _player.XP.ToString();
            lblLevel.Text = _player.level.ToString();

        }       
    }
}
