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
	public partial class EngineData
	{
		partial void OnDataDeserialized(EngineSerializable serializable, Database database);

		public static EngineData Create(EngineSerializable serializable, Database database)
		{
			return new EngineData(serializable, database);
		}

		private EngineData(EngineSerializable serializable, Database database)
		{
			Position = serializable.Position;
			Size = UnityEngine.Mathf.Clamp(serializable.Size, 0f, 1f);

			OnDataDeserialized(serializable, database);
		}

		public readonly Vector2 Position;
		public readonly float Size;
	}
}
