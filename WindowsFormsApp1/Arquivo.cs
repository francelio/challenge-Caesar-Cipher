using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	public class Arquivo
	{
		public static void SaveJsonData(JsonData obj)
		{
			string folder = Directory.GetCurrentDirectory();

			string arquivo = Path.Combine(folder, "answer.json");

			Directory.CreateDirectory(folder);

			File.Create(arquivo).Dispose();

			File.WriteAllText(arquivo, JsonConvert.SerializeObject(obj));
		}

		internal static Stream GetJsonStream()
		{
			string folder = Directory.GetCurrentDirectory();

			string arquivo = Path.Combine(folder, "answer.json");

			return File.Open(arquivo, FileMode.Open, FileAccess.Read);
		}
	}
}
