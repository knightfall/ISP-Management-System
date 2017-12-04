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
using Entity_Layer;
namespace UI.ViewForms
{
    public partial class New_Bill : Form
    {
        public New_Bill()
        {
            InitializeComponent();
        }
        
        Billing newbilldata = new Billing();

        bool billpaid { get; set; }

        private void Submit_Click(object sender, EventArgs e)
        {
            var empty = from tb in billdatapanel.Controls.OfType<TextBox>()
                        where string.IsNullOrWhiteSpace(tb.Text)
                        select tb;
            if (empty.Any())
            {
                MessageBox.Show("One or more input is blank");

            }
            else
            {
                newbilldata.paid = _paid.SelectedText;
                newbilldata.Current_Bill = Convert.ToDouble(currentbill.Text);
                newbilldata.Previous_Due = Convert.ToDouble(_previousduetextbox.Text);
                newbilldata.InvoicePeriod = billdate.Value;
                DialogResult submitresult = MessageBox.Show(@"Are you sure that all data are correct? Pressing Ok 
                will submit the data into the database", "Warning", MessageBoxButtons.YesNo);

                if (submitresult == DialogResult.Yes)
                {
                    try
                    {
                        Activity_Layer submittingrequest = new Activity_Layer();
                        submittingrequest.insert_billing(newbilldata);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Found" + ex, "Warning");
                    }
                }
               

            }
        }

      
        private void cdtextbox_TextChanged(object sender, EventArgs e)
        {
            billIDtextbox.Text = cdtextbox.Text +"-"+ billdate.Value.ToString("Myy") ;
            newbilldata.Bill_ID = billIDtextbox.Text;
            newbilldata.ClientId = cdtextbox.Text;

        }

        private void billdate_ValueChanged(object sender, EventArgs e)
        {
            billIDtextbox.Text = cdtextbox.Text + "-" + billdate.Value.ToString("Myy");
            newbilldata.Bill_ID = billIDtextbox.Text;
            newbilldata.ClientId = cdtextbox.Text;
        }

       

    }
}
