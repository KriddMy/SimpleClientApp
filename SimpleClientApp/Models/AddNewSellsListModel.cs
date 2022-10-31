using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClientApp.Models
{
    public class AddNewSellsListModel
    {
        public string  ProductName { get; set; }
        public int     Quantity { get; set; }
    }
}
