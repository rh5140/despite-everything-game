using UnityEngine;

public class Player : MonoBehaviour
{
    // Starting w/ tutorial https://www.youtube.com/watch?v=xcmYsc2BY-U

    public float runSpeed;
    public float jumpForce;
    [SerializeField] bool isGrounded = false;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded == true)
            {
                rb.AddForce(Vector2.up * jumpForce);
                isGrounded = false;
            }
        }
        // float directionY = Input.GetAxisRaw("Vertical");
        // playerDirection = new Vector2(0, directionY).normalized;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            if (!isGrounded)
            {
                isGrounded = true;
            }
        }
    }

}
