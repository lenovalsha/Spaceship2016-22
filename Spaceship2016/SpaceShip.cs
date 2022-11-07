using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Spaceship2016
{
    class SpaceShip
    {
       
        #region Static components
        public static Random rand = new Random();
        public static Form mainForm; //pointer
        public static List<SpaceShip> Ships = new List<SpaceShip>();
        private static Timer myTimer = new Timer();
        static SpaceShip()      // static constructor only runs once when first ship is instantiated
        {
            myTimer.Interval = 100;
            myTimer.Tick += MyTime_Tick1;
            myTimer.Enabled = true;
        }
        public SpaceShip()
        {

        }

        private static void MyTime_Tick1(object sender, EventArgs e)
        {
            foreach (SpaceShip s in Ships)
            {
                s.Move();
            }
            CheckForCrash();
            mainForm.Invalidate(false);
        }                                   // call RefreshDraw method with PaintEventArgs 
        public static void RefreshDraw(PaintEventArgs e)   // called from mainForm
        {
            foreach (SpaceShip s in Ships)
                s.Draw(e.Graphics);
        }

        private static bool CrashTest(SpaceShip One, SpaceShip Two)
        {
            if (One.X + One.Width < Two.X)
                return false;
            if (Two.X + Two.Width < One.X)
                return false;
            if (One.Y + One.Height < Two.Y)
                return false;
            if (Two.Y + Two.Height < One.Y)
                return false;
            return true;
        }
        public static void CheckForCrash()
        {
            if (Ships.Count >= 2)
            {
                for (int i = 0; i < Ships.Count; i++)
                    for (int j = i; j < Ships.Count; j++)
                        if (i != j)                   // don't check for a collision with itself
                            if (CrashTest(Ships[i], Ships[j]))  // check for collision, true is collision
                            {
                                Ships[i].Collision(minusLife);
                                Ships[j].Collision(minusLife);
                            }
            }
        }
        #endregion
        #region Fields
        protected Rectangle myRectangle;
        protected Label myHealthLabel;
        protected int Health = 100;
        protected int xStep;
        protected int yStep;
        protected static int minusLife;

        #endregion
        #region Constructors
         public SpaceShip(int x, int y, int tmpminusLife)
        {
            myRectangle = new Rectangle();
            myRectangle.X = x;
            myRectangle.Y = y;
            myRectangle.Width = 85;
            myRectangle.Height = 85;
            myHealthLabel = new Label();
            myHealthLabel.Text = "Health=100";
            myHealthLabel.BackColor = Color.Red;
            myHealthLabel.Width = 65;
            myHealthLabel.Left = x;
            myHealthLabel.Top = y;
            mainForm.Controls.Add(myHealthLabel);
            xStep = rand.Next(1,5);
            yStep = rand.Next(1,5);
            minusLife = tmpminusLife;
        }

        
        #endregion
        #region Properties
        public int X { get { return myRectangle.X; } }
        public int Y { get { return myRectangle.Y; } }
        public int Width { get { return myRectangle.Width; } }
        public int Height { get { return myRectangle.Height; } }
        #endregion
        #region Methods
        public virtual void Move()
        {
            if (Health != 0)
            {
                myRectangle.X += xStep;
                myRectangle.Y += yStep;

                if (myRectangle.X <= 0)
                    xStep *= -1;
                if (myRectangle.X + myRectangle.Width >= mainForm.ClientSize.Width)
                    xStep *= -1;
                if (myRectangle.Y <= 0)
                    yStep *= -1;
                if (myRectangle.Y + myRectangle.Height >= mainForm.ClientSize.Height)
                    yStep *= -1;
            }
        }
        public void Collision(int num)
        {
            Health -= num;
            if (Health < 0) Health = 0;
            xStep *= -1;
            yStep *= -1;
        }
        
        public void RenewHealth()
        {
            Health = 100;
        }
        //override the draw --> not done yet
        public virtual void Draw(Graphics gr)
        {
            SolidBrush solid = new SolidBrush(Color.FromArgb(255, 255, 255, 0));
            gr.FillRectangle(solid, myRectangle);
            //gr.DrawRectangle(new Pen(Color.Red), myRectangle);
            myHealthLabel.Top = myRectangle.Y+10;
            myHealthLabel.Left = myRectangle.X+10;
            myHealthLabel.Text = "Health=" + Health.ToString();
        }
        #endregion
    }
}
