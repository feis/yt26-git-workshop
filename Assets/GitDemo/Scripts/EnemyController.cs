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

            // 傷害直接寫進行為，沒有開關。
            ApplyDamage();
        }

        void ApplyDamage()
        {
            Debug.Log($"{name} 造成 5 點傷害");
        }
    }
}
