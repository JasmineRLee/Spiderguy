using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    public float currentTime;
    public bool pause;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //    currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
        if (!pause) {
            currentTime += Time.deltaTime;
        }

        timerText.text = currentTime.ToString("0.00");
    }

    public void OnClickPause()
    {
        pause = true;
    }

    public void onClickPlay() {
        pause = false;
    }

}
