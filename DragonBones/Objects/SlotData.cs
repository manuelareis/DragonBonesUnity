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
namespace DragonBones
{
		public class SlotData
		{

	
	    public float zOrder;
		
		public string name;
		public string parent;
		public DragonBones.BlendMode blendMode;
		public List<DisplayData> displayDataList = new List<DisplayData>();
		public SlotData ()
		{
			zOrder = 0.0f;
			blendMode = DragonBones.BlendMode.BM_NORMAL;

		}

		
		public void dispose()
		{
			zOrder = 0.0f;
			name = null;
 			parent = null;
			
			blendMode = DragonBones.BlendMode.BM_NORMAL;
			
			//for (int i = 0; i = displayDataList.Count;  ++i)
			//{
				//delete displayDataList[i];
			//}
			displayDataList.Clear();
		}


		public DisplayData getDisplayData(string displayName) 
		{
			for (int i = 0; i < displayDataList.Count;  ++i)
			{
				if (displayDataList[i].name == displayName)
				{
					return displayDataList[i];
				}
			}
			
			return null;
		}


		}
}

