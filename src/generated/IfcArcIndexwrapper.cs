/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcArcIndexwrapper : IfcArcIndex 
	{
		public IfcArcIndexwrapper(String id,
				String path,
				String[] pos,
				String[] itemType,
				aggregateType[] cType,
				String[] arraySize,
				Int64[] text) : base(itemType,
				cType,
				arraySize,
				text)
		{
			this.id = id;
			this.path = path;
			this.pos = pos;
		}
	}
}