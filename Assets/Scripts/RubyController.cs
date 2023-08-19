using UnityEngine;

public class RubyController : MonoBehaviour
{
    public int maxHealth = 5;
    private int currentHealth;
    public int health { get { return currentHealth; } }


    public float speed = 3.0f;
    float horizontal;
    float vertical;
    Rigidbody2D rigidbody2;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        Vector2 position = rigidbody2.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;
        rigidbody2.MovePosition(position);
    }

    public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth+amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }

}
