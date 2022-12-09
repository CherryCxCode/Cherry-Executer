using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace Cherry_Injecter
{
    public partial class Form1 : Form
    {
        readonly ExploitAPI api = new ExploitAPI();
        private bool drag = false;
        private Point loc;
        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Down(object sender, MouseEventArgs e)
        {
            drag = true;
            loc = new Point(e.X, e.Y);
        }

        private void Up(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Move(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.loc.X, p.Y - this.loc.Y);
            }
        }

        private void btnInject_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string script = inputScript.Text;
            api.SendLuaScript(script);
        }

        private void btnSpeed_Click(object sender, EventArgs e)
        {
            api.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.WalkSpeed=100");

        }

        private void btnBtools_Click(object sender, EventArgs e)
        {
            api.DoBTools();
        }

        private void btnTPTo_Click(object sender, EventArgs e)
        {
            string username = inputTPTo.Text;
            api.TeleportToPlayer(username);
        }
        private void CheckInjected()
        {
            if (api.isAPIAttached())
            {
                //The exploit is injected and now ready to execute scripts/commands
                MessageBox.Show("successfully Injected");
            }
            else
            {
                //The exploit is not injected... The client must inject
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Hide();
        }


        private void label3_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel1.BringToFront();
        }
    }
}
