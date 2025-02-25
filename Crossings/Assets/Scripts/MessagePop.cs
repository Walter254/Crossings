using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessagePop : MonoBehaviour
{

    public GameObject Message;
    public GameObject DialogBoxBackground;

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Collision");
        if(other.gameObject.tag == "Player")
        {
            Message.SetActive(true);
            DialogBoxBackground.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Message.SetActive(false);
            DialogBoxBackground.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
