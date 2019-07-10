using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionHandler : MonoBehaviour
{

    [Tooltip("In Second")][SerializeField] float levelLoadDelay = 1f;
    [Tooltip("FX prefab on player")][SerializeField] GameObject deathFx;
    int SceneIndex = 0;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        StartDeathSequence();
    }

    private void StartDeathSequence()
    {
        
        SendMessage("OnPlayerDeath"); // activate the OnPalyerDeath() in the PlayerController scipts.
        deathFx.SetActive(true);
        Invoke("ReloadScene", levelLoadDelay);
    }
    private void ReloadScene()  //  
    {
        SceneManager.LoadScene(0);
    }

}
