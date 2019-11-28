//-------------------------------------------------------------------------------
//                                                                               
//    This code was automatically generated.                                     
//    Changes to this file may cause incorrect behavior and will be lost if      
//    the code is regenerated.                                                   
//                                                                               
//-------------------------------------------------------------------------------

using System;
using GameDatabase.Enums;
using GameDatabase.Types;

namespace GameDatabase.Serializable
{
	[Serializable]
	public class FactionSerializable : SerializableItem
	{
		public string Type;
		public string Color;
		public int HomeStarDistance;
		public int WanderingShipsDistance;
		public bool Hidden;
	}
}
