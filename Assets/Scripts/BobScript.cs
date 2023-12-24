using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobScript : MonoBehaviour
{
    public Animator bobber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            bobber.SetTrigger("start");
            bobber.ResetTrigger("stop");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            bobber.SetTrigger("start");
            bobber.ResetTrigger("stop");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            bobber.SetTrigger("start");
            bobber.ResetTrigger("stop");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            bobber.SetTrigger("start");
            bobber.ResetTrigger("stop");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            bobber.SetTrigger("stop");
            bobber.ResetTrigger("start");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            bobber.SetTrigger("stop");
            bobber.ResetTrigger("start");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            bobber.SetTrigger("stop");
            bobber.ResetTrigger("start");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            bobber.SetTrigger("stop");
            bobber.ResetTrigger("start");
        }
    }
}
