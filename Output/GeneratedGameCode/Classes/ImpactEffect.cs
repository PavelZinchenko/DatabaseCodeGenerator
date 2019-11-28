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
	public partial class ImpactEffectData
	{
		partial void OnDataDeserialized(ImpactEffectSerializable serializable, Database database);

		public static ImpactEffectData Create(ImpactEffectSerializable serializable, Database database)
		{
			return new ImpactEffectData(serializable, database);
		}

		private ImpactEffectData(ImpactEffectSerializable serializable, Database database)
		{
			Type = serializable.Type;
			DamageType = serializable.DamageType;
			Power = UnityEngine.Mathf.Clamp(serializable.Power, 0f, 1000f);
			Factor = UnityEngine.Mathf.Clamp(serializable.Factor, 0f, 1f);

			OnDataDeserialized(serializable, database);
		}

		public readonly ImpactEffectType Type;
		public readonly DamageType DamageType;
		public readonly float Power;
		public readonly float Factor;
	}
}
