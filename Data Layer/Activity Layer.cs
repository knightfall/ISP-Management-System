using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity_Layer;
namespace Data_Layer
{
   public class Activity_Layer
    {
       const string ConnectionString = ";Initial Catalog=isp_mgmt_db;User ID=teacher;Password=OOP-2";

        public DataTable showClientDetails()
        {
            DataTable table = new DataTable();

            SqlConnection C = new SqlConnection(ConnectionString);

            C.Open();
            SqlDataAdapter a = new SqlDataAdapter("select * from [dbo].[ClientDetails]", C);
            a.Fill(table);
            
            C.Close();
            return table;

        }
       [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
       public DataTable stringsearch(string table, string input, string column)
        {
           DataTable searchtable =new DataTable();
           SqlConnection c = new SqlConnection(ConnectionString);
           c.Open();
           
           string temp = "Select * from " +"[dbo].[" + table +"] " +" where " + column + " = " + "'"+input+"'";
           SqlDataAdapter a = new SqlDataAdapter(temp, c);
           a.Fill(searchtable);
           c.Close();
           return searchtable;
        }
       
        public DataTable showBillingDetails()
        {
            DataTable table2 = new DataTable();

            SqlConnection C = new SqlConnection(ConnectionString);

            C.Open();
            SqlDataAdapter a = new SqlDataAdapter("select * from Billing", C);
            a.Fill(table2);
            
            C.Close();
            return table2;
            //]================
        }
        public DataTable showComplainDetails()
        {
            SqlConnection C = new SqlConnection(ConnectionString);
            DataTable table3 = new DataTable();
                     
            C.Open();
            SqlDataAdapter a = new SqlDataAdapter("select * from ComplainDetails", C);
            a.Fill(table3);
            C.Close();
            return table3;
            

        }

        public void insert_billing(Billing cd)
        {
            SqlConnection C = new SqlConnection(ConnectionString);
            var insertBill = new SqlCommand("INSERT INTO [dbo].[Billing] ([Bill_ID], [Clientid], [Current_Bill], [Previous_Due], [InvoicePeriod], [Paid] ) VALUES ( @Bill_ID, @Clientid, @Current_Bill, @Previous_Due, @InvoicePeriod, @Paid)", C);
          
            SqlParameter p1 = new SqlParameter("@Bill_ID", SqlDbType.VarChar, 50);
            p1.Value = cd.Bill_ID;
            SqlParameter p2 = new SqlParameter("@Clientid", SqlDbType.VarChar, 50);
            p2.Value = cd.ClientId;
            SqlParameter p3 = new SqlParameter("@Current_Bill", SqlDbType.SmallMoney);
            p3.Value = cd.Current_Bill;
            SqlParameter p4 = new SqlParameter("@Previous_Due", SqlDbType.SmallMoney);
            p4.Value = cd.Previous_Due;
            SqlParameter p5 = new SqlParameter("@InvoicePeriod", SqlDbType.DateTime, 50);
            p5.Value = cd.InvoicePeriod;

            SqlParameter p6 = new SqlParameter("@Paid", SqlDbType.VarChar);
            p6.Value = cd.paid;
            
            insertBill.Parameters.Add(p1);
            insertBill.Parameters.Add(p2);
            insertBill.Parameters.Add(p3);
            insertBill.Parameters.Add(p4);
            insertBill.Parameters.Add(p5);
            insertBill.Parameters.Add(p6);
            C.Open();
            insertBill.ExecuteNonQuery();
            C.Close();
          
 
        }
        public bool insert_clientdetails(client_details cd)
        {
            
            SqlConnection C = new SqlConnection(ConnectionString);
            SqlCommand cd_add = new SqlCommand(
"INSERT INTO [dbo].[ClientDetails] ([ClientId], [ClientName], [ClientAddress], [ContactNo], [IP_Address], [MAC_Address], [ConnectionType], [ConnTakenOn], [PackageTaken] ) VALUES (@ClientId, @ClientName, @ClientAddress, @ContactNo, @IP_Address, @MAC_Address, @ConnectionType, @ConnTakenOn, @PackageTaken )",C);
            SqlParameter p1 = new SqlParameter("@ClientId", SqlDbType.VarChar);
            p1.Value = cd.ClientID;
           
            SqlParameter p2 = new SqlParameter("@ClientName", SqlDbType.VarChar, 50);
            p2.Value = cd.ClientName;
            SqlParameter p3 = new SqlParameter("@ClientAddress", SqlDbType.VarChar, 255);
            p3.Value = cd.ClientAddress;
            SqlParameter p4 = new SqlParameter("@ContactNo", SqlDbType.Int);
            p4.Value = cd.ContactNo;
            SqlParameter p5 = new SqlParameter("@IP_Address", SqlDbType.VarChar, 50);
            p5.Value = cd.IP_Address;
            SqlParameter p6 = new SqlParameter("@MAC_Address", SqlDbType.VarChar, 50);
            p6.Value = cd.MAC_Address;
            SqlParameter p7 = new SqlParameter("@ConnectionType", SqlDbType.VarChar, 50);
            p7.Value = cd.ConnectionType;
            SqlParameter p8 = new SqlParameter("@ConnTakenOn", SqlDbType.DateTime);
            p8.Value = cd.ConnTakenOn;
            SqlParameter p9 = new SqlParameter("@PackageTaken", SqlDbType.VarChar, 50);
            p9.Value = cd.PackageTaken;
            cd_add.Parameters.Add(p1);
            cd_add.Parameters.Add(p2);
            cd_add.Parameters.Add(p3);
            cd_add.Parameters.Add(p4);
            cd_add.Parameters.Add(p5);
            cd_add.Parameters.Add(p6);
            cd_add.Parameters.Add(p7);
            cd_add.Parameters.Add(p8);
            cd_add.Parameters.Add(p9);
            C.Open();

            int result = cd_add.ExecuteNonQuery();
            C.Close();
            return result > 0;
        

        }
        public void insert_complaindetails(ComplainDetails cd)
        {
            SqlConnection C = new SqlConnection(ConnectionString);
            var complain_insert = new SqlCommand("INSERT INTO [dbo].[ComplainDetails] ([Complain_Id], [Clientid], [ProblemDetails], [ProblemStatus], [Date] ) VALUES (@Complain_Id, @Clientid, @ProblemDetails, @ProblemStatus, @Date)", C);
            SqlParameter p1 = new SqlParameter("@Complain_Id ", SqlDbType.VarChar, 50);
            p1.Value = cd.Complain_Id;
            SqlParameter p2 = new SqlParameter("@Clientid ", SqlDbType.VarChar, 50);
            p2.Value = cd.ClientId;
            SqlParameter p3 = new SqlParameter("@ProblemDetails ", SqlDbType.VarChar);
            p3.Value = cd.ProblemDetails;
            SqlParameter p4 = new SqlParameter("@ProblemStatus ", SqlDbType.VarChar, 50);
            p4.Value = cd.ProblemStatus;
            SqlParameter p5 = new SqlParameter("@Date ", SqlDbType.DateTime);
            p5.Value = cd.Date;

            complain_insert.Parameters.Add(p1);
            complain_insert.Parameters.Add(p2);
            complain_insert.Parameters.Add(p3);
            complain_insert.Parameters.Add(p4);
            complain_insert.Parameters.Add(p5);

            C.Open();
           complain_insert.ExecuteNonQuery();
            C.Close();
        }

 public bool Delete_client(string Client_Id)
        {
            SqlConnection C = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand("DELETE ClientDetails WHERE ClientId = @ClientId", C);
            SqlParameter p1 = new SqlParameter("@ClientId", System.Data.SqlDbType.VarChar);
            p1.Value = Client_Id;
            command.Parameters.Add(p1);

            C.Open();
           int result = command.ExecuteNonQuery();
            C.Close();
            return result> 0;
        }

      
        public void Deletebill(string Bill_id)
        {
            SqlConnection C = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand("DELETE Billing WHERE Bill_ID = @Bill_ID", C);
            SqlParameter p1 = new SqlParameter("Bill_ID", System.Data.SqlDbType.VarChar);
            p1.Value = Bill_id;
            command.Parameters.Add(p1);

            C.Open();
           command.ExecuteNonQuery();
            C.Close();
            
        }

        public bool Deletecomplain(string Complain_id)
        {
            SqlConnection C = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand("DELETE ComplainDetails WHERE Complain_Id = @Complain_Id", C);
            SqlParameter p1 = new SqlParameter("@Complain_Id", System.Data.SqlDbType.VarChar);
            p1.Value = Complain_id;
            command.Parameters.Add(p1);

            C.Open();
            int result = command.ExecuteNonQuery();
            C.Close();
            return result > 0;
        }




       public   bool UpdateClientDetails(client_details cd_obj)
        {
            SqlConnection C = new SqlConnection(ConnectionString);
        
            SqlCommand modclient = new SqlCommand(@"UPDATE [dbo].[ClientDetails] SET [ClientName]=@ClientName, [Clientaddress]=@ClientAddress,[ContactNo]=@ContactNo,[IP_Address]=@IP_Address,
                [MAC_Address]=@MAC_Address,[ConnectionType]=@ConnectionType,[ConnTakenOn]=@ConnectionTakenOn,[PackageTaken]=@PackageTaken WHERE [ClientId] = @ClientId", C);
           
              SqlParameter p1 = new SqlParameter("@ClientName", System.Data.SqlDbType.VarChar, 50);
              p1.Value = cd_obj.ClientName;
              modclient.Parameters.Add(p1);

              SqlParameter p2= new SqlParameter("@ClientAddress", System.Data.SqlDbType.VarChar, 255);
              p2.Value = cd_obj.ClientAddress;
              modclient.Parameters.Add(p2);

              SqlParameter p3 = new SqlParameter("@ContactNo", System.Data.SqlDbType.Int);
              p3.Value = cd_obj.ContactNo;
              modclient.Parameters.Add(p3);

              SqlParameter p4 = new SqlParameter("@IP_Address",System.Data.SqlDbType.VarChar);
              p4.Value = cd_obj.IP_Address;
              modclient.Parameters.Add(p4);

              SqlParameter p5 = new SqlParameter("@MAC_Address", System.Data.SqlDbType.VarChar, 255);
              p5.Value = cd_obj.MAC_Address;
              modclient.Parameters.Add(p5);


              SqlParameter p6 = new SqlParameter("@ConnectionType", System.Data.SqlDbType.VarChar, 255);
              p6.Value = cd_obj.ConnectionType;
              modclient.Parameters.Add(p6);

              SqlParameter p7 = new SqlParameter("@ConnectionTakenOn", System.Data.SqlDbType.DateTime);
              p7.Value = cd_obj.ConnTakenOn;
              modclient.Parameters.Add(p7);

              SqlParameter p8 = new SqlParameter("@PackageTaken", System.Data.SqlDbType.VarChar, 255);
              p8.Value = cd_obj.PackageTaken;
              modclient.Parameters.Add(p8);


              SqlParameter p9= new SqlParameter("@ClientId", System.Data.SqlDbType.VarChar, 50);
              p9.Value = cd_obj.ClientID;
              modclient.Parameters.Add(p9);
  



             C.Open();
            int result = modclient.ExecuteNonQuery();
            C.Close();
            return result > 0;
        }

       public bool UpdateBillingDetails(Billing Bd_obj)
       {
           SqlConnection C = new SqlConnection(ConnectionString);

           SqlCommand command = new SqlCommand(@"UPDATE [dbo].[Billing]  SET [ClientId]=@ClientId, [Current_Bill]=@Current_Bill,[Previous_Due]=@Previous_Due,
            [InvoicePeriod]=@InvoicePeriod,[Paid] = @Paid WHERE [Bill_ID] = @Bill_ID", C);

           SqlParameter p1 = new SqlParameter("@ClientId", System.Data.SqlDbType.VarChar, 20);
           p1.Value = Bd_obj.ClientId;
           command.Parameters.Add(p1);

           SqlParameter p2 = new SqlParameter("@CUrrent_Bill", System.Data.SqlDbType.SmallMoney);
           p2.Value = Bd_obj.Current_Bill;
           command.Parameters.Add(p2);

           SqlParameter p3 = new SqlParameter("@Previous_Due", System.Data.SqlDbType.SmallMoney);
           p3.Value = Bd_obj.Previous_Due;
           command.Parameters.Add(p3);


           SqlParameter p4 = new SqlParameter("@InvoicePeriod", System.Data.SqlDbType.DateTime, 20);
           p4.Value = Bd_obj.InvoicePeriod;
           command.Parameters.Add(p4);
           SqlParameter p4_1 = new SqlParameter("@Paid", System.Data.SqlDbType.VarChar);
           p4_1.Value = Bd_obj.paid;
           command.Parameters.Add(p4_1);

           SqlParameter p5 = new SqlParameter("@Bill_ID", System.Data.SqlDbType.VarChar);
           p5.Value = Bd_obj.Bill_ID;
           command.Parameters.Add(p5);

           
           
           C.Open();
           int result = command.ExecuteNonQuery();
           C.Close();
           return result > 0;
       }


       public bool UpdateComplainDetails(ComplainDetails comd_obj)
       {
           SqlConnection C = new SqlConnection(ConnectionString);

           SqlCommand command = new SqlCommand("UPDATE [dbo].[ComplainDetails]  SET [ClientId]=@ClientId, [ProblemDetails]=@ProblemDetails,[ProblemStatus]=@ProblemStatus,[Date]=@Date WHERE [Complain_Id] = @Complain_Id", C);

           SqlParameter p1 = new SqlParameter("@ClientId", System.Data.SqlDbType.VarChar, 20);
           p1.Value = comd_obj.ClientId;
           command.Parameters.Add(p1);

           SqlParameter p2 = new SqlParameter("@ProblemDetails", System.Data.SqlDbType.VarChar, 25);
           p2.Value = comd_obj.ProblemDetails;
           command.Parameters.Add(p2);

           SqlParameter p3 = new SqlParameter("@ProblemStatus", System.Data.SqlDbType.VarChar, 50);
           p3.Value = comd_obj.ProblemStatus;
           command.Parameters.Add(p3);


           SqlParameter p4 = new SqlParameter("@Date", System.Data.SqlDbType.DateTime);
           p4.Value = comd_obj.Date;
           command.Parameters.Add(p4);
           SqlParameter p5 = new SqlParameter("@Complain_Id", System.Data.SqlDbType.VarChar);
           p5.Value = comd_obj.Complain_Id;
           command.Parameters.Add(p5);

           C.Open();
           
           int result = command.ExecuteNonQuery();
           C.Close();
           return result > 0;
       } 


       }
        
    }

