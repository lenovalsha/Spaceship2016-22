using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spaceship2016
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            SpaceShip.mainForm = this;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SpaceShip.RefreshDraw(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpaceShip.Ships.Add(
                new SpaceShip(
                   SpaceShip.rand.Next(0, this.ClientSize.Width - 100),
                   SpaceShip.rand.Next(0, this.ClientSize.Height - 100), 5)
                    );
        }

        private void btnFighter_Click(object sender, EventArgs e)
        {
            FighterShip.Ships.Add(
                new FighterShip(
                   FighterShip.rand.Next(0, this.ClientSize.Width - 100),
                   FighterShip.rand.Next(0, this.ClientSize.Height - 100), 1)
                );
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            CargoShip.Ships.Add(
               new CargoShip(
                  CargoShip.rand.Next(0, this.ClientSize.Width - 100),
                  CargoShip.rand.Next(0, this.ClientSize.Height - 100), 30)
               );
        }

        private void btnHealth_Click(object sender, EventArgs e)
        {
            foreach (SpaceShip ship in SpaceShip.Ships)
            {
                ship.RenewHealth();
            }
        }

        private void btnReloadPhoton_Click(object sender, EventArgs e)
        {
            foreach (SpaceShip x in SpaceShip.Ships)
            {
                if(x is FighterShip fire)
                {
                    fire.ReloadPhoton();
                }

            }

        }

        private void btnReloadCargo_Click(object sender, EventArgs e)
        {
            foreach (SpaceShip x in SpaceShip.Ships)
            {
                if (x is CargoShip cargo)
                {
                    cargo.ReloadCargo();
                }
            }
        }
    }
}
