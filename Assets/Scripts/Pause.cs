using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseHud;
    public bool paused;
    // Start is called before the first frame update
    void Start()
    {
        Resume();
    }
    void Update()
    {
        SwitchPause();
    }

    void SwitchPause()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !paused)
        {
            Paused();
        }
    }
    public void Paused()
    {
        Time.timeScale = 0;
        pauseHud.SetActive(true);
        /*if (!paused)
        {
            AudioSource[] audios = FindObjectsOfType<AudioSource>();
            foreach (AudioSource a in audios)
            {
                a.Pause();
            }
        }*/
        //pauseMusic.Play();
        paused = true;

    }
    public void Resume()
    {
        Time.timeScale = 1;
        pauseHud.SetActive(false);
        /*if (paused)
        {
            AudioSource[] audios = FindObjectsOfType<AudioSource>();
            foreach (AudioSource a in audios)
            {
                a.UnPause();
            }
        }*/
        //pauseMusic.Pause();
        paused = false;
    }
}
