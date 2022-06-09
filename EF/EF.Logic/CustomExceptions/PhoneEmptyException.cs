using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Logic.CustomExceptions
{ 
	public class PhoneEmptyException : Exception
	{
		public PhoneEmptyException() : base("No ingreso el telefono de manera correcta")
		{
		}
	}
}

