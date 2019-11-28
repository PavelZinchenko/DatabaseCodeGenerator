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
	public partial class DeviceData
	{
		partial void OnDataDeserialized(DeviceSerializable serializable, Database database);

		public static DeviceData Create(DeviceSerializable serializable, Database database)
		{
			return new DeviceData(serializable, database);
		}

		private DeviceData(DeviceSerializable serializable, Database database)
		{
			Id = new ItemId<DeviceData>(serializable.Id);
			database.AddDevice(serializable.Id, this);

			DeviceClass = serializable.DeviceClass;
			EnergyConsumption = UnityEngine.Mathf.Clamp(serializable.EnergyConsumption, 0f, 1000f);
			PassiveEnergyConsumption = UnityEngine.Mathf.Clamp(serializable.PassiveEnergyConsumption, 0f, 1000f);
			Power = UnityEngine.Mathf.Clamp(serializable.Power, 0f, 1000f);
			Range = UnityEngine.Mathf.Clamp(serializable.Range, 0f, 1000f);
			Size = UnityEngine.Mathf.Clamp(serializable.Size, 0f, 1000f);
			Cooldown = UnityEngine.Mathf.Clamp(serializable.Cooldown, 0f, 1000f);
			Offset = serializable.Offset;
			ActivationType = serializable.ActivationType;
			Color = new Color(serializable.Color);
			Sound = new AudioClipId(serializable.Sound);
			EffectPrefab = serializable.EffectPrefab;
			ObjectPrefab = serializable.ObjectPrefab;
			ControlButtonIcon = serializable.ControlButtonIcon;

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<DeviceData> Id;

		public readonly DeviceClass DeviceClass;
		public readonly float EnergyConsumption;
		public readonly float PassiveEnergyConsumption;
		public readonly float Power;
		public readonly float Range;
		public readonly float Size;
		public readonly float Cooldown;
		public readonly Vector2 Offset;
		public readonly ActivationType ActivationType;
		public readonly Color Color;
		public readonly AudioClipId Sound;
		public readonly string EffectPrefab;
		public readonly string ObjectPrefab;
		public readonly string ControlButtonIcon;
	}
}
