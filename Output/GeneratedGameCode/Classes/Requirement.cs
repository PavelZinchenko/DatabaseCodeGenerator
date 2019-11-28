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
	public abstract partial class RequirementData
	{
		partial void OnDataDeserialized(RequirementSerializable serializable, Database database);

		public static RequirementData Create(RequirementSerializable serializable, Database database)
		{
			switch (serializable.Type)
		    {
				case RequirementType.HaveItemById:
					return new RequirementData_HaveItemById(serializable, database);
				case RequirementType.HaveQuestItem:
					return new RequirementData_HaveQuestItem(serializable, database);
				case RequirementType.QuestCompleted:
					return new RequirementData_QuestCompleted(serializable, database);
				case RequirementType.QuestActive:
					return new RequirementData_QuestActive(serializable, database);
				case RequirementType.PlayerPosition:
					return new RequirementData_PlayerPosition(serializable, database);
				case RequirementType.RandomStarSystem:
					return new RequirementData_RandomStarSystem(serializable, database);
				case RequirementType.CharacterRelations:
					return new RequirementData_CharacterRelations(serializable, database);
				case RequirementType.FactionRelations:
					return new RequirementData_FactionRelations(serializable, database);
				case RequirementType.Faction:
					return new RequirementData_Faction(serializable, database);
				case RequirementType.HaveItem:
					return new RequirementData_HaveItem(serializable, database);
				case RequirementType.All:
					return new RequirementData_All(serializable, database);
				case RequirementType.Any:
					return new RequirementData_Any(serializable, database);
				case RequirementType.None:
					return new RequirementData_None(serializable, database);
				default:
                    throw new DatabaseException("Requirement: Invalid content type - " + serializable.Type);
			}
		}

		public abstract T Create<T>(IRequirementDataFactory<T> factory);

		protected RequirementData(RequirementSerializable serializable, Database database)
		{
			Type = serializable.Type;

			OnDataDeserialized(serializable, database);
		}

		public readonly RequirementType Type;
	}

	public interface IRequirementDataFactory<T>
    {
	    T Create(RequirementData_HaveItemById content);
	    T Create(RequirementData_HaveQuestItem content);
	    T Create(RequirementData_QuestCompleted content);
	    T Create(RequirementData_QuestActive content);
	    T Create(RequirementData_PlayerPosition content);
	    T Create(RequirementData_RandomStarSystem content);
	    T Create(RequirementData_CharacterRelations content);
	    T Create(RequirementData_FactionRelations content);
	    T Create(RequirementData_Faction content);
	    T Create(RequirementData_HaveItem content);
	    T Create(RequirementData_All content);
	    T Create(RequirementData_Any content);
	    T Create(RequirementData_None content);
    }

    public partial class RequirementData_HaveItemById : RequirementData
    {
		partial void OnDataDeserialized(RequirementSerializable serializable, Database database);

  		public RequirementData_HaveItemById(RequirementSerializable serializable, Database database)
            : base(serializable, database)
        {
			Loot = database.GetLoot(new ItemId<LootData>(serializable.ItemId));

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(IRequirementDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly LootData Loot;
    }
    public partial class RequirementData_HaveQuestItem : RequirementData
    {
		partial void OnDataDeserialized(RequirementSerializable serializable, Database database);

  		public RequirementData_HaveQuestItem(RequirementSerializable serializable, Database database)
            : base(serializable, database)
        {
			QuestItem = database.GetQuestItem(new ItemId<QuestItemData>(serializable.ItemId));

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(IRequirementDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly QuestItemData QuestItem;
    }
    public partial class RequirementData_QuestCompleted : RequirementData
    {
		partial void OnDataDeserialized(RequirementSerializable serializable, Database database);

  		public RequirementData_QuestCompleted(RequirementSerializable serializable, Database database)
            : base(serializable, database)
        {
			Quest = database.GetQuest(new ItemId<QuestData>(serializable.ItemId));

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(IRequirementDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly QuestData Quest;
    }
    public partial class RequirementData_QuestActive : RequirementData
    {
		partial void OnDataDeserialized(RequirementSerializable serializable, Database database);

  		public RequirementData_QuestActive(RequirementSerializable serializable, Database database)
            : base(serializable, database)
        {
			Quest = database.GetQuest(new ItemId<QuestData>(serializable.ItemId));

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(IRequirementDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly QuestData Quest;
    }
    public partial class RequirementData_PlayerPosition : RequirementData
    {
		partial void OnDataDeserialized(RequirementSerializable serializable, Database database);

  		public RequirementData_PlayerPosition(RequirementSerializable serializable, Database database)
            : base(serializable, database)
        {
			MinValue = UnityEngine.Mathf.Clamp(serializable.MinValue, 0, 1000);
			MaxValue = UnityEngine.Mathf.Clamp(serializable.MaxValue, 0, 1000);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(IRequirementDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly int MinValue;
		public readonly int MaxValue;
    }
    public partial class RequirementData_RandomStarSystem : RequirementData
    {
		partial void OnDataDeserialized(RequirementSerializable serializable, Database database);

  		public RequirementData_RandomStarSystem(RequirementSerializable serializable, Database database)
            : base(serializable, database)
        {
			MinValue = UnityEngine.Mathf.Clamp(serializable.MinValue, 0, 1000);
			MaxValue = UnityEngine.Mathf.Clamp(serializable.MaxValue, 0, 1000);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(IRequirementDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly int MinValue;
		public readonly int MaxValue;
    }
    public partial class RequirementData_CharacterRelations : RequirementData
    {
		partial void OnDataDeserialized(RequirementSerializable serializable, Database database);

  		public RequirementData_CharacterRelations(RequirementSerializable serializable, Database database)
            : base(serializable, database)
        {
			MinValue = UnityEngine.Mathf.Clamp(serializable.MinValue, -100, 100);
			MaxValue = UnityEngine.Mathf.Clamp(serializable.MaxValue, -100, 100);
			Character = database.GetCharacter(new ItemId<CharacterData>(serializable.Character));

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(IRequirementDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly int MinValue;
		public readonly int MaxValue;
		public readonly CharacterData Character;
    }
    public partial class RequirementData_FactionRelations : RequirementData
    {
		partial void OnDataDeserialized(RequirementSerializable serializable, Database database);

  		public RequirementData_FactionRelations(RequirementSerializable serializable, Database database)
            : base(serializable, database)
        {
			MinValue = UnityEngine.Mathf.Clamp(serializable.MinValue, -100, 100);
			MaxValue = UnityEngine.Mathf.Clamp(serializable.MaxValue, -100, 100);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(IRequirementDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly int MinValue;
		public readonly int MaxValue;
    }
    public partial class RequirementData_Faction : RequirementData
    {
		partial void OnDataDeserialized(RequirementSerializable serializable, Database database);

  		public RequirementData_Faction(RequirementSerializable serializable, Database database)
            : base(serializable, database)
        {
			Faction = database.GetFaction(new ItemId<FactionData>(serializable.Faction));

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(IRequirementDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly FactionData Faction;
    }
    public partial class RequirementData_HaveItem : RequirementData
    {
		partial void OnDataDeserialized(RequirementSerializable serializable, Database database);

  		public RequirementData_HaveItem(RequirementSerializable serializable, Database database)
            : base(serializable, database)
        {
			Loot = LootContentData.Create(serializable.Loot, database);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(IRequirementDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly LootContentData Loot;
    }
    public partial class RequirementData_All : RequirementData
    {
		partial void OnDataDeserialized(RequirementSerializable serializable, Database database);

  		public RequirementData_All(RequirementSerializable serializable, Database database)
            : base(serializable, database)
        {
			Requirements = serializable.Requirements?.Select(item => RequirementData.Create(item, database)).ToList().AsReadOnly();

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(IRequirementDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly System.Collections.ObjectModel.ReadOnlyCollection<RequirementData> Requirements;
    }
    public partial class RequirementData_Any : RequirementData
    {
		partial void OnDataDeserialized(RequirementSerializable serializable, Database database);

  		public RequirementData_Any(RequirementSerializable serializable, Database database)
            : base(serializable, database)
        {
			Requirements = serializable.Requirements?.Select(item => RequirementData.Create(item, database)).ToList().AsReadOnly();

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(IRequirementDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly System.Collections.ObjectModel.ReadOnlyCollection<RequirementData> Requirements;
    }
    public partial class RequirementData_None : RequirementData
    {
		partial void OnDataDeserialized(RequirementSerializable serializable, Database database);

  		public RequirementData_None(RequirementSerializable serializable, Database database)
            : base(serializable, database)
        {
			Requirements = serializable.Requirements?.Select(item => RequirementData.Create(item, database)).ToList().AsReadOnly();

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(IRequirementDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly System.Collections.ObjectModel.ReadOnlyCollection<RequirementData> Requirements;
    }

}

