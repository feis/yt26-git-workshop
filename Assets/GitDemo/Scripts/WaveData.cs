using UnityEngine;

namespace Workshop.GitDemo
{
    // 每一波出多少敵人、間隔多久。平衡調整最常動這裡。
    [CreateAssetMenu(menuName = "YT26/Wave Data")]
    public class WaveData : ScriptableObject
    {
        public int enemyCount = 8;
        public float spawnDelay = 1.2f;
    }
}
