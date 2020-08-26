using System;
using System.Text.RegularExpressions;

namespace AbadiaFramework
{
	/// <summary>
	/// validador Class  use Regular expresion in Abadia Proyects
	/// </summary>
	public class validador
	{


		//Expresiones de la  libreria de validación por 

		/// <summary>
		/// URL regular expresion for URL
		/// </summary>
		public const string URL = "/^(https?:\\/\\/)?([\\da-z\\.-]+)\\.([a-z\\.]{2,6})([\\/\\w \\?=.-]*)*\\/?$/";

		/// <summary>
		///  eMail regular expresion for  email data
		/// </summary>
		public const string eMail = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";


		/// <summary>
		/// Telefono  regular expresion for phone numbers in Mexico
		/// </summary>
		public const string Telefono = "^[+-]?\\d+(\\.\\d+)?$";

		/// <summary>
		///  TarjetaBancaria  regular expresion for validating  credit cards numbers  
		/// </summary>
		public const string TarjetaBancaria = "^((67\\d{2})|(4\\d{3})|(5[1-5]\\d{2})|(6011))(-?\\s?\\d{4}){3}|(3[4,7])\\ d{2}-?\\s?\\d{6}-?\\s?\\d{5}$";

		/// <summary>
		///  CodigoPostal  regular expresion for validating  Postal Codes in Mexico
		/// </summary>
		public const string CodigoPostal = "^([1-9]{2}|[0-9][1-9]|[1-9][0-9])[0-9]{3}$";

		/// <summary>
		/// Nombres regular expresion for   First Name and Last Name
		/// </summary>
		public const string Nombres = "[a-zA-ZñÑ\\s]{2,50}";

		/// <summary>
		/// Direcciones  regular expresion for  Address
		/// </summary>
		public const string Direcciones = "^.*(?=.*[0-9])(?=.*[a-zA-ZñÑ\\s]).*$";

		/// <summary>
		///  INE  regular expresion for IFE data code
		/// </summary>
		public const string INE = "^.*(?=.{13})[+-]?\\d+(\\.\\d+)?$";

		/// <summary>
		/// CURP  regular expresion for CURP  data structure
		/// </summary>
		//public const string CURP = "^.*(?=.{18})(?=.*[0-9])(?=.*[A-ZÑ]).*$";
		public const string CURP = "^([A-Z][A,E,I,O,U,X][A-Z]{2})(\\d{2})((01|03|05|07|08|10|12)(0[1-9]|[12]\\d|3[01])|02(0[1-9]|[12]\\d)|(04|06|09|11)(0[1-9]|[12]\\d|30))([M,H])(AS|BC|BS|CC|CS|CH|CL|CM|DF|DG|GT|GR|HG|JC|MC|MN|MS|NT|NL|OC|PL|QT|QR|SP|SL|SR|TC|TS|TL|VZ|YN|ZS|NE)([B,C,D,F,G,H,J,K,L,M,N,Ñ,P,Q,R,S,T,V,W,X,Y,Z]{3})([0-9,A-Z][0-9])$";

		/// <summary>
		/// RFC  regular expresion for valid stricture RFC data 
		/// </summary>
		//public const string RFC = "/^([A-Z,Ñ,&]{3,4}([0-9]{2})(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])[A-Z|\\d]{3})$/";
		public const string RFC = "^[A-Z,Ñ,&]{3,4}[0-9]{2}[0-1][0-9][0-3][0-9][A-Z,0-9]?[A-Z,0-9]?[0-9,A-Z]?$";

		/// <summary>
		/// Numeros regular expresion for validatin Numbers only data
		/// </summary>
		public const string Numeros = "[0-9]{1,9}(\\.[0-9]{0,2})?$";

		/// <summary>
		/// textos  regular expresion for only text information data
		/// </summary>
		public const string textos = "[a-zA-ZñÑ\\s]";

		// password 
		public const string password = "[^a-zA-z0-9 ]+";

		/// <summary>
		/// Constructor validador
		/// </summary>
		public validador() { }

		/// <summary>
		/// esAlfabetico  get cadena  and return true or false state
		/// </summary>
		/// <param name="cadena"></param>
		/// <returns></returns>
		public static bool esAlfabetico(string cadena)
		{
			if (Regex.IsMatch(cadena, textos))
			{
				if (Regex.Replace(cadena, textos, string.Empty).Length == 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				return false;
			}

		}

		/// <summary>
		///  esNumerico  send cadena and return true or false is data in string has numbers 
		/// </summary>
		/// <param name="cadena"></param>
		/// <returns></returns>
		public static bool esnumerico(string cadena)
		{

			if (cadena != null)
			{

				if (Regex.IsMatch(cadena, Numeros))
				{
					if (Regex.Replace(cadena, Numeros, string.Empty).Length == 0)
					{
						return true;
					}
					else
					{
						return false;
					}
				}
				else
				{
					return false;
				}
			}
			else return false;

		}


		/// <summary>
		/// emailEsValido   get string and return state if email is valid true or false
		/// </summary>
		/// <param name="email"></param>
		/// <returns>bool</returns>
		public static bool emailEsValido(string email)
		{
			//string expresion;
			//expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
			if (email != null)
			{

				if (Regex.IsMatch(email, eMail))
				{
					if (Regex.Replace(email, eMail, string.Empty).Length == 0)
					{
						return true;
					}
					else
					{
						return false;
					}
				}
				else
				{
					return false;
				}
			}
			else { return false; }
		}

		/// <summary>
		/// validaPassword  send cadena to validate password rules
		/// </summary>
		/// <param name="cadena"></param>
		/// <returns></returns>
		public static bool validaPassword(string cadena)
		{


			if (Regex.IsMatch(cadena, password))
			{
				if (Regex.Replace(cadena, password, string.Empty).Length == 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				return false;
			}

		}

		/// <summary>
		/// validaTelefono  nos determina si es un teléfono en mexico si o no
		/// </summary>
		/// <param name="cadena"></param>
		/// <returns></returns>
		public static bool validaTelefono(string cadena)
		{


			if (Regex.IsMatch(cadena, Telefono))
			{
				if (Regex.Replace(cadena, Telefono, string.Empty).Length == 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				return false;
			}

		}


		/// <summary>
		/// validaTelefono  nos determina si es un RFC valido
		/// </summary>
		/// <param name="cadena"></param>
		/// <returns></returns>
		public static bool validaRfc(string cadena)
		{


			if (Regex.IsMatch(cadena, RFC))
			{
				if (Regex.Replace(cadena, RFC, string.Empty).Length == 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				return false;
			}

		}



		/// <summary>
		/// validaCurp  nos determina si es un curp valido
		/// </summary>
		/// <param name="cadena"></param>
		/// <returns></returns>
		public static bool validaCurp(string cadena)
		{


			if (Regex.IsMatch(cadena, CURP))
			{
				if (Regex.Replace(cadena, CURP, string.Empty).Length == 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				return false;
			}

		}

	}
}