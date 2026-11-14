using UnityEngine;

namespace Workshop.GitDemo
{
    // 敵人行為：讀資料檔裡的速度移動。數值不寫死在程式裡。
    public class EnemyController : MonoBehaviour
    {
        public EnemyData data;

        void Update()
        {
            if (data == null) return;
            transform.Translate(Vector3.forward * data.speed * Time.deltaTime);
        }
    }
    // 2026-11-13：讀 Rows/ 的行列；改這檔時要跟 EnemyData 的欄位一起對。
}
