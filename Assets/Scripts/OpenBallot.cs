using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenBallot : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Collision");
            SceneManager.LoadScene("VotingBallot");
            Cursor.lockState = CursorLockMode.None;
        }
    }
    

    
   


}
