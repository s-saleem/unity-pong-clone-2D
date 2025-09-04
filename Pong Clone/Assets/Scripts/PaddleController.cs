using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed = 10f;
    public string inputAxis;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float move = Input.GetAxisRaw(inputAxis);
        rb.linearVelocity = new Vector2(0, move * speed);
    }
}
