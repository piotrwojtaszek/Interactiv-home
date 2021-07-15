using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    private float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 2f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isPaused;
    Vector3 velocity;
    bool isGrounded;
    // Update is called once per frame
    private void Start()
    {
        UIMenu.Instance.onDisable += () => isPaused = false;
        UIMenu.Instance.onEnable += () => isPaused = true;
    }
    void Update()
    {
        if (isPaused)
            return;
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        if (Input.GetKey(KeyCode.LeftShift))
            speed = 12f;
        else
            speed = 6f;
        controller.Move(move * speed * Time.deltaTime);


        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }


        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
