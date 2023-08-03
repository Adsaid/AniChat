using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace wcf_service
{
    public class ServerUser
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Chat_Name { get; set; }

        public OperationContext OperationContext { get; set; }

    }
}
