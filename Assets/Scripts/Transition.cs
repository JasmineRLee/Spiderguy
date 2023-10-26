using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{
    public float fadeTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeInRoutine());
        IEnumerator FadeInRoutine()
        {
            float timer = 0f;
            float size = 0;

            while (timer < fadeTime)
            {
                size = (fadeTime - timer) / fadeTime;
                transform.localScale = new Vector3(size, size, size);
                timer += Time.deltaTime;
                yield return null;
            }

            transform.localScale = new Vector3(0, 0, 0);
            Debug.Log(size);

            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
