using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeSceneCanvas : MonoBehaviour
{
    public static bool Registered;
    public GameObject thing;
    public GameObject thing2;
    // Start is called before the first frame update
    void Start()
    {
        Registered = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Registered)
        {
            thing.active = true;
            thing2.active = false;
        }
        if (Registered)
        {
            thing.active = false;
            thing2.active = true;
        }
    }
}
