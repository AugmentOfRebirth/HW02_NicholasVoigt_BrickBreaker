using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BrickBehavior : MonoBehaviour
{
    public enum brickType
    {
        TougherBrick,
        PowerupBrick
    }
    public brickType type;
    public GameObject brickOriginal;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball") && type == brickType.TougherBrick)
        {
            Destroy(gameObject);
            Instantiate(brickOriginal, transform.position, Quaternion.identity);
        }
        else if(collision.gameObject.CompareTag("Ball") && type == brickType.PowerupBrick)
        {
            Destroy(gameObject);
            //spawn powerup
        }
        
    }
}
