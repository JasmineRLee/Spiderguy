using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToMouse : MonoBehaviour
{
public float speed = 5f;
private Vector3 target;
private bool keepMoving;

private bool isPaused;
private bool buttonHover;
public AudioSource Spring;
private SpriteRenderer ren;

    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !buttonHover && !isPaused)
        {
            keepMoving = true;
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }

        if (keepMoving && !isPaused){
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }

    }

    private void OnCollisionEnter2D(Collision2D other) {
        keepMoving = false;
    }

    private void OnCollisionStay2D(Collision2D other) {
        // keepMoving = false;
    }

    // private void OnTriggerEnter2D(Collider2D other) {
    //     //SceneManager.LoadScene(1);   //load next level
    //     Debug.Log("congarts, next level");
    //     //stop timer, save time.
    // }

    public void OnButtonHover() {
        buttonHover = true;
    }

    public void ExitButtonHover() {
        buttonHover = false;
    }

    public void OnClickPause() {
        isPaused = true;
    }

    public void onClickPlay() {
        isPaused = false;
    }

    public void OnTriggerEnter2D (Collider2D coll)
    {   
        
        if(coll.gameObject.CompareTag("Flyguy")) {
            ren = GetComponent<SpriteRenderer>();
            ren.color = Color.white;
            Spring.Play();
            Destroy(coll.gameObject);
            speed = 10f;
        }

        // if(coll.gameObject.CompareTag("doorButton")) {

        // }
    }
}
