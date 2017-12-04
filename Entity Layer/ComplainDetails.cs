using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
   public class ComplainDetails
    {
      public string Complain_Id { get; set; }
      public string ClientId { get; set; }
      public string ProblemDetails { get; set; }
      public string ProblemStatus { get; set; }
      public DateTime Date { get; set; }

    }
}
