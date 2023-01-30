//-------------------------------------------------------------------------------
//                                                                               
//    This code was automatically generated.                                     
//    Changes to this file may cause incorrect behavior and will be lost if      
//    the code is regenerated.                                                   
//                                                                               
//-------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using EditorDatabase.Enums;
using EditorDatabase.Model;

namespace EditorDatabase.Serializable
{
	[Serializable]
	public class DroneBaySerializable : SerializableItem
	{
		public float EnergyConsumption;
		public float PassiveEnergyConsumption;
		public float Range;
		public float DamageMultiplier;
		public float DefenseMultiplier;
		public float SpeedMultiplier;
		public int BuildExtraCycles;
		public bool ImprovedAi;
		public int Capacity;
		public ActivationType ActivationType;
		[DefaultValue("")]
		public string LaunchSound;
		[DefaultValue("")]
		public string LaunchEffectPrefab;
		[DefaultValue("")]
		public string ControlButtonIcon;
	}
}
