using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
   public class client_details
    {
       public string ClientID { get; set; }
       public string ClientName { get; set; }
       public string ClientAddress { get; set; }
       public long ContactNo { get; set; }
       public string IP_Address { get; set; }
       public string MAC_Address { get; set; }
       public string ConnectionType { get; set; }
       public DateTime ConnTakenOn { get; set; }
       public string PackageTaken { get; set; }
    }
   
}
