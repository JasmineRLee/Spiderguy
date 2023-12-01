using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioSource LevelUp;
    public AudioSource Spring;
    public AudioSource Click;
    public AudioSource Pop;

    public void PlayLevelUp() {
        LevelUp.Play();
    }

    public void PlaySpring() {
        Spring.Play();
    }

    public void PlayClick() {
        Click.Play();
    }

    public void PlayPop() {
        Pop.Play();
    }

    void OnTriggerEnter2D() {
        LevelUp.Play();
    }
}
