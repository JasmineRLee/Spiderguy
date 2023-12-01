using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void Pause(){
        pauseMenu.SetActive(true);
    }

    public void Resume(){
        pauseMenu.SetActive(false);
        //resume time
    }

    public void MainButton(int sceneID){
        //set time back to ?
        SceneManager.LoadScene(sceneID);
    }
}
