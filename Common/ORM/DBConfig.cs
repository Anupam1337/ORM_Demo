using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ORM
{
    internal class DBConfig : IDBConfig
    {
        public string? ConnectionString { get; set; }
        public string? dataBaseConnectionString { get; set; }
        public DBConfig(IDataBaseConfig dataBaseConfig) {
            SetDbCredential(dataBaseConfig);
        }
        private void SetDbCredential(IDataBaseConfig dataBaseConfig) {
            //Data Source=DESKTOP-PML56D5;Initial Catalog=Crm_Pipeline;Integrated Security=True;Multiple Active Result Sets=True;Trust Server Certificate=True
            ConnectionString = $"Data Source={dataBaseConfig.ServerName};Initial Catalog={dataBaseConfig.DatabaseName};Integrated Security=True;Multiple Active Result Sets=True;Trust Server Certificate=True;";
            dataBaseConnectionString = $"Data Source=DESKTOP-PML56D5;Initial Catalog=Crm_Pipeline;Integrated Security=True;Multiple Active Result Sets=True;Trust Server Certificate=True";
        }
    }
}
