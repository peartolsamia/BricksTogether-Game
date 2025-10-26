using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = Vector3.up * moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
