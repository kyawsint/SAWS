using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;


namespace LayerEX.App_Data
{
    class DBBroker
    {
    }

    class IssueTransBroker
    {
        SqlConnection con;
        SqlCommand cmdinert;
        SqlCommand cmdupdate;
        SqlCommand cmddelete;
        SqlCommand cmdselbypk;
        SqlCommand cmdselall;
        string cons = "data source=(local); initial catalog=DafestyVK; integrated security=True";

        public IssueTransBroker()
        { 
            
        }
    }

    class MovieBroker
    { 
        
    }

    class CusBroker
    { 
        
    }
}
