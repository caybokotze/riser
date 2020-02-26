using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RiserAPI.Models.Store
{
    public class PurchaseInfo : Base
    {
        public string Reference { get; set; }

        public IEnumerable<Sale> Sales { get; set; }
    }
    
    public class PurchaseInfoConfiguration : IEntityTypeConfiguration<PurchaseInfo>
    {
        public void Configure(EntityTypeBuilder<PurchaseInfo> builder)
        {
            builder.HasKey(k => k.Id);
        }
    }
}