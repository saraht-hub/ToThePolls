using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class submitBallot : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("End");
        Debug.Log("Yes");
    }
}
