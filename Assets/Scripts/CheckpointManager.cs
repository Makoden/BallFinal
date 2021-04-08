using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    public GameObject player;
    private Vector3 lastCheckpoint;
    public ScoreScript Score_Script;

    // Start is called before the first frame update
    void Start()
    {
        lastCheckpoint = player.transform.position;
    }


    public void SetNewCheckpoint(Vector3 newCheckpoint)
    {
        lastCheckpoint = player.transform.position;
        Debug.Log("New Checkpoint Set at: " + newCheckpoint.ToString());
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            other.transform.position = lastCheckpoint;
            Debug.Log("Reset ball to checkpoint");
            Score_Script.UpdatePlayerLives(-1);
        }
    }
}

