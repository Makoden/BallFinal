using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public Transform fabPointSpawn;
    public GameObject platformSpawn;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Spawns platform under the player
        if (Input.GetKeyDown(KeyCode.G))
        {
            GameObject spawnClone = Instantiate(platformSpawn, fabPointSpawn.position, Quaternion.identity);
            transform.position = player.transform.position - (new Vector3(0, 1, -20));
            Destroy(spawnClone, 4.0f);
        }

    }
}

