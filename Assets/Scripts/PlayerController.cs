using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;

    public float gravityScale = 1.0f;
    public static float globalGravity = -9.81f;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.constraints = (RigidbodyConstraints) 80;
        _rb.useGravity = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(Vector2.up * jumpForce);
        }

        ManageMovement();
    }

    private void FixedUpdate()
    {
        var gravity = globalGravity * gravityScale * Vector3.up;
        _rb.AddForce(gravity, ForceMode.Acceleration);
    }


    private void ManageMovement()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        var direction = new Vector3(h, 0, v);
        var velocity = direction * speed;
        _rb.velocity = velocity;
    }
}