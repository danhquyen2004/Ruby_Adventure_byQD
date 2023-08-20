using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        RubyController ruby = collision.GetComponent<RubyController>();
        if (ruby == null) return;
        if (ruby.health == ruby.maxHealth) return;
        ruby.ChangeHealth(1);
        Destroy(gameObject);
    }
}
