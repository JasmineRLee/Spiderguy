using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using TMPro;

public class EndZone : MonoBehaviour
{
    [SerializeField] private AudioSource LevelUp;
    [SerializeField] private GameObject timerManager;
   private void OnTriggerEnter2D(Collider2D other) 
   {
        LevelUp.Play();
        Debug.Log("congrats, next level");
        GameObject timerText = GameObject.Find("TimerText");
        TextMeshProUGUI tmp = timerText.GetComponent<TextMeshProUGUI>();
        tmp.color = Color.red;
        StartCoroutine(waiter());

        //stop timer, save time.
        Timer t = timerManager.GetComponent<Timer>();
        t.OnClickPause();
    }

    IEnumerator waiter() {
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
