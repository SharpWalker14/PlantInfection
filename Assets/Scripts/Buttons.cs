using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour
{

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void Quitting()
    {
        Application.Quit();
    }
}
