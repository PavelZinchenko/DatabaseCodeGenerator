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
	public partial class BulletTriggerData
	{
		partial void OnDataDeserialized(BulletTriggerSerializable serializable, Database database);

		public static BulletTriggerData Create(BulletTriggerSerializable serializable, Database database)
		{
			return new BulletTriggerData(serializable, database);
		}

		private BulletTriggerData(BulletTriggerSerializable serializable, Database database)
		{
			Condition = serializable.Condition;
			EffectType = serializable.EffectType;
			VisualEffect = database.GetVisualEffect(new ItemId<VisualEffectData>(serializable.VisualEffect));
			AudioClip = new AudioClipId(serializable.AudioClip);
			Ammunition = database.GetAmmunition(new ItemId<AmmunitionData>(serializable.Ammunition));
			Color = new Color(serializable.Color);
			ColorMode = serializable.ColorMode;
			Quantity = UnityEngine.Mathf.Clamp(serializable.Quantity, 0, 1000);
			Size = UnityEngine.Mathf.Clamp(serializable.Size, 0.01f, 100f);
			Lifetime = UnityEngine.Mathf.Clamp(serializable.Lifetime, 0f, 1000f);
			Cooldown = UnityEngine.Mathf.Clamp(serializable.Cooldown, 0f, 1000f);
			RandomFactor = UnityEngine.Mathf.Clamp(serializable.RandomFactor, 0f, 1f);
			PowerMultiplier = UnityEngine.Mathf.Clamp(serializable.PowerMultiplier, 0f, 1000f);

			OnDataDeserialized(serializable, database);
		}

		public readonly BulletTriggerCondition Condition;
		public readonly BulletEffectType EffectType;
		public readonly VisualEffectData VisualEffect;
		public readonly AudioClipId AudioClip;
		public readonly AmmunitionData Ammunition;
		public readonly Color Color;
		public readonly ColorMode ColorMode;
		public readonly int Quantity;
		public readonly float Size;
		public readonly float Lifetime;
		public readonly float Cooldown;
		public readonly float RandomFactor;
		public readonly float PowerMultiplier;
	}
}
