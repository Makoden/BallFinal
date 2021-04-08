using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public int PlayerLivesNum;

    // Start is called before the first frame update
    void Start()
    {
        PlayerLivesNum = 5;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdatePlayerLives(int amount)
    {
        PlayerLivesNum += amount;
        Debug.Log("Lives:" + PlayerLivesNum);
    }   
}
