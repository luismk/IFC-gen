/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsectionedspinecrosssectionpositions.htm
	/// </summary>
	internal  partial class SectionedSpineCrossSectionPositions 
	{
		public Axis2Placement3D[] IfcAxis2Placement3D {get;set;}

		public String[] itemType {get;set;}

		public aggregateType[] cType {get;set;}

		public String[] arraySize {get;set;}

		public SectionedSpineCrossSectionPositions(Axis2Placement3D[] ifcAxis2Placement3D,
				String[] itemType,
				aggregateType[] cType,
				String[] arraySize)
		{
			this.IfcAxis2Placement3D = ifcAxis2Placement3D;
			this.itemType = itemType;
			this.cType = cType;
			this.arraySize = arraySize;
		}
	}
}