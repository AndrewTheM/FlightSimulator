using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace FlightSimulator
{
    public class Airplane
    {
        public int Velocity { get; private set; }
        public int Height { get; private set; }
        public List<Dispatcher> Dispatchers { get; private set; }

        private bool inFlight;
        private int removedPoints;

        public delegate void InformDispatchers(object sender, OnMoveEventArgs e);
        public event InformDispatchers OnMove;

        public Airplane()
        {
            Velocity = 0;
            Height = 0;
            Dispatchers = new List<Dispatcher>();
            inFlight = false;
            removedPoints = 0;
        }

        public void AddDispatcher(string name)
        {
            Dispatchers.Add(new Dispatcher(name));
            OnMove += Dispatchers.Last().AnalyzeData;
        }

        public void RemoveDispatcher(string name)
        {
            Dispatcher dispatcher = Dispatchers.SingleOrDefault(disp => disp.Name == name);
            OnMove -= dispatcher.AnalyzeData;
            removedPoints += dispatcher.PenaltyPoints;
            Dispatchers.Remove(dispatcher);
        }

        private void Land()
        {
            inFlight = false;
            int totalPenalty = Dispatchers.Sum(disp => disp.PenaltyPoints) + removedPoints;
            MessageBox.Show("Penalty points: " + totalPenalty);
            FrmPlane.GetInstance().Close();
        }

        public void Move(PreviewKeyDownEventArgs e)
        {
            try
            {
                if (Dispatchers.Count >= 2)
                {
                    PictureBox plane = FrmPlane.GetInstance().plane;
                    
                    switch (e.KeyCode)
                    {
                        case Keys.Right:
                            {
                                if (e.Shift)
                                    Velocity += 100;
                                Velocity += 50;
                                break;
                            }
                        case Keys.Left:
                            if (Velocity >= 150 && e.Shift)
                                Velocity -= 150;
                            else if (Velocity >= 50)
                                Velocity -= 50;
                            break;
                        case Keys.Up:
                            if (Velocity > 50)
                            {
                                if (!inFlight)
                                {
                                    inFlight = true;
                                    MessageBox.Show("The goal is reached!\nNext goal: reach velocity of 1000 km/h");
                                    FrmPlane.GetInstance().lblGoal.Text = "Goal: reach velocity of 1000 km/h";
                                }
                                if (e.Shift)
                                {
                                    Height += 250;
                                    plane.Top -= 10;
                                }
                                Height += 250;
                                plane.Top -= 10;
                                plane.Left += Velocity / 50;
                            }
                            break;
                        case Keys.Down:
                            if (Height >= 500 && e.Shift)
                            {
                                Height -= 500;
                                plane.Top += 20;
                                plane.Left += Velocity / 50;
                            }
                            else if (Height >= 250)
                            {
                                Height -= 250;
                                plane.Top += 10;
                                plane.Left += Velocity / 50;
                            }
                            break;
                        case Keys.Escape: FrmPlane.GetInstance().Close(); break;
                    }

                    if (Velocity == 1000 && FrmPlane.GetInstance().lblGoal.Text.Contains("1000"))
                    {
                        MessageBox.Show("The goal is reached!\nFinal goal: land the plane.");
                        FrmPlane.GetInstance().lblGoal.Text = "Goal: land the plane.";
                    }
                    OnMove(this, new OnMoveEventArgs(Velocity, Height, inFlight));
                }
                else
                    MessageBox.Show("You need at least 2 dispatchers to take off!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("The flight is over. " + ex.Message);
                Land();
            }
        }
    }
}
