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
    public partial class Billsmr : Form
    {
        public Billsmr()
        {
            InitializeComponent();
            
        }
        Activity_Layer al = new Activity_Layer();
        Billing bl = new Billing();

        public Billsmr(Billing sbill)
        {
            InitializeComponent();
           
            billidtextbox.Text = sbill.Bill_ID;
            cdtextbox.Text = sbill.ClientId.ToString();
            currentbill.Text = sbill.Current_Bill.ToString();
            _previousduetextbox.Text = sbill.Previous_Due.ToString();
            invoicedate.Value = sbill.InvoicePeriod;
            if (sbill.paid == "Unpaid") paidcombobox.SelectedIndex = 0; else paidcombobox.SelectedIndex = 1;
            billdataGridView.DataSource = sbill;

            Billsmr_Load(null, null);
            delete.Enabled = true;
        }


       private void Billsmr_Load(object sender, EventArgs e)
        {
            _previousduetextbox.ReadOnly = true;
            currentbill.ReadOnly = true;
            invoicedate.Enabled = false;
            modify.Enabled = false;
            _stringsearchbox.ReadOnly = true;
            paidcombobox.Enabled = false;
        }

       private void Submit_Click(object sender, EventArgs e)
       {
           if(_stringsearchbox.TextLength>0)
           {

               billdataGridView.DataSource = al.stringsearch("billing", _stringsearchbox.Text.ToString(), searchbycombo.Text.ToString());
              
           }
           else
           {
               MessageBox.Show("You forgot to input data?");
           }
       }

       private void clear_Click(object sender, EventArgs e)
       {
            Billsmr_Load(null, null);
            foreach(Control col in billdata_panel.Controls)
            {
                if(col is TextBox)
                {
                    (col as TextBox).Clear();
                }
            }
            paidcombobox.Refresh();
  
       }
       
       private void delete_Click(object sender, EventArgs e)
       {
           if (billidtextbox.TextLength > 0)
           {
               try
               {

                   al.Deletebill(billidtextbox.Text.ToString());
                   MessageBox.Show("Bill successfully deleted.");
                   Billsmr_Load(null, null);
                   clear_Click(null, null);
               }
               catch (Exception ex)
               {
                   MessageBox.Show("OOPS, something unexpected happened. Error Description" + ex, "Action failed");
                   Billsmr_Load(null, null);
                   clear_Click(null, null);
               }
           }
           else MessageBox.Show("Load data into the form first.");
       }

       private void billdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {
           int selectedindex = e.RowIndex;
           object selectedObject = billdataGridView.Rows[selectedindex].DataBoundItem;
           DataRow ddt = (selectedObject as DataRowView).Row;
           billidtextbox.Text = ddt["Bill_ID"].ToString();
           cdtextbox.Text = ddt["ClientId"].ToString();
           currentbill.Text = ddt["Current_Bill"].ToString();
           _previousduetextbox.Text = ddt["Previous_Due"].ToString();
           invoicedate.Value = Convert.ToDateTime(ddt["InvoicePeriod"].ToString());
           paidcombobox.Text = ddt["Paid"].ToString();
           delete.Enabled = true;
           modify.Enabled = false;

       }

       private void control_click(object sender, EventArgs e)
       {
           TextBox tx = sender as TextBox;
           switch(tx.Name)
           {
               case "currentbill":
                   currentbill.ReadOnly = false;
                   break;
               case "_previousduetextbox":
                   _previousduetextbox.ReadOnly = false;
                   break;
           }
           modify.Enabled = true;
           delete.Enabled = false;
       }

     

       private void modify_Click(object sender, EventArgs e)
       {
            if (billidtextbox.TextLength > 0)
               {
           bl.Bill_ID = billidtextbox.Text;
           bl.ClientId = cdtextbox.Text;
           bl.Current_Bill = Convert.ToDouble(currentbill.Text);
           bl.Previous_Due = Convert.ToDouble(_previousduetextbox.Text);
           bl.paid = paidcombobox.Text;
           bl.InvoicePeriod = invoicedate.Value;
           try
           {
              
                   al.UpdateBillingDetails(bl);
                   MessageBox.Show("Bill has been successfully updated");
                   clear_Click(null, null);
              
           }
           catch(Exception ex)
           {
               MessageBox.Show("Something unexpected has happen. Error: "+ex,"OOPS");
               clear_Click(null, null);
           }
               }
            else MessageBox.Show("Load data first");
        }

       private void paidcombobox_MouseClick(object sender, MouseEventArgs e)
       {
           paidcombobox.Enabled = true;
           modify.Enabled = true;
       }

       private void invoicedate_MouseDown(object sender, MouseEventArgs e)
       {
           invoicedate.Enabled = true;
           modify.Enabled = true;
       }

       private void searchbycombo_SelectedIndexChanged(object sender, EventArgs e)
       {
           _stringsearchbox.ReadOnly = false;
       }

       private void invoicepanel_Click(object sender, EventArgs e)
       {
           invoicedate.Enabled = true;
           modify.Enabled = true;
           delete.Enabled = false;
       }

       private void statuspanel_Click(object sender, EventArgs e)
       {
           paidcombobox.Enabled = true;
           modify.Enabled = true;
           delete.Enabled = false;
       }
       }
        
    }

