using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BrickBehavior : MonoBehaviour
{
    public enum brickType
    {
        NormalBrick,
        TougherBrick,
        PowerupBrick
    }
    public brickType type;
    public GameObject brickOriginal;

    public GameObject powerup1;
    public GameObject powerup2;
    public GameObject powerup3;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball") && type == brickType.TougherBrick)
        {
            Destroy(gameObject);
            Instantiate(brickOriginal, transform.position, Quaternion.identity);
        }
        else if (collision.gameObject.CompareTag("Ball") && type == brickType.NormalBrick)
        {
            Destroy(gameObject);
            Instantiate(brickOriginal, transform.position, Quaternion.identity);
        }
        else if(collision.gameObject.CompareTag("Ball") && type == brickType.PowerupBrick)
        {
            Destroy(gameObject);
            //spawn powerup

            GameObject powerupToSpawn;
            int spawnNum = Random.Range(0, 3);
            if (spawnNum == 0)
            {
                powerupToSpawn = powerup1;
            }
            else if (spawnNum == 1)
            {
                powerupToSpawn = powerup2;
            }
            else
            {
                powerupToSpawn = powerup3;
            }
            Instantiate(powerupToSpawn, transform.position, Quaternion.identity);
        }
        else if (collision.gameObject.CompareTag("OB"))
        {
            Destroy(gameObject);
        }
        
    }
}
