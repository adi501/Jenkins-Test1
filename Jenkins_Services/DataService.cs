using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenkins_Services
{
    public class DataService : IDataService
    {
        public string GetHost()
        {
            return Environment.MachineName;
        }
    }
}
