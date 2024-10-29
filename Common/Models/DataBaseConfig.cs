using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class DataBaseConfig : IDataBaseConfig
    {
        public string DbUserName { get; set; } = string.Empty;
        public string ServerName { get; set; } = string.Empty; 
        public string DatabaseName { get; set; } = string.Empty;
    }
}
