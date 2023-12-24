using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Badboi : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene("HomeScene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
