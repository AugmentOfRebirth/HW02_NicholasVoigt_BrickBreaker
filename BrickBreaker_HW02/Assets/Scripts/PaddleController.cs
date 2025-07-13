using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour
{
    private Rigidbody2D playerRigidBody;
    private float inputHorizontal;
    public float movementSpeed;
    private float baseSpeed;
    public BallOfBounce ballOfBounce;
    private Coroutine speedRoutine;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
        baseSpeed = movementSpeed;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("P_Score"))
        {
            ballOfBounce.addScore();
            Destroy(collision.gameObject);

        }
        else if (collision.gameObject.CompareTag("P_Life"))
        {
            ballOfBounce.addLife();
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("P_Speed"))
        {
            if (speedRoutine != null)
            {
                StopCoroutine(speedRoutine);
            }

            speedRoutine = StartCoroutine(speedUp());
            Destroy(collision.gameObject);
        }
    }
    IEnumerator speedUp()
    {
        movementSpeed = baseSpeed * 2;

        yield return new WaitForSeconds(10f);

        movementSpeed = baseSpeed;
    }
}
