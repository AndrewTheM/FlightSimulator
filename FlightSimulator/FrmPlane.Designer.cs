namespace FlightSimulator
{
    partial class FrmPlane
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.plane = new System.Windows.Forms.PictureBox();
            this.lblVelocity = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.listRecom = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblInsert = new System.Windows.Forms.Label();
            this.lblDisp = new System.Windows.Forms.Label();
            this.listDisp = new System.Windows.Forms.ListBox();
            this.lblGoal = new System.Windows.Forms.Label();
            this.btnControls = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.plane)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // plane
            // 
            this.plane.BackColor = System.Drawing.Color.Transparent;
            this.plane.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.plane.Image = global::FlightSimulator.Properties.Resources.plane;
            this.plane.Location = new System.Drawing.Point(0, 367);
            this.plane.Name = "plane";
            this.plane.Size = new System.Drawing.Size(128, 90);
            this.plane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.plane.TabIndex = 0;
            this.plane.TabStop = false;
            // 
            // lblVelocity
            // 
            this.lblVelocity.AutoSize = true;
            this.lblVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVelocity.ForeColor = System.Drawing.SystemColors.Control;
            this.lblVelocity.Location = new System.Drawing.Point(6, 25);
            this.lblVelocity.Name = "lblVelocity";
            this.lblVelocity.Size = new System.Drawing.Size(90, 20);
            this.lblVelocity.TabIndex = 1;
            this.lblVelocity.Text = "lblVelocity";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeight.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHeight.Location = new System.Drawing.Point(6, 60);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(80, 20);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "lblHeight";
            // 
            // listRecom
            // 
            this.listRecom.BackColor = System.Drawing.SystemColors.Window;
            this.listRecom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listRecom.DisplayMember = "Name";
            this.listRecom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listRecom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.listRecom.FormattingEnabled = true;
            this.listRecom.HorizontalScrollbar = true;
            this.listRecom.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.listRecom.ItemHeight = 20;
            this.listRecom.Location = new System.Drawing.Point(198, 129);
            this.listRecom.Name = "listRecom";
            this.listRecom.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listRecom.Size = new System.Drawing.Size(93, 140);
            this.listRecom.TabIndex = 6;
            this.listRecom.TabStop = false;
            this.listRecom.UseTabStops = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(8, 284);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 26);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add dispatcher";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRemove.Location = new System.Drawing.Point(161, 284);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(130, 26);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove by name";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtName.Location = new System.Drawing.Point(8, 390);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 26);
            this.txtName.TabIndex = 8;
            this.txtName.Visible = false;
            // 
            // lblInsert
            // 
            this.lblInsert.AutoSize = true;
            this.lblInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInsert.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInsert.Location = new System.Drawing.Point(4, 367);
            this.lblInsert.Name = "lblInsert";
            this.lblInsert.Size = new System.Drawing.Size(153, 18);
            this.lblInsert.TabIndex = 9;
            this.lblInsert.Text = "Dispatcher\'s name:";
            this.lblInsert.Visible = false;
            // 
            // lblDisp
            // 
            this.lblDisp.AutoSize = true;
            this.lblDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDisp.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDisp.Location = new System.Drawing.Point(16, 99);
            this.lblDisp.Name = "lblDisp";
            this.lblDisp.Size = new System.Drawing.Size(261, 17);
            this.lblDisp.TabIndex = 10;
            this.lblDisp.Text = "Dispatchers\' Recommended Heigth";
            // 
            // listDisp
            // 
            this.listDisp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listDisp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.listDisp.FormattingEnabled = true;
            this.listDisp.HorizontalScrollbar = true;
            this.listDisp.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.listDisp.ItemHeight = 20;
            this.listDisp.Location = new System.Drawing.Point(7, 129);
            this.listDisp.Name = "listDisp";
            this.listDisp.Size = new System.Drawing.Size(185, 140);
            this.listDisp.TabIndex = 11;
            this.listDisp.TabStop = false;
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.BackColor = System.Drawing.Color.Transparent;
            this.lblGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGoal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGoal.Location = new System.Drawing.Point(0, 0);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Padding = new System.Windows.Forms.Padding(10);
            this.lblGoal.Size = new System.Drawing.Size(167, 45);
            this.lblGoal.TabIndex = 12;
            this.lblGoal.Text = "Goal: take off.";
            // 
            // btnControls
            // 
            this.btnControls.BackColor = System.Drawing.Color.Transparent;
            this.btnControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnControls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnControls.Location = new System.Drawing.Point(502, 12);
            this.btnControls.Name = "btnControls";
            this.btnControls.Size = new System.Drawing.Size(142, 25);
            this.btnControls.TabIndex = 0;
            this.btnControls.Text = "Plane Controls";
            this.btnControls.UseVisualStyleBackColor = false;
            this.btnControls.Click += new System.EventHandler(this.btnControls_Click);
            this.btnControls.Leave += new System.EventHandler(this.btnControls_Leave);
            this.btnControls.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnControls_PreviewKeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblVelocity);
            this.panel1.Controls.Add(this.listDisp);
            this.panel1.Controls.Add(this.lblDisp);
            this.panel1.Controls.Add(this.lblHeight);
            this.panel1.Controls.Add(this.lblInsert);
            this.panel1.Controls.Add(this.listRecom);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(693, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 457);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.lblGoal);
            this.panel2.Controls.Add(this.btnControls);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 50);
            this.panel2.TabIndex = 14;
            // 
            // FrmPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::FlightSimulator.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 457);
            this.Controls.Add(this.plane);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.Name = "FrmPlane";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pilot Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.plane)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox plane;
        private System.Windows.Forms.Label lblVelocity;
        private System.Windows.Forms.Label lblHeight;
        public System.Windows.Forms.ListBox listRecom;
        private System.Windows.Forms.ListBox listDisp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblInsert;
        private System.Windows.Forms.Label lblDisp;
        public System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Button btnControls;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

