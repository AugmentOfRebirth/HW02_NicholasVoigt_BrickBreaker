using UnityEngine;

public class BrickSpawnHandler : MonoBehaviour
{
    public GameObject brickNormal;
    public GameObject brick2;
    public GameObject brick3;

    void Start()
    {
        GameObject brickToSpawn;

        int spawnNum = Random.Range(0, 3);

        brickToSpawn = brickNormal;
        //if (spawnNum == 0)
        //{
        //    brickToSpawn = brickNormal;
        //}
        //else if (spawnNum == 1)
        //{
        //    brickToSpawn = brick2;
        //}
        //else
        //{
        //    brickToSpawn = brick3;
        //}


        GameObject spawnLocation = brickToSpawn;

        Instantiate(brickToSpawn, transform.position, Quaternion.identity);
        brickToSpawn.transform.position = new Vector2(spawnLocation.transform.position.x, spawnLocation.transform.position.y);
    }
}
