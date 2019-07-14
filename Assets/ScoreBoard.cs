using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int scorePerHit = 12;
    int score;
    Text scoreText;
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = score.ToString();  // assign the score to the Text object;
    }

    public void ScoreHit()
    {
        score = score + scorePerHit;
        scoreText.text = score.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
