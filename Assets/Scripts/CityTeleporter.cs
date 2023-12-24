using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CityTeleporter : MonoBehaviour
{
    public GameObject houseBeacon;
    public GameObject voteBeacon;
    public GameObject candidatesBeacon;
    public bool beenVote = false;
    public bool beenCan = false;
    public bool beenHouse = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distHB = Vector3.Distance(transform.position, houseBeacon.transform.position);
        float distVB = Vector3.Distance(transform.position, voteBeacon.transform.position);
        float distCB = Vector3.Distance(transform.position, candidatesBeacon.transform.position);
        if(distHB < 5.5 && !beenHouse)
        {
            beenHouse = true;
            SceneManager.LoadScene("HomeScene");
        }
        if (distVB < 5.5 && !beenVote)
        {
            beenVote = true;
            SceneManager.LoadScene("Voting Polls");
        }
        if (distCB < 5.5 && !beenCan)
        {
            beenCan = true;
            SceneManager.LoadScene("Candidate Speech Room");
        }
    }
}
