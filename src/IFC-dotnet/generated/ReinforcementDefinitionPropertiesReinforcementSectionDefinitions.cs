/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcreinforcementdefinitionpropertiesreinforcementsectiondefinitions.htm
	/// </summary>
	internal  partial class ReinforcementDefinitionPropertiesReinforcementSectionDefinitions 
	{
		public SectionReinforcementProperties[] IfcSectionReinforcementProperties {get;set;}

		public String[] itemType {get;set;}

		public aggregateType[] cType {get;set;}

		public String[] arraySize {get;set;}

		public ReinforcementDefinitionPropertiesReinforcementSectionDefinitions(SectionReinforcementProperties[] ifcSectionReinforcementProperties,
				String[] itemType,
				aggregateType[] cType,
				String[] arraySize)
		{
			this.IfcSectionReinforcementProperties = ifcSectionReinforcementProperties;
			this.itemType = itemType;
			this.cType = cType;
			this.arraySize = arraySize;
		}
	}
}