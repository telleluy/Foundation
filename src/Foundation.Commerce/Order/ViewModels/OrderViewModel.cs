using EPiServer.Commerce.Order;
using Foundation.Commerce.Customer.ViewModels;
using System.Collections.Generic;

namespace Foundation.Commerce.Order.ViewModels
{
    public class OrderViewModel
    {
        public IPurchaseOrder PurchaseOrder { get; set; }
        public IEnumerable<OrderHistoryItemViewModel> Items { get; set; }
        public AddressModel BillingAddress { get; set; }
        public IList<AddressModel> ShippingAddresses { get; set; }
        public string QuoteStatus { get; set; }
        public int OrderGroupId { get; set; }
    }
}