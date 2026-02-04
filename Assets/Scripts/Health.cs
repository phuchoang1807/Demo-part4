using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("VFX")]
    public GameObject explosionPrefab;

    [Header("HP")]
    public int defaultHealthPoint = 3;

    private int healthPoint;

    private void Start()
    {
        healthPoint = defaultHealthPoint;
    }

    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;

        healthPoint -= damage;

        if (healthPoint <= 0)
            Die();
    }

    // Nếu bạn muốn "đụng là chết" kiểu cũ, có thể giữ trigger này,
    // nhưng trong PART 4 chủ yếu dùng TakeDamage từ Bullet/EnemyAttack.
    // public void OnTriggerEnter2D(Collider2D collision) => Die();

    protected virtual void Die()
    {
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f);
        }

        Destroy(gameObject);
    }
}
