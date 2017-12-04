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
    public partial class searchremovemodify : Form
    {
        public searchremovemodify()
        {
            InitializeComponent();
            DateTime result = DateTime.Today.Subtract(TimeSpan.FromDays(1));
            searchdate = result;
            modify.Enabled = false;
            Delete.Enabled = false;
                    
        }

        public searchremovemodify(client_details _getcd)
        {
            InitializeComponent();
            cdtextbox.Text = _getcd.ClientID;
            cntextbox.Text = _getcd.ClientName;
            catextbox.Text = _getcd.ClientAddress;
            cctextbox.Text = _getcd.ContactNo.ToString();
            iptextbox.Text = _getcd.IP_Address;
            mactextbox.Text = _getcd.MAC_Address;
            cttextbox.Text = _getcd.ConnectionType;
            conDatebox.Value = _getcd.ConnTakenOn;
            packagecombobox.Text = _getcd.PackageTaken;
            Delete.Enabled = true;
        }



        
       DataTable tb = new DataTable();
       public int _index{get;set;}
       public DateTime searchdate{get; set;}
       public string column_name { get; set; }
       public string _searchdata { get; set; }
       private void searchremovemodify_Load(object sender, EventArgs e)
       {
           foreach (Control col in cdtableplanel.Controls)
           {
               if (col is TextBox)
               {
                   (col as TextBox).ReadOnly = true;
               }
              
            }
          // Delete.Enabled = false;
           modify.Enabled = false;
           packagecombobox.Enabled = false;
           conDatebox.Enabled = false;
           _stringsearchbox.Enabled = false;
           searchboxint.Enabled = false;
           searchdatepicker.Enabled = false;
          
       } 
       
        
        

        private void searchbycombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _stringsearchbox.Enabled = true;
            searchboxint.Enabled = true;
            searchdatepicker.Enabled = true;
            _index = searchbycombo.SelectedIndex;
            switch (_index)
            {
                case 0:
                    {
                        searchboxint.Visible = false;
                        searchdatepicker.Visible = false;
                        _stringsearchbox.Visible = true;
                        searchboxint.Text = "";
                        break;
                    }
                case 2:
                    {
                        searchboxint.Visible = false;
                        searchdatepicker.Visible = false;
                        _stringsearchbox.Visible = true;
                        searchboxint.Text = "";
                        break;
                    }
                case 3:
                    {
                        searchboxint.Visible = true;
                        searchdatepicker.Visible = false;
                        _stringsearchbox.Visible = false;
                        break;
                    }
                case 4:
                    {
                        searchboxint.Visible = false;
                        searchdatepicker.Visible = false;
                        _stringsearchbox.Visible = true;
                        searchboxint.Text = "";
                        break;
                    }
                case 5:
                    {
                        searchboxint.Visible = false;
                        searchdatepicker.Visible = false;
                        _stringsearchbox.Visible = true;
                        searchboxint.Text = "";
                        break;
                    }
                case 6:
                    {
                        searchboxint.Visible = false;
                        searchdatepicker.Visible = false;
                        _stringsearchbox.Visible = true;
                        searchboxint.Text = "";
                        break;
                    }
                case 7:
                    {
                        searchboxint.Visible = false;
                        searchdatepicker.Visible = true;
                        _stringsearchbox.Visible = false;
                        
                        break;
                    }
                case 8:
                    {
                        searchboxint.Visible = false;
                        searchdatepicker.Visible = false;
                        _stringsearchbox.Visible = true;
                        searchboxint.Text = "";
                        break;
                    }

            }
           

        } //done

      
        private void Submit_Click(object sender, EventArgs e)
        {

            data_select();

            if (_searchdata.Length > 0)
            {
                Activity_Layer search_submit = new Activity_Layer();

                _indexcheck(_index);
                tb = search_submit.stringsearch("clientdetails", _searchdata, column_name);

                _datasearchGridView.DataSource = tb;
            }
            else MessageBox.Show("Search value is null or empty");
        }  //checked

        private void data_select()
        {
            if (searchbycombo.SelectedIndex == 3)
            {
                _searchdata = searchboxint.Text;
            }
            else if (searchbycombo.SelectedIndex == 7)
            {
                _searchdata = searchdatepicker.Value.ToString("yyyy-MM-dd");
            }
            else if(searchbycombo.SelectedIndex!=7 || searchbycombo.SelectedIndex!=3) _searchdata = _stringsearchbox.Text;
        }
       
        private void _indexcheck(int i)
        {
            switch(i)
            {
                case 0:
                    column_name = "clientid";
                    break;
                case 1:
                    column_name = "clientname";
                    break;
                case 2:
                    column_name = "clientaddress";
                    break;
                case 3:
                    column_name = "contactno";
                    break;
                case 4:
                    column_name = "ip_address";
                    break;
                case 5:
                    column_name = "mac_address";
                    break;
                case 6:
                    column_name = "connectiontype";
                    break;
                case 7:
                    column_name = "conntakenon";
                    break;
                case 8:
                    column_name = "packagetaken";
                    break;
                
            }
        }

   

        private void _datasearchGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedindex = e.RowIndex;
            object selectedObject = _datasearchGridView.Rows[selectedindex].DataBoundItem;
            DataRow ddt = (selectedObject as DataRowView).Row;
            cdtextbox.Text = ddt["ClientID"].ToString();
            cntextbox.Text = ddt["ClientName"].ToString();
            catextbox.Text = ddt["ClientAddress"].ToString();
            cctextbox.Text = ddt["ContactNo"].ToString();
            iptextbox.Text = ddt["IP_Address"].ToString();
            mactextbox.Text = ddt["MAC_Address"].ToString();
            cttextbox.Text = ddt["ConnectionType"].ToString(); ;
            conDatebox.Value =Convert.ToDateTime(ddt["ConnTakenOn"].ToString());
            packagecombobox.Text = ddt["PackageTaken"].ToString();
            Delete.Enabled = true;
            modify.Enabled = false;
        }

 
        private void Cancel_Click(object sender, EventArgs e)
        {
            foreach(Control col in cdtableplanel.Controls)
            {
                if (col is TextBox)
                {
                    (col as TextBox).Clear();
                    (col as TextBox).ReadOnly = true;
                }
                }
       
            _datasearchGridView.DataSource = "";
            _datasearchGridView.Refresh();
            Delete.Enabled = false;
            modify.Enabled = false;
            packagecombobox.Enabled = false;
            conDatebox.Enabled = false;
        }


        private void cdtextbox_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textbase = sender as TextBox;
            Delete.Enabled = false;
            switch (textbase.Name)
            {
                                 
                case "cntextbox":
                    cntextbox.ReadOnly = false;
                    break;
                case "catextbox":
                    catextbox.ReadOnly = false;
                    break;
                case "cctextbox":
                    cctextbox.ReadOnly = false;
                    break;
                case "iptextbox":
                    iptextbox.ReadOnly = false;
                    break;
                case "mactextbox":
                    mactextbox.ReadOnly = false;
                    break;
                case "cttextbox":
                    cttextbox.ReadOnly = false;
                    break;

                    

            }
            modify.Enabled = true;
        }

       

        private void Delete_Click(object sender, EventArgs e)
        {
            Activity_Layer delclient = new Activity_Layer();
           
            try
            {
                bool _deleted_client = delclient.Delete_client(cdtextbox.Text);
                if (_deleted_client)
                {
                    MessageBox.Show("User entry has been successfully deleted", "Confirmed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Warning");
            }

            Cancel_Click(null, null);
           
        }

        private void modify_Click(object sender, EventArgs e)
        {
            if (cdtextbox.TextLength > 0)
            {
                Activity_Layer moddata = new Activity_Layer();
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
                try
                {

                    moddata.UpdateClientDetails(cd);
                    MessageBox.Show("Client Data Updated");
                    Cancel_Click(null, null);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "OOPS!!!");
                }
            }
            else MessageBox.Show("Load data into the form first.");
        }

        private void packagecombobox_Click(object sender, EventArgs e)
        {
            packagecombobox.Enabled = true;
            modify.Enabled = true;
        }

        private void cddatepanel_Click(object sender, EventArgs e)
        {
            conDatebox.Enabled = true;
            modify.Enabled = true; ;
            Delete.Enabled = false;
        }

        private void packagepanel_Click(object sender, EventArgs e)
        {
            packagecombobox.Enabled = true;
            modify.Enabled = true;
            Delete.Enabled = false;
        }

        

    }
        

    }
           


