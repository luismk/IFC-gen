/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcadvancedbrepwithvoidsvoids.htm
	/// </summary>
	internal  partial class AdvancedBrepWithVoidsVoids 
	{
		public ClosedShell[] IfcClosedShell {get;set;}

		public String[] itemType {get;set;}

		public aggregateType[] cType {get;set;}

		public String[] arraySize {get;set;}

		public AdvancedBrepWithVoidsVoids(ClosedShell[] ifcClosedShell,
				String[] itemType,
				aggregateType[] cType,
				String[] arraySize)
		{
			this.IfcClosedShell = ifcClosedShell;
			this.itemType = itemType;
			this.cType = cType;
			this.arraySize = arraySize;
		}
	}
}