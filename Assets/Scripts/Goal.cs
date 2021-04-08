using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Goal : MonoBehaviour
{

 
  
    public Text endGameText;
  
    public void OnTriggerEnter(Collider other)
    {
            if (other.gameObject.name == "Player")
            {
              endGameText.text = "Congratulations! You've finished the game! Press R to restart.";
            }
        
    }

}
