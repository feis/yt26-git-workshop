using UnityEngine;

namespace Workshop.GitDemo
{
    // 敵人行為：讀資料檔裡的速度移動。數值不寫死在程式裡。
    public class EnemyController : MonoBehaviour
    {
        public EnemyData data;
        // 傷害做在開關上：開關在 DamageConfig 這份資料裡，預設關著。
        public DamageConfig damage;

        void Update()
        {
            if (data == null) return;
            transform.Translate(Vector3.forward * data.speed * Time.deltaTime);

            if (damage != null && damage.damageEnabled) ApplyDamage();
        }

        void ApplyDamage()
        {
            Debug.Log($"{name} 造成 {damage.damageAmount} 點傷害");
        }
    }
}
