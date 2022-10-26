// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Data
{
    // ****************************************************************************************************
    // This is not a commercial licence, therefore only a few tables/views/stored procedures are generated.
    // ****************************************************************************************************

    // Country
    public class Country
    {
        public string Ctyid { get; set; } // ctyid (Primary key) (length: 2)
        public string Ctyname { get; set; } // ctyname (length: 50)
        public int Ctyregid { get; set; } // ctyregid

        // Foreign keys

        /// <summary>
        /// Parent Regio pointed by [Country].([Ctyregid]) (FK_Country_Country)
        /// </summary>
        public virtual Regio Regio { get; set; } // FK_Country_Country
    }

}
// </auto-generated>
