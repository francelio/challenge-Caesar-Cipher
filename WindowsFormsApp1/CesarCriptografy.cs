using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	public class CesarCriptografy
	{
		public static string Decipher(string input, int key)
		{
			//a-b-c-d-e-f-g-h-i-j-l-m-n-o-p-q-r-s-t-u-v-x-z
			//total=26
			var textCifrado =input.ToLower();
			return Encipher(textCifrado, 26 - key);
		}
		public static string Encipher(string input, int key)
		{
			string output = string.Empty;

			foreach (char ch in input)
				output += Cipher(ch, key);

			return output;
		}
		private static char Cipher(char ch, int key)
		{
			//	Tabela ASCII
			//    97 - a     106 - j   115 - s  
			//    98 - b     107 - k   116 - t
			//    99 - c     108 - l   117 - u
			//    100 - d    109 - m   118 - v
			//    101 - e    110 - n   119 - w
			//    102 - f    111 - o   120 - x
			//    103 - g    112 - p   121 - y
			//    104 - h    113 - q   122 - z
			//    105 - i    114 - r
			// Total=26


			if (!char.IsLetter(ch))
				return ch;

			char offset = char.IsUpper(ch) ? 'A' : 'a';
			var t1 = (ch + key);
			var t2 = ((ch + key) - offset);
			var t3 = (((ch + key) - offset) % 26);
			var t4 = (char)((((ch + key) - offset) % 26) + offset);


			return (char)((((ch + key) - offset) % 26) + offset);
		}
	}
}
