using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
* Author: Tyler
* Created: January 2017
* Assignment: Workshop 2
* Class: PROJ 207
* 
*This class is used to store the information from the Products_Suppliers table in the Travel Experts database
* 
*/
namespace Workshop2V2
{
    public class Products_Suppliers
    {
        public int ProductSupplierId { get; set; }//Property for PruductSupplierId

        public int? ProductId { get; set; }//Property for ProductId

        public int? SupplierId { get; set; }//Property for SupplierId

    }
}
