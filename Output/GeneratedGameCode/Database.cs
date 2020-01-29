//-------------------------------------------------------------------------------
//                                                                               
//    This code was automatically generated.                                     
//    Changes to this file may cause incorrect behavior and will be lost if      
//    the code is regenerated.                                                   
//                                                                               
//-------------------------------------------------------------------------------

using System.Collections.Generic;
using GameDatabase.DataModel;
using GameDatabase.Storage;
using GameDatabase.Model;

namespace GameDatabase
{
	public partial interface IDatabase
	{
		GalaxySettings GalaxySettings { get; }
		ShipSettings ShipSettings { get; }

		IEnumerable<AmmunitionObsolete> AmmunitionObsoleteList { get; }
		IEnumerable<Component> ComponentList { get; }
		IEnumerable<ComponentMod> ComponentModList { get; }
		IEnumerable<ComponentStats> ComponentStatsList { get; }
		IEnumerable<Device> DeviceList { get; }
		IEnumerable<DroneBay> DroneBayList { get; }
		IEnumerable<Faction> FactionList { get; }
		IEnumerable<Satellite> SatelliteList { get; }
		IEnumerable<SatelliteBuild> SatelliteBuildList { get; }
		IEnumerable<Ship> ShipList { get; }
		IEnumerable<ShipBuild> ShipBuildList { get; }
		IEnumerable<Skill> SkillList { get; }
		IEnumerable<Technology> TechnologyList { get; }
		IEnumerable<Character> CharacterList { get; }
		IEnumerable<Fleet> FleetList { get; }
		IEnumerable<LootModel> LootList { get; }
		IEnumerable<QuestModel> QuestList { get; }
		IEnumerable<QuestItem> QuestItemList { get; }
		IEnumerable<Ammunition> AmmunitionList { get; }
		IEnumerable<BulletPrefab> BulletPrefabList { get; }
		IEnumerable<VisualEffect> VisualEffectList { get; }
		IEnumerable<Weapon> WeaponList { get; }

		AmmunitionObsolete GetAmmunitionObsolete(ItemId<AmmunitionObsolete> id);
		Component GetComponent(ItemId<Component> id);
		ComponentMod GetComponentMod(ItemId<ComponentMod> id);
		ComponentStats GetComponentStats(ItemId<ComponentStats> id);
		Device GetDevice(ItemId<Device> id);
		DroneBay GetDroneBay(ItemId<DroneBay> id);
		Faction GetFaction(ItemId<Faction> id);
		Satellite GetSatellite(ItemId<Satellite> id);
		SatelliteBuild GetSatelliteBuild(ItemId<SatelliteBuild> id);
		Ship GetShip(ItemId<Ship> id);
		ShipBuild GetShipBuild(ItemId<ShipBuild> id);
		Skill GetSkill(ItemId<Skill> id);
		Technology GetTechnology(ItemId<Technology> id);
		Character GetCharacter(ItemId<Character> id);
		Fleet GetFleet(ItemId<Fleet> id);
		LootModel GetLoot(ItemId<LootModel> id);
		QuestModel GetQuest(ItemId<QuestModel> id);
		QuestItem GetQuestItem(ItemId<QuestItem> id);
		Ammunition GetAmmunition(ItemId<Ammunition> id);
		BulletPrefab GetBulletPrefab(ItemId<BulletPrefab> id);
		VisualEffect GetVisualEffect(ItemId<VisualEffect> id);
		Weapon GetWeapon(ItemId<Weapon> id);

        ImageData GetImage(string name);
        AudioClipData GetAudioClip(string name);
        string GetLocalization(string language);
	}

    public partial class Database : IDatabase
    {
        partial void OnDataLoaded();
        partial void OnDataInitialized();

        protected void Load(IDataStorage storage, IJsonSerializer serializer)
        {
            Clear();
            Storage = storage;
            Content = new DatabaseContent(Storage, serializer);

			OnDataLoaded();

            foreach (var item in Content.AmmunitionObsoleteList)
                GetAmmunitionObsolete(new ItemId<AmmunitionObsolete>(item.Id));
            foreach (var item in Content.ComponentList)
                GetComponent(new ItemId<Component>(item.Id));
            foreach (var item in Content.ComponentModList)
                GetComponentMod(new ItemId<ComponentMod>(item.Id));
            foreach (var item in Content.ComponentStatsList)
                GetComponentStats(new ItemId<ComponentStats>(item.Id));
            foreach (var item in Content.DeviceList)
                GetDevice(new ItemId<Device>(item.Id));
            foreach (var item in Content.DroneBayList)
                GetDroneBay(new ItemId<DroneBay>(item.Id));
            foreach (var item in Content.FactionList)
                GetFaction(new ItemId<Faction>(item.Id));
            foreach (var item in Content.SatelliteList)
                GetSatellite(new ItemId<Satellite>(item.Id));
            foreach (var item in Content.SatelliteBuildList)
                GetSatelliteBuild(new ItemId<SatelliteBuild>(item.Id));
            foreach (var item in Content.ShipList)
                GetShip(new ItemId<Ship>(item.Id));
            foreach (var item in Content.ShipBuildList)
                GetShipBuild(new ItemId<ShipBuild>(item.Id));
            foreach (var item in Content.SkillList)
                GetSkill(new ItemId<Skill>(item.Id));
            foreach (var item in Content.TechnologyList)
                GetTechnology(new ItemId<Technology>(item.Id));
            foreach (var item in Content.CharacterList)
                GetCharacter(new ItemId<Character>(item.Id));
            foreach (var item in Content.FleetList)
                GetFleet(new ItemId<Fleet>(item.Id));
            foreach (var item in Content.LootList)
                GetLoot(new ItemId<LootModel>(item.Id));
            foreach (var item in Content.QuestList)
                GetQuest(new ItemId<QuestModel>(item.Id));
            foreach (var item in Content.QuestItemList)
                GetQuestItem(new ItemId<QuestItem>(item.Id));
            foreach (var item in Content.AmmunitionList)
                GetAmmunition(new ItemId<Ammunition>(item.Id));
            foreach (var item in Content.BulletPrefabList)
                GetBulletPrefab(new ItemId<BulletPrefab>(item.Id));
            foreach (var item in Content.VisualEffectList)
                GetVisualEffect(new ItemId<VisualEffect>(item.Id));
            foreach (var item in Content.WeaponList)
                GetWeapon(new ItemId<Weapon>(item.Id));

			GalaxySettings = GalaxySettings.Create(Content.GalaxySettings, this);
			ShipSettings = ShipSettings.Create(Content.ShipSettings, this);

            OnDataInitialized();
        }

		public GalaxySettings GalaxySettings { get; private set; }
		public ShipSettings ShipSettings { get; private set; }

		public IEnumerable<AmmunitionObsolete> AmmunitionObsoleteList => _ammunitionObsoleteMap.Values;
		public IEnumerable<Component> ComponentList => _componentMap.Values;
		public IEnumerable<ComponentMod> ComponentModList => _componentModMap.Values;
		public IEnumerable<ComponentStats> ComponentStatsList => _componentStatsMap.Values;
		public IEnumerable<Device> DeviceList => _deviceMap.Values;
		public IEnumerable<DroneBay> DroneBayList => _droneBayMap.Values;
		public IEnumerable<Faction> FactionList => _factionMap.Values;
		public IEnumerable<Satellite> SatelliteList => _satelliteMap.Values;
		public IEnumerable<SatelliteBuild> SatelliteBuildList => _satelliteBuildMap.Values;
		public IEnumerable<Ship> ShipList => _shipMap.Values;
		public IEnumerable<ShipBuild> ShipBuildList => _shipBuildMap.Values;
		public IEnumerable<Skill> SkillList => _skillMap.Values;
		public IEnumerable<Technology> TechnologyList => _technologyMap.Values;
		public IEnumerable<Character> CharacterList => _characterMap.Values;
		public IEnumerable<Fleet> FleetList => _fleetMap.Values;
		public IEnumerable<LootModel> LootList => _lootMap.Values;
		public IEnumerable<QuestModel> QuestList => _questMap.Values;
		public IEnumerable<QuestItem> QuestItemList => _questItemMap.Values;
		public IEnumerable<Ammunition> AmmunitionList => _ammunitionMap.Values;
		public IEnumerable<BulletPrefab> BulletPrefabList => _bulletPrefabMap.Values;
		public IEnumerable<VisualEffect> VisualEffectList => _visualEffectMap.Values;
		public IEnumerable<Weapon> WeaponList => _weaponMap.Values;

		public AmmunitionObsolete GetAmmunitionObsolete(ItemId<AmmunitionObsolete> id) 
		{
            if (_ammunitionObsoleteMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = Content?.GetAmmunitionObsolete(id.Value);
            return serializable == null ? AmmunitionObsolete.DefaultValue : AmmunitionObsolete.Create(serializable, this);
		}
		public Component GetComponent(ItemId<Component> id) 
		{
            if (_componentMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = Content?.GetComponent(id.Value);
            return serializable == null ? Component.DefaultValue : Component.Create(serializable, this);
		}
		public ComponentMod GetComponentMod(ItemId<ComponentMod> id) 
		{
            if (_componentModMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = Content?.GetComponentMod(id.Value);
            return serializable == null ? ComponentMod.DefaultValue : ComponentMod.Create(serializable, this);
		}
		public ComponentStats GetComponentStats(ItemId<ComponentStats> id) 
		{
            if (_componentStatsMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = Content?.GetComponentStats(id.Value);
            return serializable == null ? ComponentStats.DefaultValue : ComponentStats.Create(serializable, this);
		}
		public Device GetDevice(ItemId<Device> id) 
		{
            if (_deviceMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = Content?.GetDevice(id.Value);
            return serializable == null ? Device.DefaultValue : Device.Create(serializable, this);
		}
		public DroneBay GetDroneBay(ItemId<DroneBay> id) 
		{
            if (_droneBayMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = Content?.GetDroneBay(id.Value);
            return serializable == null ? DroneBay.DefaultValue : DroneBay.Create(serializable, this);
		}
		public Faction GetFaction(ItemId<Faction> id) 
		{
            if (_factionMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = Content?.GetFaction(id.Value);
            return serializable == null ? Faction.DefaultValue : Faction.Create(serializable, this);
		}
		public Satellite GetSatellite(ItemId<Satellite> id) 
		{
            if (_satelliteMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = Content?.GetSatellite(id.Value);
            return serializable == null ? Satellite.DefaultValue : Satellite.Create(serializable, this);
		}
		public SatelliteBuild GetSatelliteBuild(ItemId<SatelliteBuild> id) 
		{
            if (_satelliteBuildMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = Content?.GetSatelliteBuild(id.Value);
            return serializable == null ? SatelliteBuild.DefaultValue : SatelliteBuild.Create(serializable, this);
		}
		public Ship GetShip(ItemId<Ship> id) 
		{
            if (_shipMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = Content?.GetShip(id.Value);
            return serializable == null ? Ship.DefaultValue : Ship.Create(serializable, this);
		}
		public ShipBuild GetShipBuild(ItemId<ShipBuild> id) 
		{
            if (_shipBuildMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = Content?.GetShipBuild(id.Value);
            return serializable == null ? ShipBuild.DefaultValue : ShipBuild.Create(serializable, this);
		}
		public Skill GetSkill(ItemId<Skill> id) 
		{
            if (_skillMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = Content?.GetSkill(id.Value);
            return serializable == null ? Skill.DefaultValue : Skill.Create(serializable, this);
		}
		public Technology GetTechnology(ItemId<Technology> id) 
		{
            if (_technologyMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = Content?.GetTechnology(id.Value);
            return serializable == null ? Technology.DefaultValue : Technology.Create(serializable, this);
		}
		public Character GetCharacter(ItemId<Character> id) 
		{
            if (_characterMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = Content?.GetCharacter(id.Value);
            return serializable == null ? Character.DefaultValue : Character.Create(serializable, this);
		}
		public Fleet GetFleet(ItemId<Fleet> id) 
		{
            if (_fleetMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = Content?.GetFleet(id.Value);
            return serializable == null ? Fleet.DefaultValue : Fleet.Create(serializable, this);
		}
		public LootModel GetLoot(ItemId<LootModel> id) 
		{
            if (_lootMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = Content?.GetLoot(id.Value);
            return serializable == null ? LootModel.DefaultValue : LootModel.Create(serializable, this);
		}
		public QuestModel GetQuest(ItemId<QuestModel> id) 
		{
            if (_questMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = Content?.GetQuest(id.Value);
            return serializable == null ? QuestModel.DefaultValue : QuestModel.Create(serializable, this);
		}
		public QuestItem GetQuestItem(ItemId<QuestItem> id) 
		{
            if (_questItemMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = Content?.GetQuestItem(id.Value);
            return serializable == null ? QuestItem.DefaultValue : QuestItem.Create(serializable, this);
		}
		public Ammunition GetAmmunition(ItemId<Ammunition> id) 
		{
            if (_ammunitionMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = Content?.GetAmmunition(id.Value);
            return serializable == null ? Ammunition.DefaultValue : Ammunition.Create(serializable, this);
		}
		public BulletPrefab GetBulletPrefab(ItemId<BulletPrefab> id) 
		{
            if (_bulletPrefabMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = Content?.GetBulletPrefab(id.Value);
            return serializable == null ? BulletPrefab.DefaultValue : BulletPrefab.Create(serializable, this);
		}
		public VisualEffect GetVisualEffect(ItemId<VisualEffect> id) 
		{
            if (_visualEffectMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = Content?.GetVisualEffect(id.Value);
            return serializable == null ? VisualEffect.DefaultValue : VisualEffect.Create(serializable, this);
		}
		public Weapon GetWeapon(ItemId<Weapon> id) 
		{
            if (_weaponMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = Content?.GetWeapon(id.Value);
            return serializable == null ? Weapon.DefaultValue : Weapon.Create(serializable, this);
		}

		public void AddAmmunitionObsolete(int id, AmmunitionObsolete item) { _ammunitionObsoleteMap.Add(id, item); }
		public void AddComponent(int id, Component item) { _componentMap.Add(id, item); }
		public void AddComponentMod(int id, ComponentMod item) { _componentModMap.Add(id, item); }
		public void AddComponentStats(int id, ComponentStats item) { _componentStatsMap.Add(id, item); }
		public void AddDevice(int id, Device item) { _deviceMap.Add(id, item); }
		public void AddDroneBay(int id, DroneBay item) { _droneBayMap.Add(id, item); }
		public void AddFaction(int id, Faction item) { _factionMap.Add(id, item); }
		public void AddSatellite(int id, Satellite item) { _satelliteMap.Add(id, item); }
		public void AddSatelliteBuild(int id, SatelliteBuild item) { _satelliteBuildMap.Add(id, item); }
		public void AddShip(int id, Ship item) { _shipMap.Add(id, item); }
		public void AddShipBuild(int id, ShipBuild item) { _shipBuildMap.Add(id, item); }
		public void AddSkill(int id, Skill item) { _skillMap.Add(id, item); }
		public void AddTechnology(int id, Technology item) { _technologyMap.Add(id, item); }
		public void AddCharacter(int id, Character item) { _characterMap.Add(id, item); }
		public void AddFleet(int id, Fleet item) { _fleetMap.Add(id, item); }
		public void AddLoot(int id, LootModel item) { _lootMap.Add(id, item); }
		public void AddQuest(int id, QuestModel item) { _questMap.Add(id, item); }
		public void AddQuestItem(int id, QuestItem item) { _questItemMap.Add(id, item); }
		public void AddAmmunition(int id, Ammunition item) { _ammunitionMap.Add(id, item); }
		public void AddBulletPrefab(int id, BulletPrefab item) { _bulletPrefabMap.Add(id, item); }
		public void AddVisualEffect(int id, VisualEffect item) { _visualEffectMap.Add(id, item); }
		public void AddWeapon(int id, Weapon item) { _weaponMap.Add(id, item); }

        public ImageData GetImage(string name) { return Content?.GetImage(name) ?? ImageData.Empty; }
        public AudioClipData GetAudioClip(string name) { return Content?.GetAudioClip(name) ?? AudioClipData.Empty; }
        public string GetLocalization(string language) { return Content?.GetLocalization(language); }

		protected DatabaseContent Content { get; private set; }
        protected IDataStorage Storage { get; private set; }

        private void Clear()
        {
            Content = null;
            Storage = null;

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

			GalaxySettings = null;
			ShipSettings = null;
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
	}
}

