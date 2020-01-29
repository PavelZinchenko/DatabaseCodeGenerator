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
	public abstract partial class LootContent
	{
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

		public static LootContent Create(LootContentSerializable serializable, Database database)
		{
			switch (serializable.Type)
		    {
				case LootItemType.None:
					return new LootContent_None(serializable, database);
				case LootItemType.SomeMoney:
					return new LootContent_SomeMoney(serializable, database);
				case LootItemType.Fuel:
					return new LootContent_Fuel(serializable, database);
				case LootItemType.Money:
					return new LootContent_Money(serializable, database);
				case LootItemType.Stars:
					return new LootContent_Stars(serializable, database);
				case LootItemType.StarMap:
					return new LootContent_StarMap(serializable, database);
				case LootItemType.RandomComponents:
					return new LootContent_RandomComponents(serializable, database);
				case LootItemType.RandomItems:
					return new LootContent_RandomItems(serializable, database);
				case LootItemType.AllItems:
					return new LootContent_AllItems(serializable, database);
				case LootItemType.ItemsWithChance:
					return new LootContent_ItemsWithChance(serializable, database);
				case LootItemType.QuestItem:
					return new LootContent_QuestItem(serializable, database);
				case LootItemType.Ship:
					return new LootContent_Ship(serializable, database);
				case LootItemType.EmptyShip:
					return new LootContent_EmptyShip(serializable, database);
				case LootItemType.Component:
					return new LootContent_Component(serializable, database);
				default:
                    throw new DatabaseException("LootContent: Invalid content type - " + serializable.Type);
			}
		}

		public abstract T Create<T>(ILootContentFactory<T> factory);

		protected LootContent(LootContentSerializable serializable, Database database)
		{
			Type = serializable.Type;

			OnDataDeserialized(serializable, database);
		}

		public LootItemType Type { get; private set; }

		public static LootContent DefaultValue { get; private set; }
	}

	public interface ILootContentFactory<T>
    {
	    T Create(LootContent_None content);
	    T Create(LootContent_SomeMoney content);
	    T Create(LootContent_Fuel content);
	    T Create(LootContent_Money content);
	    T Create(LootContent_Stars content);
	    T Create(LootContent_StarMap content);
	    T Create(LootContent_RandomComponents content);
	    T Create(LootContent_RandomItems content);
	    T Create(LootContent_AllItems content);
	    T Create(LootContent_ItemsWithChance content);
	    T Create(LootContent_QuestItem content);
	    T Create(LootContent_Ship content);
	    T Create(LootContent_EmptyShip content);
	    T Create(LootContent_Component content);
    }

    public partial class LootContent_None : LootContent
    {
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

  		public LootContent_None(LootContentSerializable serializable, Database database)
            : base(serializable, database)
        {

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ILootContentFactory<T> factory)
        {
            return factory.Create(this);
        }

    }
    public partial class LootContent_SomeMoney : LootContent
    {
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

  		public LootContent_SomeMoney(LootContentSerializable serializable, Database database)
            : base(serializable, database)
        {
			ValueRatio = UnityEngine.Mathf.Clamp(serializable.ValueRatio, 0.001f, 1000f);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ILootContentFactory<T> factory)
        {
            return factory.Create(this);
        }

		public float ValueRatio { get; private set; }
    }
    public partial class LootContent_Fuel : LootContent
    {
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

  		public LootContent_Fuel(LootContentSerializable serializable, Database database)
            : base(serializable, database)
        {
			MinAmount = UnityEngine.Mathf.Clamp(serializable.MinAmount, 0, 100000000);
			MaxAmount = UnityEngine.Mathf.Clamp(serializable.MaxAmount, 0, 100000000);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ILootContentFactory<T> factory)
        {
            return factory.Create(this);
        }

		public int MinAmount { get; private set; }
		public int MaxAmount { get; private set; }
    }
    public partial class LootContent_Money : LootContent
    {
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

  		public LootContent_Money(LootContentSerializable serializable, Database database)
            : base(serializable, database)
        {
			MinAmount = UnityEngine.Mathf.Clamp(serializable.MinAmount, 0, 100000000);
			MaxAmount = UnityEngine.Mathf.Clamp(serializable.MaxAmount, 0, 100000000);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ILootContentFactory<T> factory)
        {
            return factory.Create(this);
        }

		public int MinAmount { get; private set; }
		public int MaxAmount { get; private set; }
    }
    public partial class LootContent_Stars : LootContent
    {
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

  		public LootContent_Stars(LootContentSerializable serializable, Database database)
            : base(serializable, database)
        {
			MinAmount = UnityEngine.Mathf.Clamp(serializable.MinAmount, 0, 100000000);
			MaxAmount = UnityEngine.Mathf.Clamp(serializable.MaxAmount, 0, 100000000);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ILootContentFactory<T> factory)
        {
            return factory.Create(this);
        }

		public int MinAmount { get; private set; }
		public int MaxAmount { get; private set; }
    }
    public partial class LootContent_StarMap : LootContent
    {
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

  		public LootContent_StarMap(LootContentSerializable serializable, Database database)
            : base(serializable, database)
        {

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ILootContentFactory<T> factory)
        {
            return factory.Create(this);
        }

    }
    public partial class LootContent_RandomComponents : LootContent
    {
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

  		public LootContent_RandomComponents(LootContentSerializable serializable, Database database)
            : base(serializable, database)
        {
			MinAmount = UnityEngine.Mathf.Clamp(serializable.MinAmount, 0, 100000000);
			MaxAmount = UnityEngine.Mathf.Clamp(serializable.MaxAmount, 0, 100000000);
			ValueRatio = UnityEngine.Mathf.Clamp(serializable.ValueRatio, 0.001f, 1000f);
			Factions = RequiredFactions.Create(serializable.Factions, database);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ILootContentFactory<T> factory)
        {
            return factory.Create(this);
        }

		public int MinAmount { get; private set; }
		public int MaxAmount { get; private set; }
		public float ValueRatio { get; private set; }
		public RequiredFactions Factions { get; private set; }
    }
    public partial class LootContent_RandomItems : LootContent
    {
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

  		public LootContent_RandomItems(LootContentSerializable serializable, Database database)
            : base(serializable, database)
        {
			MinAmount = UnityEngine.Mathf.Clamp(serializable.MinAmount, 0, 100000000);
			MaxAmount = UnityEngine.Mathf.Clamp(serializable.MaxAmount, 0, 100000000);
			Items = new ImmutableCollection<LootItem>(serializable.Items?.Select(item => LootItem.Create(item, database)));

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ILootContentFactory<T> factory)
        {
            return factory.Create(this);
        }

		public int MinAmount { get; private set; }
		public int MaxAmount { get; private set; }
		public ImmutableCollection<LootItem> Items { get; private set; }
    }
    public partial class LootContent_AllItems : LootContent
    {
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

  		public LootContent_AllItems(LootContentSerializable serializable, Database database)
            : base(serializable, database)
        {
			Items = new ImmutableCollection<LootItem>(serializable.Items?.Select(item => LootItem.Create(item, database)));

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ILootContentFactory<T> factory)
        {
            return factory.Create(this);
        }

		public ImmutableCollection<LootItem> Items { get; private set; }
    }
    public partial class LootContent_ItemsWithChance : LootContent
    {
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

  		public LootContent_ItemsWithChance(LootContentSerializable serializable, Database database)
            : base(serializable, database)
        {
			Items = new ImmutableCollection<LootItem>(serializable.Items?.Select(item => LootItem.Create(item, database)));

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ILootContentFactory<T> factory)
        {
            return factory.Create(this);
        }

		public ImmutableCollection<LootItem> Items { get; private set; }
    }
    public partial class LootContent_QuestItem : LootContent
    {
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

  		public LootContent_QuestItem(LootContentSerializable serializable, Database database)
            : base(serializable, database)
        {
			QuestItem = database.GetQuestItem(new ItemId<QuestItem>(serializable.ItemId));
			MinAmount = UnityEngine.Mathf.Clamp(serializable.MinAmount, 0, 100000000);
			MaxAmount = UnityEngine.Mathf.Clamp(serializable.MaxAmount, 0, 100000000);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ILootContentFactory<T> factory)
        {
            return factory.Create(this);
        }

		public QuestItem QuestItem { get; private set; }
		public int MinAmount { get; private set; }
		public int MaxAmount { get; private set; }
    }
    public partial class LootContent_Ship : LootContent
    {
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

  		public LootContent_Ship(LootContentSerializable serializable, Database database)
            : base(serializable, database)
        {
			ShipBuild = database.GetShipBuild(new ItemId<ShipBuild>(serializable.ItemId));

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ILootContentFactory<T> factory)
        {
            return factory.Create(this);
        }

		public ShipBuild ShipBuild { get; private set; }
    }
    public partial class LootContent_EmptyShip : LootContent
    {
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

  		public LootContent_EmptyShip(LootContentSerializable serializable, Database database)
            : base(serializable, database)
        {
			Ship = database.GetShip(new ItemId<Ship>(serializable.ItemId));

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ILootContentFactory<T> factory)
        {
            return factory.Create(this);
        }

		public Ship Ship { get; private set; }
    }
    public partial class LootContent_Component : LootContent
    {
		partial void OnDataDeserialized(LootContentSerializable serializable, Database database);

  		public LootContent_Component(LootContentSerializable serializable, Database database)
            : base(serializable, database)
        {
			Component = database.GetComponent(new ItemId<Component>(serializable.ItemId));
			MinAmount = UnityEngine.Mathf.Clamp(serializable.MinAmount, 0, 100000000);
			MaxAmount = UnityEngine.Mathf.Clamp(serializable.MaxAmount, 0, 100000000);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ILootContentFactory<T> factory)
        {
            return factory.Create(this);
        }

		public Component Component { get; private set; }
		public int MinAmount { get; private set; }
		public int MaxAmount { get; private set; }
    }

}

