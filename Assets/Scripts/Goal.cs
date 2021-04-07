using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
    void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == "Player")
            {
                Debug.Log("Congratulations. You've beat the game!");
             
            }
        }
    }
}
