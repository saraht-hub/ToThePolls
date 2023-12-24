using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speech : MonoBehaviour
{
    public GameObject speechBubble1;
    public GameObject speechBubble2;
    public GameObject button1;
    public GameObject button2;

    // Start is called before the first frame update
    void Start()
    {
        speechBubble1 = GameObject.Find("Speech1");
        speechBubble2 = GameObject.Find("Speech2");
        button1 = GameObject.Find("Button1");
        button2 = GameObject.Find("Button2");
    }

    // Update is called once per frame
    void Update()
    {
        speechBubble2.SetActive(true);
        speechBubble1.SetActive(false);
        button2.SetActive(true);
        button1.SetActive(false);
    }
}
