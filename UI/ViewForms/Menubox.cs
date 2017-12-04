using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Layer;
namespace UI.ViewForms
{
    public partial class Menubox : Form
    {
        public Menubox()
        {
            InitializeComponent();

        }
        private void Menubox_Load(object sender, EventArgs e)
        {
           

        }

        //============================================Clients Tab===================================================================

        #region  Client Details tab
        private void client_tab_Enter(object sender, EventArgs e)
        {
            Activity_Layer getclientdata = new Activity_Layer();
            DataTable clientdata = new DataTable();
            try
            {
                
                clientdata = getclientdata.showClientDetails();
                clientdatagridview.DataSource = clientdata;
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has been found: " + ex, "OOPS");
            }
            
        }
        private void cd_addUser_menu_Click(object sender, EventArgs e)
        {

            AddUser_Form auf1 = new AddUser_Form();
            auf1.Show();
        }

        private void searchmodifyremove_Click(object sender, EventArgs e)
        {
            searchremovemodify smr = new searchremovemodify();
            smr.Show();
        }

        #endregion 

   
        //===========================================Complaints Details====================================================================

        #region complaints Details tab
        private void addcomplaintstrip_Click_1(object sender, EventArgs e)
        {
            Add_Complaint auf = new Add_Complaint();
            auf.Show();
        }

        private void complaints_srm_Click(object sender, EventArgs e)
        {
            complaintsmr luf = new complaintsmr();
            luf.Show();
        }
#endregion
       
        
        //=============================================Billings Tab==================================================================

        #region billings tab
        private void _addbill_Click(object sender, EventArgs e)
        {
            New_Bill col = new New_Bill();
            col.Show();
        }
        #endregion

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Billsmr newsearch = new Billsmr();
            newsearch.Show();
        }








    }
}
