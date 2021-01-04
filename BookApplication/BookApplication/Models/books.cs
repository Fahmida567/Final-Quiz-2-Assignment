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
        Database obj4DBaccess = new Database();
        public void Show()
        {
            string query = "Select * from Books";
            obj4DBaccess.readDatathroughAdapter(query,dtTable);
        }
        public void Close()
        {
            obj4DBaccess.closeConn();
        }

        public void performOperation()
        {
            string query = "Select * from Books";
             a= obj4DBaccess.executeDataAdapter(dtTable,query);
            
        }

        public void searchOpen()
        {

            string query = "Select * from Books where Name='"+textbox+"'";
            obj4DBaccess.readDatathroughAdapter(query, dtTable);
        }
        public void earchClose()
        {
            obj4DBaccess.closeConn();
        }


    }
}
