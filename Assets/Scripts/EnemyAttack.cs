using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] public EnemyHealth enemyHealth;
    public int damage ;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<PlayerHealth>();
        if (player != null)
        {
            player.TakeDamage(damage);

            // Enemy tự nổ
            enemyHealth.TakeDamage(999);
        }
    }
}
