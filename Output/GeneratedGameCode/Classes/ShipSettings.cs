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
	public partial class ShipSettingsData
	{
		partial void OnDataDeserialized(ShipSettingsSerializable serializable, Database database);

		public static ShipSettingsData Create(ShipSettingsSerializable serializable, Database database)
		{
			return new ShipSettingsData(serializable, database);
		}

		private ShipSettingsData(ShipSettingsSerializable serializable, Database database)
		{
			DefaultWeightPerCell = UnityEngine.Mathf.Clamp(serializable.DefaultWeightPerCell, 1f, 1000f);
			MinimumWeightPerCell = UnityEngine.Mathf.Clamp(serializable.MinimumWeightPerCell, 1f, 1000f);
			BaseArmorPoints = UnityEngine.Mathf.Clamp(serializable.BaseArmorPoints, 0f, 10000f);
			ArmorPointsPerCell = UnityEngine.Mathf.Clamp(serializable.ArmorPointsPerCell, 0f, 10000f);
			ArmorRepairCooldown = UnityEngine.Mathf.Clamp(serializable.ArmorRepairCooldown, 0f, 60f);
			BaseEnergyPoints = UnityEngine.Mathf.Clamp(serializable.BaseEnergyPoints, 0f, 1000f);
			BaseEnergyRechargeRate = UnityEngine.Mathf.Clamp(serializable.BaseEnergyRechargeRate, 0f, 100f);
			EnergyRechargeCooldown = UnityEngine.Mathf.Clamp(serializable.EnergyRechargeCooldown, 0f, 60f);
			BaseShieldRechargeRate = UnityEngine.Mathf.Clamp(serializable.BaseShieldRechargeRate, 0f, 100f);
			ShieldRechargeCooldown = UnityEngine.Mathf.Clamp(serializable.ShieldRechargeCooldown, 0f, 60f);
			BaseDroneReconstructionSpeed = UnityEngine.Mathf.Clamp(serializable.BaseDroneReconstructionSpeed, 0f, 1f);
			MaxVelocity = UnityEngine.Mathf.Clamp(serializable.MaxVelocity, 5f, 30f);
			MaxTurnRate = UnityEngine.Mathf.Clamp(serializable.MaxTurnRate, 5f, 30f);

			OnDataDeserialized(serializable, database);
		}

		public readonly float DefaultWeightPerCell;
		public readonly float MinimumWeightPerCell;
		public readonly float BaseArmorPoints;
		public readonly float ArmorPointsPerCell;
		public readonly float ArmorRepairCooldown;
		public readonly float BaseEnergyPoints;
		public readonly float BaseEnergyRechargeRate;
		public readonly float EnergyRechargeCooldown;
		public readonly float BaseShieldRechargeRate;
		public readonly float ShieldRechargeCooldown;
		public readonly float BaseDroneReconstructionSpeed;
		public readonly float MaxVelocity;
		public readonly float MaxTurnRate;
	}
}
