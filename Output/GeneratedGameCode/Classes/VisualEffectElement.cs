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
	public partial class VisualEffectElementData
	{
		partial void OnDataDeserialized(VisualEffectElementSerializable serializable, Database database);

		public static VisualEffectElementData Create(VisualEffectElementSerializable serializable, Database database)
		{
			return new VisualEffectElementData(serializable, database);
		}

		private VisualEffectElementData(VisualEffectElementSerializable serializable, Database database)
		{
			Type = serializable.Type;
			Image = new SpriteId(serializable.Image);
			ColorMode = serializable.ColorMode;
			Color = new Color(serializable.Color);
			Size = UnityEngine.Mathf.Clamp(serializable.Size, 0.001f, 100f);
			StartTime = UnityEngine.Mathf.Clamp(serializable.StartTime, 0f, 100f);
			Lifetime = UnityEngine.Mathf.Clamp(serializable.Lifetime, 0f, 100f);

			OnDataDeserialized(serializable, database);
		}

		public readonly VisualEffectType Type;
		public readonly SpriteId Image;
		public readonly ColorMode ColorMode;
		public readonly Color Color;
		public readonly float Size;
		public readonly float StartTime;
		public readonly float Lifetime;
	}
}
