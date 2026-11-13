using UnityEngine;

namespace Workshop.GitDemo
{
    // 遊戲規則的數值：改這些不用動程式。
    [CreateAssetMenu(menuName = "YT26/Rules Data")]
    public class RulesData : ScriptableObject
    {
        public int startingLives = 3;
        public float timeLimit = 90f;
    }
}
