using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class musicplayer1 : MonoBehaviour
{
    // Start is called before the first frame update

     private void Awake()
    {
        int numMusicPlayer = FindObjectsOfType<musicplayer1>().Length;
        print("object numberr: " + numMusicPlayer);
        if (numMusicPlayer>1)
        {
            Destroy(gameObject);
        }
            else
        {
            DontDestroyOnLoad(gameObject);
        }   // don't interupt the object the scirpt attached to, which is MusicPlayer
    }
    // Start is called before the first frame update
   
       
  
    
}
