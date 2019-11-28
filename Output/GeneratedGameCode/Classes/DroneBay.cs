//-------------------------------------------------------------------------------
//                                                                               
//    This code was automatically generated.                                     
//    Changes to this file may cause incorrect behavior and will be lost if      
//    the code is regenerated.                                                   
//                                                                               
//-------------------------------------------------------------------------------

using System.Linq;
using GameDatabase.Enums;
using GameDatabase.Serializable;
using GameDatabase.Types;

namespace GameDatabase.Classes
{
	public partial class DroneBayData
	{
		public static DroneBayData Create(DroneBaySerializable serializable, Database database)
		{
			return new DroneBayData(serializable, database);
		}

		private DroneBayData(DroneBaySerializable serializable, Database database)
		{
			Id = new ItemId<DroneBayData>(serializable.Id);
			database.AddDroneBay(serializable.Id, this);
			Stats = new DroneBayStats(serializable, database);
		}

		public readonly ItemId<DroneBayData> Id;
		public readonly DroneBayStats Stats;
	}

	public partial struct DroneBayStats 
	{
		partial void OnDataDeserialized(DroneBaySerializable serializable, Database database);

		public DroneBayStats(DroneBaySerializable serializable, Database database)
		{
			EnergyConsumption = UnityEngine.Mathf.Clamp(serializable.EnergyConsumption, 0f, 1000f);
			PassiveEnergyConsumption = UnityEngine.Mathf.Clamp(serializable.PassiveEnergyConsumption, 0f, 1000f);
			Range = UnityEngine.Mathf.Clamp(serializable.Range, 1f, 100f);
			DamageMultiplier = UnityEngine.Mathf.Clamp(serializable.DamageMultiplier, 0.01f, 100f);
			DefenseMultiplier = UnityEngine.Mathf.Clamp(serializable.DefenseMultiplier, 0.01f, 100f);
			SpeedMultiplier = UnityEngine.Mathf.Clamp(serializable.SpeedMultiplier, 0.01f, 100f);
			ImprovedAi = serializable.ImprovedAi;
			Capacity = UnityEngine.Mathf.Clamp(serializable.Capacity, 1, 100);
			ActivationType = serializable.ActivationType;
			LaunchSound = new AudioClipId(serializable.LaunchSound);
			LaunchEffectPrefab = serializable.LaunchEffectPrefab;
			ControlButtonIcon = serializable.ControlButtonIcon;

			OnDataDeserialized(serializable, database);
		}

		public float EnergyConsumption;
		public float PassiveEnergyConsumption;
		public float Range;
		public float DamageMultiplier;
		public float DefenseMultiplier;
		public float SpeedMultiplier;
		public bool ImprovedAi;
		public int Capacity;
		public ActivationType ActivationType;
		public AudioClipId LaunchSound;
		public string LaunchEffectPrefab;
		public string ControlButtonIcon;
	}
}
