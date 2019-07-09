﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class musicplayer1 : MonoBehaviour
{
    // Start is called before the first frame update
     private void Awake()
    {
        DontDestroyOnLoad(gameObject);   // don't interupt the object the scirpt attached to, which is MusicPlayer
    }
    // Start is called before the first frame update
   

    void Start()
    {
        Invoke("LoadFirstScene", 2f);  // load after 2 sec
    }
    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);  // make sure the scenes have been added to the scene window
    }
    // Update is called once per frame
}
