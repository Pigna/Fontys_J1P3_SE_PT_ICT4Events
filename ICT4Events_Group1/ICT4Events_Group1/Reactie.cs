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
    public partial class Reactie : Form
    {
        
        public Reactie()
        {
            InitializeComponent();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbTitle_Enter(object sender, EventArgs e)
        {
            if (tbTitle.Text == "Title")
            {
                tbTitle.Clear();
            }
        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMessage_Enter(object sender, EventArgs e)
        {
            tbMessage.Clear();
        }
    }
}
