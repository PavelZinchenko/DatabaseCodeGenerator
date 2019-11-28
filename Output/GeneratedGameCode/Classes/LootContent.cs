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
	public abstract partial class LootContentData
	{
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

		public static LootContentData Create(LootContentSerializable serializable, Database database)
		{
			switch (serializable.Type)
		    {
				case LootItemType.QuestItem:
					return new LootContentData_QuestItem(serializable, database);
				case LootItemType.EmptyShip:
					return new LootContentData_EmptyShip(serializable, database);
				case LootItemType.Ship:
					return new LootContentData_Ship(serializable, database);
				case LootItemType.Component:
					return new LootContentData_Component(serializable, database);
				case LootItemType.Money:
					return new LootContentData_Money(serializable, database);
				case LootItemType.Fuel:
					return new LootContentData_Fuel(serializable, database);
				case LootItemType.Stars:
					return new LootContentData_Stars(serializable, database);
				case LootItemType.RandomComponents:
					return new LootContentData_RandomComponents(serializable, database);
				case LootItemType.RandomItems:
					return new LootContentData_RandomItems(serializable, database);
				case LootItemType.SomeMoney:
					return new LootContentData_SomeMoney(serializable, database);
				case LootItemType.AllItems:
					return new LootContentData_AllItems(serializable, database);
				case LootItemType.ItemsWithChance:
					return new LootContentData_ItemsWithChance(serializable, database);
				default:
                    throw new DatabaseException("LootContent: Invalid content type - " + serializable.Type);
			}
		}

		public abstract T Create<T>(ILootContentDataFactory<T> factory);

		protected LootContentData(LootContentSerializable serializable, Database database)
		{
			Type = serializable.Type;

			OnDataDeserialized(serializable, database);
		}

		public readonly LootItemType Type;
	}

	public interface ILootContentDataFactory<T>
    {
	    T Create(LootContentData_QuestItem content);
	    T Create(LootContentData_EmptyShip content);
	    T Create(LootContentData_Ship content);
	    T Create(LootContentData_Component content);
	    T Create(LootContentData_Money content);
	    T Create(LootContentData_Fuel content);
	    T Create(LootContentData_Stars content);
	    T Create(LootContentData_RandomComponents content);
	    T Create(LootContentData_RandomItems content);
	    T Create(LootContentData_SomeMoney content);
	    T Create(LootContentData_AllItems content);
	    T Create(LootContentData_ItemsWithChance content);
    }

    public partial class LootContentData_QuestItem : LootContentData
    {
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

  		public LootContentData_QuestItem(LootContentSerializable serializable, Database database)
            : base(serializable, database)
        {
			QuestItem = database.GetQuestItem(new ItemId<QuestItemData>(serializable.ItemId));
			MinAmount = UnityEngine.Mathf.Clamp(serializable.MinAmount, 0, 100000000);
			MaxAmount = UnityEngine.Mathf.Clamp(serializable.MaxAmount, 0, 100000000);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ILootContentDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly QuestItemData QuestItem;
		public readonly int MinAmount;
		public readonly int MaxAmount;
    }
    public partial class LootContentData_EmptyShip : LootContentData
    {
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

  		public LootContentData_EmptyShip(LootContentSerializable serializable, Database database)
            : base(serializable, database)
        {
			Ship = database.GetShip(new ItemId<ShipData>(serializable.ItemId));

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ILootContentDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly ShipData Ship;
    }
    public partial class LootContentData_Ship : LootContentData
    {
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

  		public LootContentData_Ship(LootContentSerializable serializable, Database database)
            : base(serializable, database)
        {
			ShipBuild = database.GetShipBuild(new ItemId<ShipBuildData>(serializable.ItemId));

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ILootContentDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly ShipBuildData ShipBuild;
    }
    public partial class LootContentData_Component : LootContentData
    {
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

  		public LootContentData_Component(LootContentSerializable serializable, Database database)
            : base(serializable, database)
        {
			Component = database.GetComponent(new ItemId<ComponentData>(serializable.ItemId));
			MinAmount = UnityEngine.Mathf.Clamp(serializable.MinAmount, 0, 100000000);
			MaxAmount = UnityEngine.Mathf.Clamp(serializable.MaxAmount, 0, 100000000);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ILootContentDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly ComponentData Component;
		public readonly int MinAmount;
		public readonly int MaxAmount;
    }
    public partial class LootContentData_Money : LootContentData
    {
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

  		public LootContentData_Money(LootContentSerializable serializable, Database database)
            : base(serializable, database)
        {
			MinAmount = UnityEngine.Mathf.Clamp(serializable.MinAmount, 0, 100000000);
			MaxAmount = UnityEngine.Mathf.Clamp(serializable.MaxAmount, 0, 100000000);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ILootContentDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly int MinAmount;
		public readonly int MaxAmount;
    }
    public partial class LootContentData_Fuel : LootContentData
    {
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

  		public LootContentData_Fuel(LootContentSerializable serializable, Database database)
            : base(serializable, database)
        {
			MinAmount = UnityEngine.Mathf.Clamp(serializable.MinAmount, 0, 100000000);
			MaxAmount = UnityEngine.Mathf.Clamp(serializable.MaxAmount, 0, 100000000);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ILootContentDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly int MinAmount;
		public readonly int MaxAmount;
    }
    public partial class LootContentData_Stars : LootContentData
    {
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

  		public LootContentData_Stars(LootContentSerializable serializable, Database database)
            : base(serializable, database)
        {
			MinAmount = UnityEngine.Mathf.Clamp(serializable.MinAmount, 0, 100000000);
			MaxAmount = UnityEngine.Mathf.Clamp(serializable.MaxAmount, 0, 100000000);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ILootContentDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly int MinAmount;
		public readonly int MaxAmount;
    }
    public partial class LootContentData_RandomComponents : LootContentData
    {
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

  		public LootContentData_RandomComponents(LootContentSerializable serializable, Database database)
            : base(serializable, database)
        {
			MinAmount = UnityEngine.Mathf.Clamp(serializable.MinAmount, 0, 100000000);
			MaxAmount = UnityEngine.Mathf.Clamp(serializable.MaxAmount, 0, 100000000);
			ValueRatio = UnityEngine.Mathf.Clamp(serializable.ValueRatio, 0.001f, 1000f);
			Factions = FactionFilterData.Create(serializable.Factions, database);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ILootContentDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly int MinAmount;
		public readonly int MaxAmount;
		public readonly float ValueRatio;
		public readonly FactionFilterData Factions;
    }
    public partial class LootContentData_RandomItems : LootContentData
    {
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

  		public LootContentData_RandomItems(LootContentSerializable serializable, Database database)
            : base(serializable, database)
        {
			MinAmount = UnityEngine.Mathf.Clamp(serializable.MinAmount, 0, 100000000);
			MaxAmount = UnityEngine.Mathf.Clamp(serializable.MaxAmount, 0, 100000000);
			Items = serializable.Items?.Select(item => LootItemData.Create(item, database)).ToList().AsReadOnly();

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ILootContentDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly int MinAmount;
		public readonly int MaxAmount;
		public readonly System.Collections.ObjectModel.ReadOnlyCollection<LootItemData> Items;
    }
    public partial class LootContentData_SomeMoney : LootContentData
    {
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

  		public LootContentData_SomeMoney(LootContentSerializable serializable, Database database)
            : base(serializable, database)
        {
			ValueRatio = UnityEngine.Mathf.Clamp(serializable.ValueRatio, 0.001f, 1000f);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ILootContentDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly float ValueRatio;
    }
    public partial class LootContentData_AllItems : LootContentData
    {
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

  		public LootContentData_AllItems(LootContentSerializable serializable, Database database)
            : base(serializable, database)
        {
			Items = serializable.Items?.Select(item => LootItemData.Create(item, database)).ToList().AsReadOnly();

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ILootContentDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly System.Collections.ObjectModel.ReadOnlyCollection<LootItemData> Items;
    }
    public partial class LootContentData_ItemsWithChance : LootContentData
    {
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

  		public LootContentData_ItemsWithChance(LootContentSerializable serializable, Database database)
            : base(serializable, database)
        {
			Items = serializable.Items?.Select(item => LootItemData.Create(item, database)).ToList().AsReadOnly();

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ILootContentDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly System.Collections.ObjectModel.ReadOnlyCollection<LootItemData> Items;
    }

}

