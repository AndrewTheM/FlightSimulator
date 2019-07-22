using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightSimulator
{
    public class Dispatcher
    {
        private static readonly Random rand = new Random();

        public string Name { get; }
        public int PenaltyPoints { get; private set; }

        private readonly int weatherCorrection;

        public Dispatcher(string name)
        {
            Name = name;
            weatherCorrection = rand.Next(-200, 200);
            PenaltyPoints = 0;
        }

        public void AnalyzeData(object sender, OnMoveEventArgs e)
        {
            if (e.Velocity > 1000)
            {
                PenaltyPoints += 100;
                MessageBox.Show($"Dispatcher {Name}: You have broken the speed limit! Slow down right now!");
            }
            else if (e.InFlight && (e.Velocity == 0 || e.Height == 0))
                if (FrmPlane.GetInstance().lblGoal.Text.Contains("1000"))
                {
                    FrmPlane.GetInstance().plane.Image = Properties.Resources.boom;
                    throw new Exception("The plane has crashed!");
                }
                else if (e.Velocity == 0 && e.Height == 0)
                    throw new Exception("You have successfully landed the plane!");

            if (e.Velocity > 50)
            {
                int recommendedHeight = 7 * e.Velocity - weatherCorrection;
                int diff = Math.Abs(recommendedHeight - e.Height);
                if (e.InFlight)
                    if (diff > 300 && diff <= 600)
                        PenaltyPoints += 25;
                    else if (diff > 600 && diff <= 1000)
                        PenaltyPoints += 50;
                if (diff > 1000)
                {
                    FrmPlane.GetInstance().plane.Image = Properties.Resources.boom;
                    throw new Exception("The plane has crashed!");
                }
                if (PenaltyPoints >= 1000)
                    throw new Exception("You are unsuitable to fly!");
                FrmPlane.GetInstance().listRecom.Items.Add($"{recommendedHeight} m");
            }
        }
    }
}
