using UnityEngine;

public class BrickSpawner : MonoBehaviour
{
    public GameObject brickNormal;
    public GameObject brick2;
    public GameObject brick3;
    void Start()
    {
        spawnBricks();
    }
    public void spawnBricks()
    {
        GameObject brickToSpawn;

        foreach (Transform child in transform)
        {
            int spawnNum = Random.Range(0, 2);
            if (spawnNum == 0)
            {
                brickToSpawn = brickNormal;
            }
            else
            {
                brickToSpawn = brick2;
            }
            Instantiate(brickToSpawn, child.position, Quaternion.identity);
        }
    }
}
