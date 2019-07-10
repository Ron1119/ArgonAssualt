using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadFirstScene", 2f);  // load after 2 sec
    }
    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);  // make sure the scenes have been added to the scene window
    }
}
