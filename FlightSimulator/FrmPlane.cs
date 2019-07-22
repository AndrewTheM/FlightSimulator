using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlightSimulator
{
    public partial class FrmPlane : Form
    {
        private static FrmPlane instance;

        public static FrmPlane GetInstance()
        {
            return instance = instance ?? new FrmPlane();
        }

        public Airplane airplane = new Airplane();

        private FrmPlane()
        {
            InitializeComponent();
            
            listDisp.DataSource = airplane.Dispatchers;
            lblVelocity.Text = $"Velocity of the plane: {airplane.Velocity.ToString()} km/h";
            lblHeight.Text = $"Height of the flight: {airplane.Height.ToString()} m";
        }

        private bool IsValid(string str)
        {
            if (str == "" || str[0] == ' '|| airplane.Dispatchers.Any(disp => disp.Name == txtName.Text))
                return false;
            foreach (char ch in str)
                if (char.IsLetterOrDigit(ch))
                    return true;
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Location.X == 8)
            {
                btnRemove.Enabled = false;
                lblInsert.Visible = true;
                txtName.Visible = true;
                btnAdd.Location = new Point(175, 390);
                txtName.Focus();
            }
            else if (btnAdd.Location.X == 175)
            {
                if (IsValid(txtName.Text))
                {
                    airplane.AddDispatcher(txtName.Text);
                    listDisp.DataSource = null;
                    listDisp.DataSource = airplane.Dispatchers;
                    listDisp.DisplayMember = "Name";
                }
                else
                    MessageBox.Show("Incorrect input");

                lblInsert.Visible = false;
                txtName.Visible = false;
                txtName.Text = "";
                btnRemove.Enabled = true;
                btnAdd.Location = new Point(8, 284);
                btnControls.Focus();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (btnRemove.Location.Y == 284)
            {
                lblInsert.Visible = true;
                txtName.Visible = true;
                btnAdd.Enabled = false;
                btnRemove.Location = new Point(175, 390);
                txtName.Focus();
            }
            else if (btnRemove.Location.Y == 390)
            {
                try
                {
                    airplane.RemoveDispatcher(txtName.Text);
                    listDisp.DataSource = null;
                    listDisp.DataSource = airplane.Dispatchers;
                    listDisp.DisplayMember = "Name";
                }
                catch (Exception)
                {
                    MessageBox.Show("This dispatcher is not present");
                }

                lblInsert.Visible = false;
                txtName.Visible = false;
                txtName.Text = "";
                btnAdd.Enabled = true;
                btnRemove.Location = new Point(175, 284);
                btnControls.Focus();
            }
        }

        private void btnControls_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Velocity:\n+50 - →\n+150 - Shift + →\n-50 - ←\n-150 - Shift + ←\nHeight:\n+250 - ↑\n+500 - Shift + ↑\n-250 - ↓\n-500 - Shift + ↓");
        }

        private void btnControls_Leave(object sender, EventArgs e)
        {
            if (!txtName.Focused)
                btnControls.Focus();
        }

        private void btnControls_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            listRecom.Items.Clear();
            airplane.Move(e);
            lblVelocity.Text = $"Velocity of the plane: {airplane.Velocity.ToString()} km/h";
            lblHeight.Text = $"Height of the flight: {airplane.Height.ToString()} m";
            listDisp.DataSource = airplane.Dispatchers;
        }
    }
}
