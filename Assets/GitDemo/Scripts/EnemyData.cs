using UnityEngine;

namespace Workshop.GitDemo
{
    // 敵人數值放進資料檔，調整數值不用改程式，在 Inspector 就能改。
    [CreateAssetMenu(menuName = "YT26/Enemy Data")]
    public class EnemyData : ScriptableObject
    {
        public string displayName = "敵人";
        public int maxHp = 30;
        // 這個專案的慣例：對玩家的移動速度落在 3 到 8 之間。
        public float speed = 4f;
        public Color color = Color.gray;
    }
    // 2026-11-13：波次行列拆成 Rows/ 一個檔案一筆，這裡只留共用的欄位。
}
