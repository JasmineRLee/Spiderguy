using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fullscreen : MonoBehaviour
{
    public void Toggle() {
        Screen.fullScreen = !Screen.fullScreen;
        Debug.Log("fullscreen toggle");
    }
}
