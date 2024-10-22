namespace LANraragi_Plus.APIController.Models
{
	public class APISearch
	{
		public List<string> data { get; set; } = new List<string>();
		public string draw { get; set; } = "5";
		public int recordsFiltered { get; set; } = 0;
		public int recordsTotal { get; set; } = 0;
	}
}
