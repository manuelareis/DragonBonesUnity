// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using Com.Viperstudio.Geom;
using DragonBones;
namespace DragonBones
{
		public class BoneData
		{

	
	    public bool inheritScale;
		public bool inheritRotation;
		public float length;
		
		public string name;
		public string parent;
		public DBTransform global = new DBTransform();
		public DBTransform transform = new DBTransform();
		public List<IAreaData> areaDataList = new List<IAreaData>();
		


		public BoneData ()
		{
		}

		IAreaData getAreaData(string areaName) 
		{
			if (areaDataList.Count <= 0)
			{
				return null;
			}
			
			if (areaName.Length!=0)
			{
				return areaDataList[0];
			}
			
			for (int i = 0; i < areaDataList.Count; ++i)
			{
				if (areaDataList[i].name == areaName)
				{
					return areaDataList[i];
				}
			}
			
			return null;
		}

		public void dispose()
		{
			for (int i = 0; i < areaDataList.Count; ++i)
			{
				areaDataList[i].dispose();
				//delete areaDataList[i];
			}
			
			areaDataList.Clear();
		}



		}
}

