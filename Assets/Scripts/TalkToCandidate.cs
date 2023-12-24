using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkToCandidate : MonoBehaviour
{
    public GameObject player;
    public GameObject npc;
    public GameObject thing;
    public GameObject thing2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(player.transform.position, npc.transform.position);
        if (dist < 4)
        {
            thing.active = true;
            thing2.active = false;
        }
        if (dist > 4)
        {
            thing.active = false;
            thing2.active = true;
        }
    }
}
