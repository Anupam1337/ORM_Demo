using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public interface IDataBaseConfig
    {
        public string DbUserName { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
    }
}
