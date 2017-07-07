/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifclineindexwrapper.htm
	/// </summary>
	internal  partial class LineIndex : LineIndex 
	{
		public String id {get;set;}

		public String path {get;set;}

		public String[] pos {get;set;}

		public LineIndex(String id,
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