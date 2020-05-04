using Newtonsoft.Json;

namespace WindowsFormsApp1
{
	public class JsonData
	{
		[JsonProperty("numero_casas")]
		public int NumeroCasas { get; set; }
		[JsonProperty("token")]
		public string Token { get; set; }
		[JsonProperty("cifrado")]
		public string Cifrado { get; set; }
		[JsonProperty("decifrado")]
		public string Decifrado { get; set; }
		[JsonProperty("resumo_criptografico")]
		public string ResumoCriptografico { get; set; }
	}
}