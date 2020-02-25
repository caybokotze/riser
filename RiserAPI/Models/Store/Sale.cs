namespace RiserAPI.Models.Store
{
    public class Sale : Base
    {
        public float PurchasePrice { get; set; }
        //Buyer
        public int ToUserId { get; set; }
        public User.User ToUser { get; set; }
        //Seller
        public int FromUserId { get; set; }
        public User.User FromUser { get; set; }
        //Purchase Info
        public int PurchaseInfoId { get; set; }
        public PurchaseInfo PurchaseInfo { get; set; }
        //Sale Listing
        public int SaleListingId { get; set; }
        public SaleListing SaleListing { get; set; }
    }
}