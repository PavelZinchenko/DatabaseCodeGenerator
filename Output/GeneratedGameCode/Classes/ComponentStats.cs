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
	public partial class ComponentStatsData
	{
		partial void OnDataDeserialized(ComponentStatsSerializable serializable, Database database);

		public static ComponentStatsData Create(ComponentStatsSerializable serializable, Database database)
		{
			return new ComponentStatsData(serializable, database);
		}

		private ComponentStatsData(ComponentStatsSerializable serializable, Database database)
		{
			Id = new ItemId<ComponentStatsData>(serializable.Id);
			database.AddComponentStats(serializable.Id, this);

			Type = serializable.Type;
			ArmorPoints = UnityEngine.Mathf.Clamp(serializable.ArmorPoints, -1000f, 1000f);
			ArmorRepairRate = UnityEngine.Mathf.Clamp(serializable.ArmorRepairRate, -1000f, 1000f);
			ArmorRepairCooldownModifier = UnityEngine.Mathf.Clamp(serializable.ArmorRepairCooldownModifier, -1f, 1f);
			EnergyPoints = UnityEngine.Mathf.Clamp(serializable.EnergyPoints, -1000f, 1000f);
			EnergyRechargeRate = UnityEngine.Mathf.Clamp(serializable.EnergyRechargeRate, -1000f, 1000f);
			EnergyRechargeCooldownModifier = UnityEngine.Mathf.Clamp(serializable.EnergyRechargeCooldownModifier, -1f, 1f);
			ShieldPoints = UnityEngine.Mathf.Clamp(serializable.ShieldPoints, -1000f, 1000f);
			ShieldRechargeRate = UnityEngine.Mathf.Clamp(serializable.ShieldRechargeRate, -1000f, 1000f);
			ShieldRechargeCooldownModifier = UnityEngine.Mathf.Clamp(serializable.ShieldRechargeCooldownModifier, -1f, 1f);
			Weight = UnityEngine.Mathf.Clamp(serializable.Weight, -10000f, 10000f);
			RammingDamage = UnityEngine.Mathf.Clamp(serializable.RammingDamage, 0f, 1000f);
			EnergyAbsorption = UnityEngine.Mathf.Clamp(serializable.EnergyAbsorption, 0f, 1000f);
			KineticResistance = UnityEngine.Mathf.Clamp(serializable.KineticResistance, -1000f, 1000f);
			EnergyResistance = UnityEngine.Mathf.Clamp(serializable.EnergyResistance, -1000f, 1000f);
			ThermalResistance = UnityEngine.Mathf.Clamp(serializable.ThermalResistance, -1000f, 1000f);
			EnginePower = UnityEngine.Mathf.Clamp(serializable.EnginePower, 0f, 20f);
			TurnRate = UnityEngine.Mathf.Clamp(serializable.TurnRate, 0f, 20f);
			Autopilot = serializable.Autopilot;
			DroneRangeModifier = UnityEngine.Mathf.Clamp(serializable.DroneRangeModifier, -5f, 5f);
			DroneDamageModifier = UnityEngine.Mathf.Clamp(serializable.DroneDamageModifier, -5f, 5f);
			DroneDefenseModifier = UnityEngine.Mathf.Clamp(serializable.DroneDefenseModifier, -5f, 5f);
			DroneSpeedModifier = UnityEngine.Mathf.Clamp(serializable.DroneSpeedModifier, -5f, 5f);
			DronesBuiltPerSecond = UnityEngine.Mathf.Clamp(serializable.DronesBuiltPerSecond, 0f, 10f);
			DroneBuildTimeModifier = UnityEngine.Mathf.Clamp(serializable.DroneBuildTimeModifier, 0f, 10f);
			WeaponFireRateModifier = UnityEngine.Mathf.Clamp(serializable.WeaponFireRateModifier, -1f, 1f);
			WeaponDamageModifier = UnityEngine.Mathf.Clamp(serializable.WeaponDamageModifier, -1f, 1f);
			WeaponRangeModifier = UnityEngine.Mathf.Clamp(serializable.WeaponRangeModifier, -1f, 1f);
			WeaponEnergyCostModifier = UnityEngine.Mathf.Clamp(serializable.WeaponEnergyCostModifier, -1f, 1f);
			AlterWeaponPlatform = serializable.AlterWeaponPlatform;

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<ComponentStatsData> Id;

		public readonly ComponentStatsType Type;
		public readonly float ArmorPoints;
		public readonly float ArmorRepairRate;
		public readonly float ArmorRepairCooldownModifier;
		public readonly float EnergyPoints;
		public readonly float EnergyRechargeRate;
		public readonly float EnergyRechargeCooldownModifier;
		public readonly float ShieldPoints;
		public readonly float ShieldRechargeRate;
		public readonly float ShieldRechargeCooldownModifier;
		public readonly float Weight;
		public readonly float RammingDamage;
		public readonly float EnergyAbsorption;
		public readonly float KineticResistance;
		public readonly float EnergyResistance;
		public readonly float ThermalResistance;
		public readonly float EnginePower;
		public readonly float TurnRate;
		public readonly bool Autopilot;
		public readonly float DroneRangeModifier;
		public readonly float DroneDamageModifier;
		public readonly float DroneDefenseModifier;
		public readonly float DroneSpeedModifier;
		public readonly float DronesBuiltPerSecond;
		public readonly float DroneBuildTimeModifier;
		public readonly float WeaponFireRateModifier;
		public readonly float WeaponDamageModifier;
		public readonly float WeaponRangeModifier;
		public readonly float WeaponEnergyCostModifier;
		public readonly PlatformType AlterWeaponPlatform;
	}
}
