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
    public partial class Add_Complaint : Form
    {
        public Add_Complaint()
        {
            InitializeComponent();
        }
      
        
        ComplainDetails newcomplaint = new ComplainDetails();
        private void Submit_Click(object sender, EventArgs e)
        {
            var empty = from tb in tableLayoutPanel1.Controls.OfType<TextBox>()
                        where string.IsNullOrWhiteSpace(tb.Text)
                        select tb;
            if (empty.Any())
            {
                MessageBox.Show("One or more input box is empty");
            }
            else
            {
                newcomplaint.Date = _probdate.Value;
                newcomplaint.ProblemDetails = problem_details.Text;
                newcomplaint.ProblemStatus = _problemcombo.Text;
                DialogResult submitresult = MessageBox.Show("Are you sure that all data are correct? Pressing Ok will submit the data into the database", "Warning", MessageBoxButtons.YesNo);
                if (submitresult == DialogResult.Yes)
                {
                    try
                    {
                        Activity_Layer _addcomplaint = new Activity_Layer();
                        _addcomplaint.insert_complaindetails(newcomplaint);
                        MessageBox.Show("Complain added.");
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
            if (cancelresult == DialogResult.Yes)
            {
                this.Close();
            }
        }

 
        private void _probdate_ValueChanged(object sender, EventArgs e)
        {
            _compidtextbox.Text = cdtextbox.Text + "-" + _probdate.Value.ToString("ddMMyy-hhmm");
            newcomplaint.Complain_Id = _compidtextbox.Text;
            newcomplaint.ClientId = cdtextbox.Text;
        }

        private void _problemcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            newcomplaint.ProblemStatus = _problemcombo.Text;
          
        }


        private void cdtextbox_TextChanged(object sender, EventArgs e)
        {
            _compidtextbox.Text = cdtextbox.Text + "-" + _probdate.Value.ToString("ddMMyy-hhmm");
            newcomplaint.Complain_Id = _compidtextbox.Text;
            newcomplaint.ClientId = cdtextbox.Text;
        }
    }
}
