using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Entity_Layer;
using Data_Layer;

//=================================================================checked..............................
namespace UI.ViewForms
{
    public partial class AddUser_Form : Form
    {
       
        public AddUser_Form()
        {
            InitializeComponent();
            DateTime result = DateTime.Today.Subtract(TimeSpan.FromDays(1));
            conDatebox.Value = result;
           


        }
      

        
        #region client data input
        

    
        
        #endregion
      



        private void Submit_Click(object sender, EventArgs e)
        {

            var emptyimput = from tb in tableLayoutPanel1.Controls.OfType<TextBox>()
                             where string.IsNullOrWhiteSpace(tb.Text) 
                             select tb;
            if (emptyimput.Any())
            {
                MessageBox.Show("One or more input box is empty", "Can not execute command");
            }
            else
            {
                client_details cd = new client_details();
                cd.ClientID = cdtextbox.Text;
                cd.ClientName = cntextbox.Text;
                cd.ClientAddress = catextbox.Text;
                cd.ContactNo = Convert.ToInt64(cctextbox.Text);
                cd.IP_Address = iptextbox.Text;
                cd.MAC_Address = mactextbox.Text;
                cd.ConnectionType = cttextbox.Text;
                cd.ConnTakenOn = conDatebox.Value;
                cd.PackageTaken = packagecombobox.Text;

                

                DialogResult submitresult = MessageBox.Show("Are you sure that all data are correct? Pressing Ok will submit the data into the database", "Warning", MessageBoxButtons.YesNo);
                if (submitresult == DialogResult.Yes)
                {
                    try
                    {
                        Activity_Layer submittingrequest = new Activity_Layer();
                        submittingrequest.insert_clientdetails(cd);
                        MessageBox.Show("Entry Successful");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Found" + ex, "Warning");
                    }
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult cancelresult = MessageBox.Show("Pressing yes will close this form and the form data will be deleted.", "You sure about this?", MessageBoxButtons.YesNo);
            if(cancelresult==DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
