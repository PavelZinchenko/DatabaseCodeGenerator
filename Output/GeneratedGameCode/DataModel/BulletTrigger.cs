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
using GameDatabase.Model;

namespace GameDatabase.DataModel
{
	public partial class BulletTrigger
	{
		partial void OnDataDeserialized(BulletTriggerSerializable serializable, Database.Loader loader);

		public static BulletTrigger Create(BulletTriggerSerializable serializable, Database.Loader loader)
		{
			return new BulletTrigger(serializable, loader);
		}

		private BulletTrigger(BulletTriggerSerializable serializable, Database.Loader loader)
		{
			Condition = serializable.Condition;
			EffectType = serializable.EffectType;
			VisualEffect = loader.GetVisualEffect(new ItemId<VisualEffect>(serializable.VisualEffect));
			AudioClip = new AudioClipId(serializable.AudioClip);
			Ammunition = loader.GetAmmunition(new ItemId<Ammunition>(serializable.Ammunition));
			Color = new ColorData(serializable.Color);
			ColorMode = serializable.ColorMode;
			Quantity = UnityEngine.Mathf.Clamp(serializable.Quantity, 0, 1000);
			Size = UnityEngine.Mathf.Clamp(serializable.Size, 0.01f, 100f);
			Lifetime = UnityEngine.Mathf.Clamp(serializable.Lifetime, 0f, 1000f);
			Cooldown = UnityEngine.Mathf.Clamp(serializable.Cooldown, 0f, 1000f);
			RandomFactor = UnityEngine.Mathf.Clamp(serializable.RandomFactor, 0f, 1f);
			PowerMultiplier = UnityEngine.Mathf.Clamp(serializable.PowerMultiplier, 0f, 1000f);
			MaxNestingLevel = UnityEngine.Mathf.Clamp(serializable.MaxNestingLevel, 0, 100);

			OnDataDeserialized(serializable, loader);
		}

		public BulletTriggerCondition Condition { get; private set; }
		public BulletEffectType EffectType { get; private set; }
		public VisualEffect VisualEffect { get; private set; }
		public AudioClipId AudioClip { get; private set; }
		public Ammunition Ammunition { get; private set; }
		public ColorData Color { get; private set; }
		public ColorMode ColorMode { get; private set; }
		public int Quantity { get; private set; }
		public float Size { get; private set; }
		public float Lifetime { get; private set; }
		public float Cooldown { get; private set; }
		public float RandomFactor { get; private set; }
		public float PowerMultiplier { get; private set; }
		public int MaxNestingLevel { get; private set; }

		public static BulletTrigger DefaultValue { get; private set; }
	}
}
