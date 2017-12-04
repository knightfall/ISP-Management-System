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
    public partial class complaintsmr : Form
    {
        public complaintsmr()
        {
            InitializeComponent();
            clearbutton_Click(null, null);
        }

        public complaintsmr(ComplainDetails _cds)
        {
            InitializeComponent();
            _compidtextbox.Text = _cds.Complain_Id.ToString();
            cdtextbox.Text = _cds.ClientId.ToString();
            _probdate.Value = _cds.Date;
            _problemdetailstextbox.Text = _cds.ProblemDetails.ToString();
            probstatus.Text = _cds.ProblemStatus.ToString();
            delete.Enabled = true;
            modify.Enabled = false;
            _probdate.Enabled = false;
            probstatus.Enabled = false;
                 
        }

        public string _searchdata { get; set; }

        public string column_name { get; set; }

        Activity_Layer _cs = new Activity_Layer();
        
        ComplainDetails compdet = new ComplainDetails();
      
        DataTable tb1 = new DataTable();
        private void searchbycomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _stringsearchbox.ReadOnly = false;
            column_name = searchbycomboBox1.Text;
        }

    
        private void Submit_Click(object sender, EventArgs e)
        {
            if (_stringsearchbox.TextLength > 0)
            {
                try
                {
                    _searchdata = _stringsearchbox.Text;
                    tb1 = _cs.stringsearch("complaindetails", _searchdata, column_name);
                    _smrcompddataGridView.DataSource = tb1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Warning!!!!!!!!!!!");
                }
            }
            else MessageBox.Show("Forgot to input?");
        }

        private void modify_Click(object sender, EventArgs e)
        {
            if (_compidtextbox.TextLength > 0)
            {
                compdet.Complain_Id = _compidtextbox.Text;
                compdet.ClientId = cdtextbox.Text;
                compdet.ProblemDetails = _problemdetailstextbox.Text;
                compdet.ProblemStatus = probstatus.Text;
                compdet.Date = _probdate.Value;
                try
                {
                    _cs.UpdateComplainDetails(compdet);
                    MessageBox.Show("Complain has been updated successfully updated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
            else MessageBox.Show("Load data into form first.");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (_compidtextbox.TextLength > 0)
            {
                try
                {
                    _cs.Deletecomplain(_compidtextbox.Text.ToString());
                    MessageBox.Show("Complain has been deleted successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
            else MessageBox.Show("Load data in form first");
            clearbutton_Click(null, null);
        }

        private void _smrcompddataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedindex = e.RowIndex;
            object selectedObject = _smrcompddataGridView.Rows[selectedindex].DataBoundItem;
            DataRow ddt = (selectedObject as DataRowView).Row;
            _compidtextbox.Text = ddt["Complain_Id"].ToString();
           cdtextbox.Text  = ddt["ClientId"].ToString();
          _problemdetailstextbox.Text   = ddt["ProblemDetails"].ToString();
          _probdate.Value =Convert.ToDateTime(ddt["Date"].ToString());
          probstatus.Text = ddt["ProblemStatus"].ToString();
          modify.Enabled = false;
          delete.Enabled = true;

        }

        private void statpanel_Click(object sender, EventArgs e)
        {
            probstatus.Enabled = true;
            modify.Enabled = true;
            delete.Enabled = false;
        }

        private void datepanel_Click(object sender, EventArgs e)
        {
            _probdate.Enabled = true;
            modify.Enabled = true;
            delete.Enabled = false;
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            _compidtextbox.Clear();
            cdtextbox.Clear();
            _problemdetailstextbox.Clear();
            probstatus.Text = "";
            probstatus.Enabled = false;
            _smrcompddataGridView.DataSource = "";
            _compidtextbox.ReadOnly = true;
            cdtextbox.ReadOnly = true;
            _problemdetailstextbox.ReadOnly = true;
            _probdate.Value = System.DateTime.Today;
            _probdate.Enabled = false;
            modify.Enabled = false;
            delete.Enabled = false;
        }
    }
}
