using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToMouse : MonoBehaviour
{
public float speed = 5f;
private Vector3 target;
private bool keepMoving;

    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            keepMoving = true;
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }
        if (keepMoving == true){
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        keepMoving = false;
    }

    private void OnCollisionStay2D(Collision2D other) {
        // keepMoving = false;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        //SceneManager.LoadScene(1);   //load next level
        Debug.Log("congarts, next level");
        //stop timer, save time.
    }
}
