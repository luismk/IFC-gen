/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccomplexnumber.htm
	/// </summary>
	internal  partial class ComplexNumber 
	{
		public String[] itemType {get;set;}

		public aggregateType[] cType {get;set;}

		public String[] arraySize {get;set;}

		public Double[] Text {get;set;}

		public ComplexNumber(String[] itemType,
				aggregateType[] cType,
				String[] arraySize,
				Double[] text)
		{
			this.itemType = itemType;
			this.cType = cType;
			this.arraySize = arraySize;
			this.Text = text;
		}
	}
}