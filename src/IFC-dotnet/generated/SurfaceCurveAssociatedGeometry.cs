/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsurfacecurveassociatedgeometry.htm
	/// </summary>
	internal  partial class SurfaceCurveAssociatedGeometry 
	{
		public Pcurve[] IfcPcurve {get;set;}

		public String[] itemType {get;set;}

		public aggregateType[] cType {get;set;}

		public String[] arraySize {get;set;}

		public SurfaceCurveAssociatedGeometry(Pcurve[] ifcPcurve,
				String[] itemType,
				aggregateType[] cType,
				String[] arraySize)
		{
			this.IfcPcurve = ifcPcurve;
			this.itemType = itemType;
			this.cType = cType;
			this.arraySize = arraySize;
		}
	}
}