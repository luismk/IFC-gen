/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/hexbinary.htm
	/// </summary>
	internal  partial class hexBinary 
	{
		public String extraBits {get;set;}

		public Byte[] Value {get;set;}

		public hexBinary(String extraBits,
				Byte[] value)
		{
			this.extraBits = extraBits;
			this.Value = value;
		}
	}
}