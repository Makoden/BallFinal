using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner2 : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject spawnedObstacle;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(obstacleSpawn());
    }


    IEnumerator obstacleSpawn()
    {

        while (true)
        {
            Destroy(spawnedObstacle);
            Vector3 obstacleSpawn = new Vector3(Random.Range(-12f, 12f), 500f, 10f);
            spawnedObstacle = Instantiate(obstacle, obstacleSpawn, Quaternion.identity);
            yield return new WaitForSeconds(5);
        }
    }
}