using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HouseTeleporter : MonoBehaviour
{
    public GameObject invisCollider;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(transform.position, invisCollider.transform.position);
        if (dist < 2)
        {
            SceneManager.LoadScene("CityScene");
        }
    }
}
