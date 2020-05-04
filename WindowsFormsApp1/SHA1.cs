using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	public class SHA1
	{
		public static string Calculate(string text)
		{
			try
			{
				byte[] buffer = Encoding.UTF8.GetBytes(text);
				System.Security.Cryptography.SHA1CryptoServiceProvider cryptoTransformSHA1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
				string hash = BitConverter.ToString(cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");
				return hash.ToLower();
			}
			catch (Exception x)
			{
				throw new Exception(x.Message);
			}
		}
	}
}
