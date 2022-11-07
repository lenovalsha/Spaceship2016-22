using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spaceship2016
{
        #region Fightership
    class FighterShip : SpaceShip
    {
        protected Label myPhotonLabel;
        protected int photon = 20;
        public FighterShip(int x, int y, int tmpminusLife)
        {
            myRectangle = new Rectangle();
            myRectangle.X = x;
            myRectangle.Y = y;
            myRectangle.Width = 85;
            myRectangle.Height = 85;

            myHealthLabel = new Label();
            myHealthLabel.Text = "Health=100";
            myHealthLabel.BackColor = Color.Wheat;
            myHealthLabel.Width = 65;
            myHealthLabel.Left = x;
            myHealthLabel.Top = y;

            myPhotonLabel = new Label();
            myPhotonLabel.Text = "20";
            myPhotonLabel.Left = x;
            myPhotonLabel.Top = y;
            myPhotonLabel.BackColor = Color.Wheat;
            myPhotonLabel.Width = 65;
            mainForm.Controls.Add(myPhotonLabel);
            mainForm.Controls.Add(myHealthLabel);

            xStep = rand.Next(5, 10);
            yStep = rand.Next(5, 10);
            minusLife = tmpminusLife;
        }
        
        public override void Draw(Graphics gr)
        {

            SolidBrush solid = new SolidBrush(Color.FromArgb(169, 128, 128, 1));
            gr.FillEllipse(solid, myRectangle);
            myHealthLabel.Top = myRectangle.Y + 10;
            myHealthLabel.Left = myRectangle.X + 10;
            myHealthLabel.Text = "Health=" + Health.ToString();

            myPhotonLabel.Top = myRectangle.Y + 40;
            myPhotonLabel.Left = myRectangle.X + 10;
            myPhotonLabel.Text = "Photon: " + photon.ToString();

        }
        public void ReloadPhoton()
        {
            photon = 100;
        }
    }
    #endregion

    #region CargoShip
    class CargoShip : SpaceShip
    {
        protected Label Cargo;
        protected int cargo = 20;
        public CargoShip(int x, int y, int tmpminusLife)
        {
            myRectangle = new Rectangle();
            myRectangle.X = x;
            myRectangle.Y = y;
            myRectangle.Width = 85;
            myRectangle.Height = 85;

            myHealthLabel = new Label();
            myHealthLabel.Text = "Health=100";
            myHealthLabel.BackColor = Color.Wheat;
            myHealthLabel.Width = 65;
            myHealthLabel.Left = x;
            myHealthLabel.Top = y;

            Cargo = new Label();
            Cargo.Text = "20";
            Cargo.Left = x;
            Cargo.Top = y;
            Cargo.BackColor = Color.Wheat;
            Cargo.Width = 65;
            mainForm.Controls.Add(Cargo);
            mainForm.Controls.Add(myHealthLabel);

            xStep = 2;
            yStep = 2;
            minusLife = tmpminusLife;
        }

        public override void Draw(Graphics gr)
        {
            SolidBrush solid = new SolidBrush(Color.FromArgb(255, 255, 128, 1));
            gr.FillRectangle(solid, myRectangle);
            
            myHealthLabel.Top = myRectangle.Y + 10;
            myHealthLabel.Left = myRectangle.X + 10;
            myHealthLabel.Text = "Health=" + Health.ToString();

            Cargo.Top = myRectangle.Y + 40;
            Cargo.Left = myRectangle.X + 10;
            Cargo.Text = "Cargo: " + cargo.ToString();

        }

        public override void Move()
        {
            if (Health != 0)
            {
                myRectangle.X += xStep;
                myRectangle.Y += yStep;

                if (myRectangle.X <= 0)
                    xStep *= -1;
                if (myRectangle.X + myRectangle.Width >= mainForm.ClientSize.Width)
                {
                    xStep *= -1;
                    cargo =0;
                }
                if (myRectangle.Y <= 0)
                    yStep *= -1;
                if (myRectangle.Y + myRectangle.Height >= mainForm.ClientSize.Height)
                    yStep *= -1;
               
            }
        }
        public void ReloadCargo()
        {
            cargo = 100;
        }


    }
    #endregion
}

