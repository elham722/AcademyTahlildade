using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademyTahlildade
{
    public partial class FrmPayment : Form
    {
        private Employee currentUser;
        private int registerationID;
        private int paymentID;
        public FrmPayment(Employee currentUser, int registerationID)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.registerationID = registerationID;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {
            lblepmployee.Text = currentUser.UserName;
            lblregisterid.Text = registerationID.ToString();
        //bindpayment
        //utility
        }
    }
}
