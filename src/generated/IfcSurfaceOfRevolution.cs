/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcSurfaceOfRevolution : IfcSweptSurface 
	{
		public IfcSurfaceOfRevolution(IfcAxis1Placement axisPosition,
				IfcProfileDef sweptCurve,
				IfcAxis2Placement3D position,
				IfcStyledItem styledByItem) : base(sweptCurve,
				position,
				styledByItem)
		{
			this.AxisPosition = axisPosition;
		}
	}
}