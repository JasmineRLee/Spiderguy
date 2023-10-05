using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpiderGuy : MonoBehaviour
{
    float speed = 200;
    public TextMeshProUGUI myLabel;
    private int number;

    [SerializeField] private AudioSource FlyMunch;

    // Start is called before the first frame update
    void Start()
    {
        number = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }

        // clip position here
        if(transform.position.x < 90)
        {
            transform.position = new Vector3(90, transform.position.y, transform.position.z);
        }

        if (transform.position.x > 770)
        {
            transform.position = new Vector3(770, transform.position.y, transform.position.z);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Birdguy")
        {
            SceneManager.LoadScene(0);
        }

        if (collision.gameObject.tag == "Flyguy")
        {
            FlyMunch.Play();
            Destroy(collision.gameObject);
            number += 1;
            myLabel.GetComponent<TextMeshProUGUI>().text = "Score: " + number;
        }
    }
}
