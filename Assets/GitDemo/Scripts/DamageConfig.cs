using UnityEngine;

namespace Workshop.GitDemo
{
    // 傷害功能的開關：真或假存在資料檔裡，不是寫死在程式裡。
    // 預設關著，確認過沒問題才在 Inspector 打開。
    [CreateAssetMenu(menuName = "YT26/Damage Toggle")]
    public class DamageConfig : ScriptableObject
    {
        public bool damageEnabled = false;
        public int damageAmount = 5;
    }
}
