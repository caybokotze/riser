using System.Collections.Generic;

namespace RiserAPI.Models.Store
{
    public class PurchaseInfo : Base
    {
        public string Reference { get; set; }

        public IEnumerable<Sale> Sales { get; set; }
    }
}