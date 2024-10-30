namespace TemplatePrint.Models
{
	public class OrderDetail
	{
		public string S_Company { get; set; }
		public string OriginBranchName { get; set; }
		public string DeliveryAddress { get; set; }
		public string S_TaxID_PANNO { get; set; }
		public string PlannedPickupDateTime { get; set; }
		public string DestinationBranchName { get; set; }
		public string PackagetypeName { get; set; }
		public string Package_Weight { get; set; }
		public string Description { get; set; }
		public string PaymentMode { get; set; }
		public string Package_Pcs { get; set; }
		public string S_name { get; set; }
		public string S_PhoneNo { get; set; }
		public string R_name { get; set; }
		public string PickupAddress { get; set; }
		public string R_PhoneNo { get; set; }
		public string R_TaxID_PANNO { get; set; }
		public string Remarks { get; set; }
		public string OrderCreateDateADTimeOnly { get; set; }
		public string BarCode { get; set; } // Assuming this is already generated and passed
	}
	public partial class OrderTemplate
	{

        private List<OrderDetail> _orders { get; set; }
		public OrderTemplate(List<OrderDetail> orders)
		{
            _orders = orders;
		}

	}


}
