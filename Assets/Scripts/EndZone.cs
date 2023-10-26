using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using TMPro;

public class EndZone : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other) 
   {
        Debug.Log("congarts, next level");
        GameObject timerText = GameObject.Find("TimerText");
        TextMeshProUGUI tmp = timerText.GetComponent<TextMeshProUGUI>();
        tmp.color = Color.red;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //load next level
        //stop timer, save time.
    }
}
