using TMPro;
using UnityEngine;

public class BallOfBounce : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 10f;
    int score = 0;
    int lives = 5;
    public TextMeshProUGUI scoretxt;
    public GameObject[] livesImage;
    public GameObject gameoverPanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = Vector2.down * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("OB"))
        {
            if(lives <= 0)
            {
                gameOver();
            }
            else
            {
                transform.position = Vector3.zero;
                rb.linearVelocity = Vector2.down * speed;
                lives--;
                livesImage[lives].gameObject.SetActive(false);
            }
        }
        else if (collision.gameObject.CompareTag("Brick"))
        {
            Destroy(collision.gameObject);
            score += 30;
            scoretxt.text = score.ToString("000000");
        }
    }
    void FixedUpdate()
    {
        rb.linearVelocity = rb.linearVelocity.normalized * speed;
    }

    public void gameOver()
    {      
        gameoverPanel.SetActive(true);
        Time.timeScale = 0;
        Destroy(gameObject);
    }
}
