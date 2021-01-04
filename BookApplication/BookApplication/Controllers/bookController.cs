using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookApplication.Models;
using BookApplication.Views;
using System.Data;
using System.Data.SqlClient;

namespace BookApplication.Controllers
{
   public  class bookController
    {
        public DataTable dtTable = new DataTable();
        public int change;

        
        books obj=new books();
       
        public void Show()
        {
            obj.Show();
            dtTable = obj.dtTable;
        }
        public void Close()
        {
            obj.Close();
        }
        public void performOperation()
        {
            obj.performOperation();
            dtTable = obj.dtTable;
            change = obj.a;
        }
        public void searchOpen()
        {
            obj.searchOpen();
            dtTable = obj.dtTable;

        }
        public void earchClose()
        {
            obj.earchClose();
        }
    }
}
