using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject transitionIn;
    public float fadeTime = 1f;

    public static MainMenu singleton;

    void Awake(){
        if(singleton == null){
            singleton = this;
        }
        else{
            Destroy(this.gameObject);
        }
    }

    public void StartGame ()
    {
        // StartCoroutine(FadeInRoutine());
        // IEnumerator FadeInRoutine()
        // {
        //     float timer = 0f;
        //     float size = 0;

        //     while (timer < fadeTime)
        //     {
        //         size = timer * 870 / fadeTime;
        //         transitionIn.transform.localScale = new Vector3(size,size,size);
        //         timer += Time.deltaTime;
        //         yield return null;
        //     }

            SceneManager.LoadScene(1);
        // }

    }

    public void QuitGame ()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void LevelMenu ()
    {
        SceneManager.LoadScene(5);
    }

}
