using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ICT4Events_Group1
{
    public partial class MenuForm : Form
    {
        private Database db;
        private Dictionary<string, bool> opened;
        private UserLogin login;
        EntranceForm EF;
        VerhuurForm VF;
        public MenuForm(UserLogin log)
        {
            InitializeComponent();

      

            login = log;

            db = new Database();
            opened = new Dictionary<string, bool>();


            if (!((Employee) db.Logged).admin)
                btnEvent.Visible = false;
        }

        private void Open(Form open)
        {
            //this.Hide();
            
            open.Closed += (s, args) => this.opened[open.Name] = false;

            if (opened.ContainsKey(open.Name) && opened[open.Name] == false)
            {
                opened[open.Name] = true;
                open.Show();
            }
            if (!opened.ContainsKey(open.Name))
            {
                opened.Add(open.Name, true);
                open.Show();
            }
        }

        private void btnVerhuur_Click(object sender, EventArgs e)
        {
            VF = new VerhuurForm();
            Open(VF);
        }

        private void btnBeheer_Click(object sender, EventArgs e)
        {
            Open(new GebruikerBeheerForm());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Open(new EventBeheerForm());
        }

        private void btn_Entrance_Click(object sender, EventArgs e)
        {
            EF = new EntranceForm();
            Open(EF);
        }
        //berichten
        private void button1_Click(object sender, EventArgs e)
        {
            Open(new BerichtBeheerForm());
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            db.logOut();
            login.Show();
            this.Hide();
        }

        public void rfidLost()
        {
           if(opened.ContainsKey("EntranceForm") && opened["EntranceForm"])
                EF.rfidLost();
           if (opened.ContainsKey("VerhuurForm") && opened["VerhuurForm"])
               VF.rfidLost();
        }

        public void RfidGet(string tag)
        {
            if (opened.ContainsKey("EntranceForm") && opened["EntranceForm"])
                EF.RfidGet(tag);
            if (opened.ContainsKey("VerhuurForm") && opened["VerhuurForm"])
                VF.rfidget(tag);
        }
    }
}
