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
	public abstract partial class NodeData
	{
		partial void OnDataDeserialized(NodeSerializable serializable, Database database);

		public static NodeData Create(NodeSerializable serializable, Database database)
		{
			switch (serializable.Type)
		    {
				case NodeType.ShowDialog:
					return new NodeData_ShowDialog(serializable, database);
				case NodeType.Switch:
					return new NodeData_Switch(serializable, database);
				case NodeType.Condition:
					return new NodeData_Condition(serializable, database);
				case NodeType.Random:
					return new NodeData_Random(serializable, database);
				case NodeType.Retreat:
					return new NodeData_Retreat(serializable, database);
				case NodeType.DestroyOccupants:
					return new NodeData_DestroyOccupants(serializable, database);
				case NodeType.SuppressOccupants:
					return new NodeData_SuppressOccupants(serializable, database);
				case NodeType.ReceiveItem:
					return new NodeData_ReceiveItem(serializable, database);
				case NodeType.RemoveItem:
					return new NodeData_RemoveItem(serializable, database);
				case NodeType.Trade:
					return new NodeData_Trade(serializable, database);
				case NodeType.StartQuest:
					return new NodeData_StartQuest(serializable, database);
				case NodeType.ChangeFactionRelations:
					return new NodeData_ChangeFactionRelations(serializable, database);
				case NodeType.SetFactionRelations:
					return new NodeData_SetFactionRelations(serializable, database);
				case NodeType.ChangeCharacterRelations:
					return new NodeData_ChangeCharacterRelations(serializable, database);
				case NodeType.SetCharacterRelations:
					return new NodeData_SetCharacterRelations(serializable, database);
				case NodeType.OpenShipyard:
					return new NodeData_OpenShipyard(serializable, database);
				case NodeType.AttackFleet:
					return new NodeData_AttackFleet(serializable, database);
				case NodeType.AttackOccupants:
					return new NodeData_AttackOccupants(serializable, database);
				default:
                    throw new DatabaseException("Node: Invalid content type - " + serializable.Type);
			}
		}

		public abstract T Create<T>(INodeDataFactory<T> factory);

		protected NodeData(NodeSerializable serializable, Database database)
		{
			Id = UnityEngine.Mathf.Clamp(serializable.Id, 1, 1000);
			Type = serializable.Type;

			OnDataDeserialized(serializable, database);
		}

		public readonly int Id;
		public readonly NodeType Type;
	}

	public interface INodeDataFactory<T>
    {
	    T Create(NodeData_ShowDialog content);
	    T Create(NodeData_Switch content);
	    T Create(NodeData_Condition content);
	    T Create(NodeData_Random content);
	    T Create(NodeData_Retreat content);
	    T Create(NodeData_DestroyOccupants content);
	    T Create(NodeData_SuppressOccupants content);
	    T Create(NodeData_ReceiveItem content);
	    T Create(NodeData_RemoveItem content);
	    T Create(NodeData_Trade content);
	    T Create(NodeData_StartQuest content);
	    T Create(NodeData_ChangeFactionRelations content);
	    T Create(NodeData_SetFactionRelations content);
	    T Create(NodeData_ChangeCharacterRelations content);
	    T Create(NodeData_SetCharacterRelations content);
	    T Create(NodeData_OpenShipyard content);
	    T Create(NodeData_AttackFleet content);
	    T Create(NodeData_AttackOccupants content);
    }

    public partial class NodeData_ShowDialog : NodeData
    {
		partial void OnDataDeserialized(NodeSerializable serializable, Database database);

  		public NodeData_ShowDialog(NodeSerializable serializable, Database database)
            : base(serializable, database)
        {
			RequiredView = serializable.RequiredView;
			Message = serializable.Message;
			Enemy = database.GetFleet(new ItemId<FleetData>(serializable.Enemy));
			Loot = database.GetLoot(new ItemId<LootData>(serializable.Loot));
			Character = database.GetCharacter(new ItemId<CharacterData>(serializable.Character));
			Actions = serializable.Actions?.Select(item => NodeActionData.Create(item, database)).ToList().AsReadOnly();

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(INodeDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly RequiredViewMode RequiredView;
		public readonly string Message;
		public readonly FleetData Enemy;
		public readonly LootData Loot;
		public readonly CharacterData Character;
		public readonly System.Collections.ObjectModel.ReadOnlyCollection<NodeActionData> Actions;
    }
    public partial class NodeData_Switch : NodeData
    {
		partial void OnDataDeserialized(NodeSerializable serializable, Database database);

  		public NodeData_Switch(NodeSerializable serializable, Database database)
            : base(serializable, database)
        {
			Message = serializable.Message;
			DefaultTransition = UnityEngine.Mathf.Clamp(serializable.DefaultTransition, 0, 1000);
			Transitions = serializable.Transitions?.Select(item => NodeTransitionData.Create(item, database)).ToList().AsReadOnly();

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(INodeDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly string Message;
		public readonly int DefaultTransition;
		public readonly System.Collections.ObjectModel.ReadOnlyCollection<NodeTransitionData> Transitions;
    }
    public partial class NodeData_Condition : NodeData
    {
		partial void OnDataDeserialized(NodeSerializable serializable, Database database);

  		public NodeData_Condition(NodeSerializable serializable, Database database)
            : base(serializable, database)
        {
			Message = serializable.Message;
			Transitions = serializable.Transitions?.Select(item => NodeTransitionData.Create(item, database)).ToList().AsReadOnly();

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(INodeDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly string Message;
		public readonly System.Collections.ObjectModel.ReadOnlyCollection<NodeTransitionData> Transitions;
    }
    public partial class NodeData_Random : NodeData
    {
		partial void OnDataDeserialized(NodeSerializable serializable, Database database);

  		public NodeData_Random(NodeSerializable serializable, Database database)
            : base(serializable, database)
        {
			Message = serializable.Message;
			DefaultTransition = UnityEngine.Mathf.Clamp(serializable.DefaultTransition, 0, 1000);
			Transitions = serializable.Transitions?.Select(item => NodeTransitionData.Create(item, database)).ToList().AsReadOnly();

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(INodeDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly string Message;
		public readonly int DefaultTransition;
		public readonly System.Collections.ObjectModel.ReadOnlyCollection<NodeTransitionData> Transitions;
    }
    public partial class NodeData_Retreat : NodeData
    {
		partial void OnDataDeserialized(NodeSerializable serializable, Database database);

  		public NodeData_Retreat(NodeSerializable serializable, Database database)
            : base(serializable, database)
        {
			Transition = UnityEngine.Mathf.Clamp(serializable.DefaultTransition, 1, 1000);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(INodeDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly int Transition;
    }
    public partial class NodeData_DestroyOccupants : NodeData
    {
		partial void OnDataDeserialized(NodeSerializable serializable, Database database);

  		public NodeData_DestroyOccupants(NodeSerializable serializable, Database database)
            : base(serializable, database)
        {
			Transition = UnityEngine.Mathf.Clamp(serializable.DefaultTransition, 1, 1000);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(INodeDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly int Transition;
    }
    public partial class NodeData_SuppressOccupants : NodeData
    {
		partial void OnDataDeserialized(NodeSerializable serializable, Database database);

  		public NodeData_SuppressOccupants(NodeSerializable serializable, Database database)
            : base(serializable, database)
        {
			Transition = UnityEngine.Mathf.Clamp(serializable.DefaultTransition, 1, 1000);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(INodeDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly int Transition;
    }
    public partial class NodeData_ReceiveItem : NodeData
    {
		partial void OnDataDeserialized(NodeSerializable serializable, Database database);

  		public NodeData_ReceiveItem(NodeSerializable serializable, Database database)
            : base(serializable, database)
        {
			Transition = UnityEngine.Mathf.Clamp(serializable.DefaultTransition, 1, 1000);
			Loot = database.GetLoot(new ItemId<LootData>(serializable.Loot));

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(INodeDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly int Transition;
		public readonly LootData Loot;
    }
    public partial class NodeData_RemoveItem : NodeData
    {
		partial void OnDataDeserialized(NodeSerializable serializable, Database database);

  		public NodeData_RemoveItem(NodeSerializable serializable, Database database)
            : base(serializable, database)
        {
			Transition = UnityEngine.Mathf.Clamp(serializable.DefaultTransition, 1, 1000);
			Loot = database.GetLoot(new ItemId<LootData>(serializable.Loot));

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(INodeDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly int Transition;
		public readonly LootData Loot;
    }
    public partial class NodeData_Trade : NodeData
    {
		partial void OnDataDeserialized(NodeSerializable serializable, Database database);

  		public NodeData_Trade(NodeSerializable serializable, Database database)
            : base(serializable, database)
        {
			Transition = UnityEngine.Mathf.Clamp(serializable.DefaultTransition, 1, 1000);
			Loot = database.GetLoot(new ItemId<LootData>(serializable.Loot));

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(INodeDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly int Transition;
		public readonly LootData Loot;
    }
    public partial class NodeData_StartQuest : NodeData
    {
		partial void OnDataDeserialized(NodeSerializable serializable, Database database);

  		public NodeData_StartQuest(NodeSerializable serializable, Database database)
            : base(serializable, database)
        {
			Transition = UnityEngine.Mathf.Clamp(serializable.DefaultTransition, 1, 1000);
			Quest = database.GetQuest(new ItemId<QuestData>(serializable.Quest));

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(INodeDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly int Transition;
		public readonly QuestData Quest;
    }
    public partial class NodeData_ChangeFactionRelations : NodeData
    {
		partial void OnDataDeserialized(NodeSerializable serializable, Database database);

  		public NodeData_ChangeFactionRelations(NodeSerializable serializable, Database database)
            : base(serializable, database)
        {
			Transition = UnityEngine.Mathf.Clamp(serializable.DefaultTransition, 1, 1000);
			Value = UnityEngine.Mathf.Clamp(serializable.Value, -100, 100);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(INodeDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly int Transition;
		public readonly int Value;
    }
    public partial class NodeData_SetFactionRelations : NodeData
    {
		partial void OnDataDeserialized(NodeSerializable serializable, Database database);

  		public NodeData_SetFactionRelations(NodeSerializable serializable, Database database)
            : base(serializable, database)
        {
			Transition = UnityEngine.Mathf.Clamp(serializable.DefaultTransition, 1, 1000);
			Value = UnityEngine.Mathf.Clamp(serializable.Value, -100, 100);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(INodeDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly int Transition;
		public readonly int Value;
    }
    public partial class NodeData_ChangeCharacterRelations : NodeData
    {
		partial void OnDataDeserialized(NodeSerializable serializable, Database database);

  		public NodeData_ChangeCharacterRelations(NodeSerializable serializable, Database database)
            : base(serializable, database)
        {
			Transition = UnityEngine.Mathf.Clamp(serializable.DefaultTransition, 1, 1000);
			Value = UnityEngine.Mathf.Clamp(serializable.Value, -100, 100);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(INodeDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly int Transition;
		public readonly int Value;
    }
    public partial class NodeData_SetCharacterRelations : NodeData
    {
		partial void OnDataDeserialized(NodeSerializable serializable, Database database);

  		public NodeData_SetCharacterRelations(NodeSerializable serializable, Database database)
            : base(serializable, database)
        {
			Transition = UnityEngine.Mathf.Clamp(serializable.DefaultTransition, 1, 1000);
			Value = UnityEngine.Mathf.Clamp(serializable.Value, -100, 100);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(INodeDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly int Transition;
		public readonly int Value;
    }
    public partial class NodeData_OpenShipyard : NodeData
    {
		partial void OnDataDeserialized(NodeSerializable serializable, Database database);

  		public NodeData_OpenShipyard(NodeSerializable serializable, Database database)
            : base(serializable, database)
        {
			Transition = UnityEngine.Mathf.Clamp(serializable.DefaultTransition, 1, 1000);
			Faction = database.GetFaction(new ItemId<FactionData>(serializable.Faction));
			Level = UnityEngine.Mathf.Clamp(serializable.Value, 0, 1000);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(INodeDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly int Transition;
		public readonly FactionData Faction;
		public readonly int Level;
    }
    public partial class NodeData_AttackFleet : NodeData
    {
		partial void OnDataDeserialized(NodeSerializable serializable, Database database);

  		public NodeData_AttackFleet(NodeSerializable serializable, Database database)
            : base(serializable, database)
        {
			VictoryTransition = UnityEngine.Mathf.Clamp(serializable.DefaultTransition, 1, 1000);
			FailureTransition = UnityEngine.Mathf.Clamp(serializable.FailureTransition, 1, 1000);
			Enemy = database.GetFleet(new ItemId<FleetData>(serializable.Enemy));
			Loot = database.GetLoot(new ItemId<LootData>(serializable.Loot));

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(INodeDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly int VictoryTransition;
		public readonly int FailureTransition;
		public readonly FleetData Enemy;
		public readonly LootData Loot;
    }
    public partial class NodeData_AttackOccupants : NodeData
    {
		partial void OnDataDeserialized(NodeSerializable serializable, Database database);

  		public NodeData_AttackOccupants(NodeSerializable serializable, Database database)
            : base(serializable, database)
        {
			VictoryTransition = UnityEngine.Mathf.Clamp(serializable.DefaultTransition, 1, 1000);
			FailureTransition = UnityEngine.Mathf.Clamp(serializable.FailureTransition, 1, 1000);

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(INodeDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly int VictoryTransition;
		public readonly int FailureTransition;
    }

}

