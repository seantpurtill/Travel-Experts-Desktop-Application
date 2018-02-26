using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
* Author: 
* Created: January 2017
* Assignment: Workshop 2
* Class: PROJ 207
* 
*
* 
*/
namespace Workshop2V2
{
    public class Package_Product_Suppliers
    {
        public Package_Product_Suppliers()
        { }

        public int PackageID { get; set; }
        public int ProductSupplierID { get; set; }

        // these objects are for inner join on packages from other tables
        
        public string PkgName { get; set; }
        public string SupName { get; set; }
        public string ProdName { get; set; }
       

    }
}
