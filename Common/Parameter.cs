using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreto.Models.Common
{
   public  static class Parameter
    {
        public const string Connectionstring = @"Server=DESKTOP-GOCGBT4\SQLEXPRESS;Database=FerretoS;Trusted_Connection=True;MultipleActiveResultSets=true;";

		private static string _secretKey;

		public static string SecretKey
		{
			get { return _secretKey; }
			set { _secretKey = value; }
		}

		public static String Str(string cadena)
		{
			byte[] encoder = new byte[cadena.Length];
			byte[] enconder = Encoding.UTF8.GetBytes(cadena);
			SecretKey = UTF32Encoding.Unicode.GetString(encoder) ;
			return SecretKey;
		}
	}
}
