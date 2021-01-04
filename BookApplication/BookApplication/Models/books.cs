using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using BookApplication.Models;

namespace BookApplication.Models
{
    
    public class books
    {
        public int a;
        
        public string textbox;
       public DataTable dtTable = new DataTable();
        Database objDBaccess = new Database();
        public void Show()
        {
            string query = "Select * from Books";
            objDBaccess.readDatathroughAdapter(query,dtTable);
        }
        public void Close()
        {
            objDBaccess.closeConn();
        }

        public void performOperation()
        {
            string query = "Select * from Books";
             a= objDBaccess.executeDataAdapter(dtTable,query);
            
        }

        public void searchOpen()
        {

            string query = "Select * from Books where Name='"+textbox+"'";
            objDBaccess.readDatathroughAdapter(query, dtTable);
        }
        public void earchClose()
        {
            objDBaccess.closeConn();
        }
       public void information()
        {
            
        }



    }
}
