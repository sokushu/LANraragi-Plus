namespace LANraragi_Plus.APIController.Models
{
	public class APIInfo
	{
		public string archives_per_page { get; set; } = "100";
		public string cache_last_cleared { get; set; } = "16666";
		public string debug_mode { get; set; } = "0";
		public string has_password { get; set; } = "1";
		public string motd { get; set; } = "Lanraragi";
		public string name { get; set; } = "DEMO";
		public string nofun_mode { get; set; } = "0";
		public string server_resizes_images { get; set; } = "0";
		public string server_tracks_progress { get; set; } = "0";
		public string total_pages_read { get; set; } = "30000";

		public string version { get; set; } = "0.9.10";

		public string version_desc { get; set; } = "I'm under Japanese influence and my honor's at stake!";

		public string version_name { get; set; } = "Dead Man Walking";
	}
}
