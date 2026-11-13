using UnityEngine;

namespace Workshop.GitDemo
{
    // 掉東西的設定。dropChance 是 0 到 1 之間的機率。
    [CreateAssetMenu(menuName = "YT26/Drop Data")]
    public class DropData : ScriptableObject
    {
        public string itemName = "補血";
        [Range(0f, 1f)] public float dropChance = 0.25f;
    }
}
