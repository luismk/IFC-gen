/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/uos.htm
	/// </summary>
	internal abstract partial class uos 
	{
		public uosHeader header {get;set;}

		public String id {get;set;}

		public String[] express {get;set;}

		public String[] configuration {get;set;}

		public uos(uosHeader header,
				String id,
				String[] express,
				String[] configuration)
		{
			this.header = header;
			this.id = id;
			this.express = express;
			this.configuration = configuration;
		}
	}
}