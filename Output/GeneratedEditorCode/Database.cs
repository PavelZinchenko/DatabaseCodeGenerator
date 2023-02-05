//-------------------------------------------------------------------------------
//                                                                               
//    This code was automatically generated.                                     
//    Changes to this file may cause incorrect behavior and will be lost if      
//    the code is regenerated.                                                   
//                                                                               
//-------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Collections.Generic;
using EditorDatabase.DataModel;
using EditorDatabase.Storage;
using EditorDatabase.Model;
using EditorDatabase.Enums;

namespace EditorDatabase
{
    public partial class Database
    {
		public Database(IDataStorage storage)
		{
            _serializer = new JsonSerializer();
            _content = new DatabaseContent(storage, _serializer);
		}

		public void Save(IDataStorage storage)
		{
            foreach (var item in _ammunitionObsoleteMap) item.Value.Save(_content.GetAmmunitionObsolete(item.Key));
            foreach (var item in _componentMap) item.Value.Save(_content.GetComponent(item.Key));
            foreach (var item in _componentModMap) item.Value.Save(_content.GetComponentMod(item.Key));
            foreach (var item in _componentStatsMap) item.Value.Save(_content.GetComponentStats(item.Key));
            foreach (var item in _deviceMap) item.Value.Save(_content.GetDevice(item.Key));
            foreach (var item in _droneBayMap) item.Value.Save(_content.GetDroneBay(item.Key));
            foreach (var item in _factionMap) item.Value.Save(_content.GetFaction(item.Key));
            foreach (var item in _satelliteMap) item.Value.Save(_content.GetSatellite(item.Key));
            foreach (var item in _satelliteBuildMap) item.Value.Save(_content.GetSatelliteBuild(item.Key));
            foreach (var item in _shipMap) item.Value.Save(_content.GetShip(item.Key));
            foreach (var item in _shipBuildMap) item.Value.Save(_content.GetShipBuild(item.Key));
            foreach (var item in _skillMap) item.Value.Save(_content.GetSkill(item.Key));
            foreach (var item in _technologyMap) item.Value.Save(_content.GetTechnology(item.Key));
            foreach (var item in _characterMap) item.Value.Save(_content.GetCharacter(item.Key));
            foreach (var item in _fleetMap) item.Value.Save(_content.GetFleet(item.Key));
            foreach (var item in _lootMap) item.Value.Save(_content.GetLoot(item.Key));
            foreach (var item in _questMap) item.Value.Save(_content.GetQuest(item.Key));
            foreach (var item in _questItemMap) item.Value.Save(_content.GetQuestItem(item.Key));
            foreach (var item in _ammunitionMap) item.Value.Save(_content.GetAmmunition(item.Key));
            foreach (var item in _bulletPrefabMap) item.Value.Save(_content.GetBulletPrefab(item.Key));
            foreach (var item in _visualEffectMap) item.Value.Save(_content.GetVisualEffect(item.Key));
            foreach (var item in _weaponMap) item.Value.Save(_content.GetWeapon(item.Key));
			_databaseSettings?.Save(_content.DatabaseSettings);
			_explorationSettings?.Save(_content.ExplorationSettings);
			_frontierSettings?.Save(_content.FrontierSettings);
			_galaxySettings?.Save(_content.GalaxySettings);
			_shipSettings?.Save(_content.ShipSettings);
		
			_content.Save(storage, _serializer);
		}

		public IEnumerable<IItemId> GetItemList(Type type)
        {
            if (type == typeof(AmmunitionObsolete)) return _content.AmmunitionObsoleteList.Select(item => new ItemId<AmmunitionObsolete>(item));
            if (type == typeof(Component)) return _content.ComponentList.Select(item => new ItemId<Component>(item));
            if (type == typeof(ComponentMod)) return _content.ComponentModList.Select(item => new ItemId<ComponentMod>(item));
            if (type == typeof(ComponentStats)) return _content.ComponentStatsList.Select(item => new ItemId<ComponentStats>(item));
            if (type == typeof(Device)) return _content.DeviceList.Select(item => new ItemId<Device>(item));
            if (type == typeof(DroneBay)) return _content.DroneBayList.Select(item => new ItemId<DroneBay>(item));
            if (type == typeof(Faction)) return _content.FactionList.Select(item => new ItemId<Faction>(item));
            if (type == typeof(Satellite)) return _content.SatelliteList.Select(item => new ItemId<Satellite>(item));
            if (type == typeof(SatelliteBuild)) return _content.SatelliteBuildList.Select(item => new ItemId<SatelliteBuild>(item));
            if (type == typeof(Ship)) return _content.ShipList.Select(item => new ItemId<Ship>(item));
            if (type == typeof(ShipBuild)) return _content.ShipBuildList.Select(item => new ItemId<ShipBuild>(item));
            if (type == typeof(Skill)) return _content.SkillList.Select(item => new ItemId<Skill>(item));
            if (type == typeof(Technology)) return _content.TechnologyList.Select(item => new ItemId<Technology>(item));
            if (type == typeof(Character)) return _content.CharacterList.Select(item => new ItemId<Character>(item));
            if (type == typeof(Fleet)) return _content.FleetList.Select(item => new ItemId<Fleet>(item));
            if (type == typeof(LootModel)) return _content.LootList.Select(item => new ItemId<LootModel>(item));
            if (type == typeof(QuestModel)) return _content.QuestList.Select(item => new ItemId<QuestModel>(item));
            if (type == typeof(QuestItem)) return _content.QuestItemList.Select(item => new ItemId<QuestItem>(item));
            if (type == typeof(Ammunition)) return _content.AmmunitionList.Select(item => new ItemId<Ammunition>(item));
            if (type == typeof(BulletPrefab)) return _content.BulletPrefabList.Select(item => new ItemId<BulletPrefab>(item));
            if (type == typeof(VisualEffect)) return _content.VisualEffectList.Select(item => new ItemId<VisualEffect>(item));
            if (type == typeof(Weapon)) return _content.WeaponList.Select(item => new ItemId<Weapon>(item));
            return Enumerable.Empty<IItemId>();
        }

        public IEnumerable<object> GetAllItems()
        {
            foreach (var item in _content.AmmunitionObsoleteList)
                yield return GetAmmunitionObsolete(item.Id);
            foreach (var item in _content.ComponentList)
                yield return GetComponent(item.Id);
            foreach (var item in _content.ComponentModList)
                yield return GetComponentMod(item.Id);
            foreach (var item in _content.ComponentStatsList)
                yield return GetComponentStats(item.Id);
            foreach (var item in _content.DeviceList)
                yield return GetDevice(item.Id);
            foreach (var item in _content.DroneBayList)
                yield return GetDroneBay(item.Id);
            foreach (var item in _content.FactionList)
                yield return GetFaction(item.Id);
            foreach (var item in _content.SatelliteList)
                yield return GetSatellite(item.Id);
            foreach (var item in _content.SatelliteBuildList)
                yield return GetSatelliteBuild(item.Id);
            foreach (var item in _content.ShipList)
                yield return GetShip(item.Id);
            foreach (var item in _content.ShipBuildList)
                yield return GetShipBuild(item.Id);
            foreach (var item in _content.SkillList)
                yield return GetSkill(item.Id);
            foreach (var item in _content.TechnologyList)
                yield return GetTechnology(item.Id);
            foreach (var item in _content.CharacterList)
                yield return GetCharacter(item.Id);
            foreach (var item in _content.FleetList)
                yield return GetFleet(item.Id);
            foreach (var item in _content.LootList)
                yield return GetLoot(item.Id);
            foreach (var item in _content.QuestList)
                yield return GetQuest(item.Id);
            foreach (var item in _content.QuestItemList)
                yield return GetQuestItem(item.Id);
            foreach (var item in _content.AmmunitionList)
                yield return GetAmmunition(item.Id);
            foreach (var item in _content.BulletPrefabList)
                yield return GetBulletPrefab(item.Id);
            foreach (var item in _content.VisualEffectList)
                yield return GetVisualEffect(item.Id);
            foreach (var item in _content.WeaponList)
                yield return GetWeapon(item.Id);
            if (_content.DatabaseSettings != null)
				yield return DatabaseSettings;
            if (_content.ExplorationSettings != null)
				yield return ExplorationSettings;
            if (_content.FrontierSettings != null)
				yield return FrontierSettings;
            if (_content.GalaxySettings != null)
				yield return GalaxySettings;
            if (_content.ShipSettings != null)
				yield return ShipSettings;
        }

        public IItemId GetItemId(Type type, int id)
        {
            if (type == typeof(AmmunitionObsolete)) return GetAmmunitionObsoleteId(id);
            if (type == typeof(Component)) return GetComponentId(id);
            if (type == typeof(ComponentMod)) return GetComponentModId(id);
            if (type == typeof(ComponentStats)) return GetComponentStatsId(id);
            if (type == typeof(Device)) return GetDeviceId(id);
            if (type == typeof(DroneBay)) return GetDroneBayId(id);
            if (type == typeof(Faction)) return GetFactionId(id);
            if (type == typeof(Satellite)) return GetSatelliteId(id);
            if (type == typeof(SatelliteBuild)) return GetSatelliteBuildId(id);
            if (type == typeof(Ship)) return GetShipId(id);
            if (type == typeof(ShipBuild)) return GetShipBuildId(id);
            if (type == typeof(Skill)) return GetSkillId(id);
            if (type == typeof(Technology)) return GetTechnologyId(id);
            if (type == typeof(Character)) return GetCharacterId(id);
            if (type == typeof(Fleet)) return GetFleetId(id);
            if (type == typeof(LootModel)) return GetLootId(id);
            if (type == typeof(QuestModel)) return GetQuestId(id);
            if (type == typeof(QuestItem)) return GetQuestItemId(id);
            if (type == typeof(Ammunition)) return GetAmmunitionId(id);
            if (type == typeof(BulletPrefab)) return GetBulletPrefabId(id);
            if (type == typeof(VisualEffect)) return GetVisualEffectId(id);
            if (type == typeof(Weapon)) return GetWeaponId(id);
            return ItemId<Type>.Empty;
        }

        public object GetItem(ItemType type, int id)
        {
            switch (type)
            {
				case ItemType.AmmunitionObsolete: return GetAmmunitionObsolete(id);
				case ItemType.Component: return GetComponent(id);
				case ItemType.ComponentMod: return GetComponentMod(id);
				case ItemType.ComponentStats: return GetComponentStats(id);
				case ItemType.Device: return GetDevice(id);
				case ItemType.DroneBay: return GetDroneBay(id);
				case ItemType.Faction: return GetFaction(id);
				case ItemType.Satellite: return GetSatellite(id);
				case ItemType.SatelliteBuild: return GetSatelliteBuild(id);
				case ItemType.Ship: return GetShip(id);
				case ItemType.ShipBuild: return GetShipBuild(id);
				case ItemType.Skill: return GetSkill(id);
				case ItemType.Technology: return GetTechnology(id);
				case ItemType.Character: return GetCharacter(id);
				case ItemType.Fleet: return GetFleet(id);
				case ItemType.Loot: return GetLoot(id);
				case ItemType.Quest: return GetQuest(id);
				case ItemType.QuestItem: return GetQuestItem(id);
				case ItemType.Ammunition: return GetAmmunition(id);
				case ItemType.BulletPrefab: return GetBulletPrefab(id);
				case ItemType.VisualEffect: return GetVisualEffect(id);
				case ItemType.Weapon: return GetWeapon(id);
				case ItemType.DatabaseSettings: return DatabaseSettings;
				case ItemType.ExplorationSettings: return ExplorationSettings;
				case ItemType.FrontierSettings: return FrontierSettings;
				case ItemType.GalaxySettings: return GalaxySettings;
				case ItemType.ShipSettings: return ShipSettings;
                default: return null;
            }
        }


		public DatabaseSettings DatabaseSettings => _databaseSettings ?? (_databaseSettings = new DatabaseSettings(_content.DatabaseSettings, this));
		public ExplorationSettings ExplorationSettings => _explorationSettings ?? (_explorationSettings = new ExplorationSettings(_content.ExplorationSettings, this));
		public FrontierSettings FrontierSettings => _frontierSettings ?? (_frontierSettings = new FrontierSettings(_content.FrontierSettings, this));
		public GalaxySettings GalaxySettings => _galaxySettings ?? (_galaxySettings = new GalaxySettings(_content.GalaxySettings, this));
		public ShipSettings ShipSettings => _shipSettings ?? (_shipSettings = new ShipSettings(_content.ShipSettings, this));

		public ItemId<AmmunitionObsolete> GetAmmunitionObsoleteId(int id) { return new ItemId<AmmunitionObsolete>(_content.GetAmmunitionObsolete(id)); }
        public AmmunitionObsolete GetAmmunitionObsolete(int id)
        {
            if (!_ammunitionObsoleteMap.TryGetValue(id, out var item))
            {
                var serializable = _content.GetAmmunitionObsolete(id);
                item = new AmmunitionObsolete(serializable, this);
                _ammunitionObsoleteMap.Add(id, item);
            }
            return item;
        }

		public ItemId<Component> GetComponentId(int id) { return new ItemId<Component>(_content.GetComponent(id)); }
        public Component GetComponent(int id)
        {
            if (!_componentMap.TryGetValue(id, out var item))
            {
                var serializable = _content.GetComponent(id);
                item = new Component(serializable, this);
                _componentMap.Add(id, item);
            }
            return item;
        }

		public ItemId<ComponentMod> GetComponentModId(int id) { return new ItemId<ComponentMod>(_content.GetComponentMod(id)); }
        public ComponentMod GetComponentMod(int id)
        {
            if (!_componentModMap.TryGetValue(id, out var item))
            {
                var serializable = _content.GetComponentMod(id);
                item = new ComponentMod(serializable, this);
                _componentModMap.Add(id, item);
            }
            return item;
        }

		public ItemId<ComponentStats> GetComponentStatsId(int id) { return new ItemId<ComponentStats>(_content.GetComponentStats(id)); }
        public ComponentStats GetComponentStats(int id)
        {
            if (!_componentStatsMap.TryGetValue(id, out var item))
            {
                var serializable = _content.GetComponentStats(id);
                item = new ComponentStats(serializable, this);
                _componentStatsMap.Add(id, item);
            }
            return item;
        }

		public ItemId<Device> GetDeviceId(int id) { return new ItemId<Device>(_content.GetDevice(id)); }
        public Device GetDevice(int id)
        {
            if (!_deviceMap.TryGetValue(id, out var item))
            {
                var serializable = _content.GetDevice(id);
                item = new Device(serializable, this);
                _deviceMap.Add(id, item);
            }
            return item;
        }

		public ItemId<DroneBay> GetDroneBayId(int id) { return new ItemId<DroneBay>(_content.GetDroneBay(id)); }
        public DroneBay GetDroneBay(int id)
        {
            if (!_droneBayMap.TryGetValue(id, out var item))
            {
                var serializable = _content.GetDroneBay(id);
                item = new DroneBay(serializable, this);
                _droneBayMap.Add(id, item);
            }
            return item;
        }

		public ItemId<Faction> GetFactionId(int id) { return new ItemId<Faction>(_content.GetFaction(id)); }
        public Faction GetFaction(int id)
        {
            if (!_factionMap.TryGetValue(id, out var item))
            {
                var serializable = _content.GetFaction(id);
                item = new Faction(serializable, this);
                _factionMap.Add(id, item);
            }
            return item;
        }

		public ItemId<Satellite> GetSatelliteId(int id) { return new ItemId<Satellite>(_content.GetSatellite(id)); }
        public Satellite GetSatellite(int id)
        {
            if (!_satelliteMap.TryGetValue(id, out var item))
            {
                var serializable = _content.GetSatellite(id);
                item = new Satellite(serializable, this);
                _satelliteMap.Add(id, item);
            }
            return item;
        }

		public ItemId<SatelliteBuild> GetSatelliteBuildId(int id) { return new ItemId<SatelliteBuild>(_content.GetSatelliteBuild(id)); }
        public SatelliteBuild GetSatelliteBuild(int id)
        {
            if (!_satelliteBuildMap.TryGetValue(id, out var item))
            {
                var serializable = _content.GetSatelliteBuild(id);
                item = new SatelliteBuild(serializable, this);
                _satelliteBuildMap.Add(id, item);
            }
            return item;
        }

		public ItemId<Ship> GetShipId(int id) { return new ItemId<Ship>(_content.GetShip(id)); }
        public Ship GetShip(int id)
        {
            if (!_shipMap.TryGetValue(id, out var item))
            {
                var serializable = _content.GetShip(id);
                item = new Ship(serializable, this);
                _shipMap.Add(id, item);
            }
            return item;
        }

		public ItemId<ShipBuild> GetShipBuildId(int id) { return new ItemId<ShipBuild>(_content.GetShipBuild(id)); }
        public ShipBuild GetShipBuild(int id)
        {
            if (!_shipBuildMap.TryGetValue(id, out var item))
            {
                var serializable = _content.GetShipBuild(id);
                item = new ShipBuild(serializable, this);
                _shipBuildMap.Add(id, item);
            }
            return item;
        }

		public ItemId<Skill> GetSkillId(int id) { return new ItemId<Skill>(_content.GetSkill(id)); }
        public Skill GetSkill(int id)
        {
            if (!_skillMap.TryGetValue(id, out var item))
            {
                var serializable = _content.GetSkill(id);
                item = new Skill(serializable, this);
                _skillMap.Add(id, item);
            }
            return item;
        }

		public ItemId<Technology> GetTechnologyId(int id) { return new ItemId<Technology>(_content.GetTechnology(id)); }
        public Technology GetTechnology(int id)
        {
            if (!_technologyMap.TryGetValue(id, out var item))
            {
                var serializable = _content.GetTechnology(id);
                item = new Technology(serializable, this);
                _technologyMap.Add(id, item);
            }
            return item;
        }

		public ItemId<Character> GetCharacterId(int id) { return new ItemId<Character>(_content.GetCharacter(id)); }
        public Character GetCharacter(int id)
        {
            if (!_characterMap.TryGetValue(id, out var item))
            {
                var serializable = _content.GetCharacter(id);
                item = new Character(serializable, this);
                _characterMap.Add(id, item);
            }
            return item;
        }

		public ItemId<Fleet> GetFleetId(int id) { return new ItemId<Fleet>(_content.GetFleet(id)); }
        public Fleet GetFleet(int id)
        {
            if (!_fleetMap.TryGetValue(id, out var item))
            {
                var serializable = _content.GetFleet(id);
                item = new Fleet(serializable, this);
                _fleetMap.Add(id, item);
            }
            return item;
        }

		public ItemId<LootModel> GetLootId(int id) { return new ItemId<LootModel>(_content.GetLoot(id)); }
        public LootModel GetLoot(int id)
        {
            if (!_lootMap.TryGetValue(id, out var item))
            {
                var serializable = _content.GetLoot(id);
                item = new LootModel(serializable, this);
                _lootMap.Add(id, item);
            }
            return item;
        }

		public ItemId<QuestModel> GetQuestId(int id) { return new ItemId<QuestModel>(_content.GetQuest(id)); }
        public QuestModel GetQuest(int id)
        {
            if (!_questMap.TryGetValue(id, out var item))
            {
                var serializable = _content.GetQuest(id);
                item = new QuestModel(serializable, this);
                _questMap.Add(id, item);
            }
            return item;
        }

		public ItemId<QuestItem> GetQuestItemId(int id) { return new ItemId<QuestItem>(_content.GetQuestItem(id)); }
        public QuestItem GetQuestItem(int id)
        {
            if (!_questItemMap.TryGetValue(id, out var item))
            {
                var serializable = _content.GetQuestItem(id);
                item = new QuestItem(serializable, this);
                _questItemMap.Add(id, item);
            }
            return item;
        }

		public ItemId<Ammunition> GetAmmunitionId(int id) { return new ItemId<Ammunition>(_content.GetAmmunition(id)); }
        public Ammunition GetAmmunition(int id)
        {
            if (!_ammunitionMap.TryGetValue(id, out var item))
            {
                var serializable = _content.GetAmmunition(id);
                item = new Ammunition(serializable, this);
                _ammunitionMap.Add(id, item);
            }
            return item;
        }

		public ItemId<BulletPrefab> GetBulletPrefabId(int id) { return new ItemId<BulletPrefab>(_content.GetBulletPrefab(id)); }
        public BulletPrefab GetBulletPrefab(int id)
        {
            if (!_bulletPrefabMap.TryGetValue(id, out var item))
            {
                var serializable = _content.GetBulletPrefab(id);
                item = new BulletPrefab(serializable, this);
                _bulletPrefabMap.Add(id, item);
            }
            return item;
        }

		public ItemId<VisualEffect> GetVisualEffectId(int id) { return new ItemId<VisualEffect>(_content.GetVisualEffect(id)); }
        public VisualEffect GetVisualEffect(int id)
        {
            if (!_visualEffectMap.TryGetValue(id, out var item))
            {
                var serializable = _content.GetVisualEffect(id);
                item = new VisualEffect(serializable, this);
                _visualEffectMap.Add(id, item);
            }
            return item;
        }

		public ItemId<Weapon> GetWeaponId(int id) { return new ItemId<Weapon>(_content.GetWeapon(id)); }
        public Weapon GetWeapon(int id)
        {
            if (!_weaponMap.TryGetValue(id, out var item))
            {
                var serializable = _content.GetWeapon(id);
                item = new Weapon(serializable, this);
                _weaponMap.Add(id, item);
            }
            return item;
        }


        public ImageData GetImage(string name) { return _content.GetImage(name); }

        private void Clear()
        {
			_ammunitionObsoleteMap.Clear();
			_componentMap.Clear();
			_componentModMap.Clear();
			_componentStatsMap.Clear();
			_deviceMap.Clear();
			_droneBayMap.Clear();
			_factionMap.Clear();
			_satelliteMap.Clear();
			_satelliteBuildMap.Clear();
			_shipMap.Clear();
			_shipBuildMap.Clear();
			_skillMap.Clear();
			_technologyMap.Clear();
			_characterMap.Clear();
			_fleetMap.Clear();
			_lootMap.Clear();
			_questMap.Clear();
			_questItemMap.Clear();
			_ammunitionMap.Clear();
			_bulletPrefabMap.Clear();
			_visualEffectMap.Clear();
			_weaponMap.Clear();

			_databaseSettings = null;
			_explorationSettings = null;
			_frontierSettings = null;
			_galaxySettings = null;
			_shipSettings = null;
        }

		private readonly Dictionary<int, AmmunitionObsolete> _ammunitionObsoleteMap = new Dictionary<int, AmmunitionObsolete>();
		private readonly Dictionary<int, Component> _componentMap = new Dictionary<int, Component>();
		private readonly Dictionary<int, ComponentMod> _componentModMap = new Dictionary<int, ComponentMod>();
		private readonly Dictionary<int, ComponentStats> _componentStatsMap = new Dictionary<int, ComponentStats>();
		private readonly Dictionary<int, Device> _deviceMap = new Dictionary<int, Device>();
		private readonly Dictionary<int, DroneBay> _droneBayMap = new Dictionary<int, DroneBay>();
		private readonly Dictionary<int, Faction> _factionMap = new Dictionary<int, Faction>();
		private readonly Dictionary<int, Satellite> _satelliteMap = new Dictionary<int, Satellite>();
		private readonly Dictionary<int, SatelliteBuild> _satelliteBuildMap = new Dictionary<int, SatelliteBuild>();
		private readonly Dictionary<int, Ship> _shipMap = new Dictionary<int, Ship>();
		private readonly Dictionary<int, ShipBuild> _shipBuildMap = new Dictionary<int, ShipBuild>();
		private readonly Dictionary<int, Skill> _skillMap = new Dictionary<int, Skill>();
		private readonly Dictionary<int, Technology> _technologyMap = new Dictionary<int, Technology>();
		private readonly Dictionary<int, Character> _characterMap = new Dictionary<int, Character>();
		private readonly Dictionary<int, Fleet> _fleetMap = new Dictionary<int, Fleet>();
		private readonly Dictionary<int, LootModel> _lootMap = new Dictionary<int, LootModel>();
		private readonly Dictionary<int, QuestModel> _questMap = new Dictionary<int, QuestModel>();
		private readonly Dictionary<int, QuestItem> _questItemMap = new Dictionary<int, QuestItem>();
		private readonly Dictionary<int, Ammunition> _ammunitionMap = new Dictionary<int, Ammunition>();
		private readonly Dictionary<int, BulletPrefab> _bulletPrefabMap = new Dictionary<int, BulletPrefab>();
		private readonly Dictionary<int, VisualEffect> _visualEffectMap = new Dictionary<int, VisualEffect>();
		private readonly Dictionary<int, Weapon> _weaponMap = new Dictionary<int, Weapon>();

		private DatabaseSettings _databaseSettings;
		private ExplorationSettings _explorationSettings;
		private FrontierSettings _frontierSettings;
		private GalaxySettings _galaxySettings;
		private ShipSettings _shipSettings;
	
        private readonly IJsonSerializer _serializer;
		private readonly DatabaseContent _content;
	}
}

