using UnityEngine;

public class PaddleController : MonoBehaviour
{
    private Rigidbody2D playerRigidBody;
    private float inputHorizontal;
    public float movementSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayerLateral();
    }

    public void movePlayerLateral()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");

        playerRigidBody.linearVelocity = new Vector2(movementSpeed * inputHorizontal, playerRigidBody.linearVelocity.y);
    }
}
