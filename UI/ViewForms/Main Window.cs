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
    public partial class Main_Window : Form
    {
        public Main_Window()
        {
            InitializeComponent();
        }

    


        #region Data Loading into Tab Control Tabs
        private void load_data_Click(object sender, EventArgs e)
        {
            DataTable dt_main_window = new DataTable();
            Activity_Layer grid_data_load = new Activity_Layer();
            switch (mainwindow_tabcontrol.SelectedIndex)
            {
                case 0:
                    {
                        try
                        {
                            client_dataGridView.DataSource = grid_data_load.showClientDetails();
                             
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "OOPS");

                        }
                    }
                    break;
                case 1:
                    {
                        try
                        {                            
                            complain_dataGridView.DataSource = grid_data_load.showComplainDetails();
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "OOPS");

                        }
                    }
                    break;
                case 2:
                    {
                        try
                        {

                            billings_dataGridView.DataSource = grid_data_load.showBillingDetails();
                             
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "OOPS");
                        }
                    }
                    break;
            }
        }

      
        //=============================================================================================================================
        #endregion



        #region Search button
        private void searchbutton_Click(object sender, EventArgs e)
        {
            switch (mainwindow_tabcontrol.SelectedIndex)
            {
                case 0:
                    {
                        try
                        {
                            searchremovemodify clientsrm = new searchremovemodify();
                            clientsrm.Show();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "OOPS");

                        }
                    }
                    break;
                case 1:
                    {
                        try
                        {
                            complaintsmr csmr = new complaintsmr();
                            csmr.Show();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "OOPS");

                        }
                    }
                    break;
                case 2:
                    {
                        try
                        {

                            Billsmr bsmr = new Billsmr();
                            bsmr.Show();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "OOPS");
                        }
                    }
                    break;
            }

        }
        #endregion

        private void client_dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            client_details cd_sent = new client_details();
            int selectedindex = e.RowIndex;
            object selectedObject = client_dataGridView.Rows[selectedindex].DataBoundItem;
            DataRow ddt = (selectedObject as DataRowView).Row;

            cd_sent.ClientID = ddt["ClientID"].ToString();
            cd_sent.ClientName = ddt["ClientName"].ToString();
            cd_sent.ClientAddress= ddt["ClientAddress"].ToString();
            cd_sent.ContactNo= Convert.ToInt32(ddt["ContactNo"].ToString());
            cd_sent.IP_Address= ddt["IP_Address"].ToString();
            cd_sent.MAC_Address  = ddt["MAC_Address"].ToString();
            cd_sent.ConnectionType = ddt["ConnectionType"].ToString(); ;
            cd_sent.ConnTakenOn =Convert.ToDateTime(ddt["ConnTakenOn"].ToString());
            cd_sent.PackageTaken = ddt["PackageTaken"].ToString();
            searchremovemodify _sending_client = new searchremovemodify(cd_sent);
            _sending_client.Show();

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            switch (mainwindow_tabcontrol.SelectedIndex)
            {
                case 0:
                    {
                        try
                        {
                            AddUser_Form auf = new AddUser_Form();
                            auf.Show();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "OOPS");

                        }
                    }
                    break;
              

                    break;
            }

        }

  

        




    }
}
