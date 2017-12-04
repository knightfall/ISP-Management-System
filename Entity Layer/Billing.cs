using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
  public class Billing
    {
      public string Bill_ID { get; set; }
      public string ClientId { get; set;}
      public double Current_Bill { get; set; }
      public double Previous_Due { get; set; }
      public DateTime InvoicePeriod { get; set; }
      public string paid { get; set; }

    }
}
