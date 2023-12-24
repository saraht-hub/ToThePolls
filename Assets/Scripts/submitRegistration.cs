using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class submitRegistration : MonoBehaviour
{
    // Start is called before the first frame update
    public void endReg()
    {
        SceneManager.LoadScene("HomeScene");
        HomeSceneCanvas.Registered = true;
        Debug.Log("Registered");
    }
}
