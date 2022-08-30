using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPGGame.Gameplay
{
    [CreateAssetMenu(menuName = "RPG/Inventory/ItemConfig")]
    public class InventoryItemConfig : ScriptableObject
    {
        [UniqueIdentifier][SerializeField] string _id;
        public string ID => _id;

        [SerializeField] private string _name;
        public string Name => _name;

        [SerializeField] private Sprite _icon;
        public Sprite Icon => _icon;
    }
}
