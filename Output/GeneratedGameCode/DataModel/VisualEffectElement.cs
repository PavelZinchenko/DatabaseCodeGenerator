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
	public partial class VisualEffectElement
	{
		partial void OnDataDeserialized(VisualEffectElementSerializable serializable, Database database);

		public static VisualEffectElement Create(VisualEffectElementSerializable serializable, Database database)
		{
			return new VisualEffectElement(serializable, database);
		}

		private VisualEffectElement(VisualEffectElementSerializable serializable, Database database)
		{
			Type = serializable.Type;
			Image = new SpriteId(serializable.Image, SpriteId.Type.Effect);
			ColorMode = serializable.ColorMode;
			Color = new ColorData(serializable.Color);
			Size = UnityEngine.Mathf.Clamp(serializable.Size, 0.001f, 100f);
			StartTime = UnityEngine.Mathf.Clamp(serializable.StartTime, 0f, 100f);
			Lifetime = UnityEngine.Mathf.Clamp(serializable.Lifetime, 0f, 100f);

			OnDataDeserialized(serializable, database);
		}

		public VisualEffectType Type { get; private set; }
		public SpriteId Image { get; private set; }
		public ColorMode ColorMode { get; private set; }
		public ColorData Color { get; private set; }
		public float Size { get; private set; }
		public float StartTime { get; private set; }
		public float Lifetime { get; private set; }

		public static VisualEffectElement DefaultValue { get; private set; }
	}
}
