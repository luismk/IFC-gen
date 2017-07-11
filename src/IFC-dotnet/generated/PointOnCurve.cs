/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpointoncurve.htm
	/// </summary>
	internal  partial class PointOnCurve : Point 
	{
		public Curve BasisCurve {get;set;}

		public Double PointParameter {get;set;}

		public PointOnCurve(Curve basisCurve,
				Double pointParameter,
				StyledItem styledByItem) : base(styledByItem)
		{
			this.BasisCurve = basisCurve;
			this.PointParameter = pointParameter;
		}
	}
}