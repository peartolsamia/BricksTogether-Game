using UnityEngine;


public class Ball : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;


    
    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = Vector2.up * moveSpeed;
    }

    float hitFactor(Vector2 ballPos, Vector2 platePos, float plateHeight)
    {
        return (ballPos.x - platePos.x) / plateHeight;
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Plate(Down)")
        {
            float x = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.x);

            Vector2 direction = new Vector2(x, -1).normalized;

            GetComponent<Rigidbody2D>().linearVelocity = direction * moveSpeed;
        }


        if (collision.gameObject.name == "Plate(Up)")
        {
            float x = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.x);

            Vector2 direction = new Vector2(x, -1).normalized;

            GetComponent<Rigidbody2D>().linearVelocity = direction * moveSpeed;
        }
    }
}
