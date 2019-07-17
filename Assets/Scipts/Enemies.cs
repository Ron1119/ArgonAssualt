using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject deathFX; // create object for use the enemy explosion
    // [SerializeField] GameObject hitFX;  // TODO generate hitting effect
    [SerializeField] Transform parent;
    [SerializeField] int scorePerHit = 12;
    [SerializeField] int maxHits = 6;  // the number of hits the enemy can sustain

    ScoreBoard scoreBoard;
    void Start()
    {
        // gameObject.AddComponent<BoxCollider>();  // add the boxcollider at the beginning of the game
        AddBoxCollider();
        scoreBoard = FindObjectOfType<ScoreBoard>();
    }

    private void AddBoxCollider()
    {
        Collider boxCollider = gameObject.AddComponent<BoxCollider>();  // assign a name to the component
        boxCollider.isTrigger = false;
    }

    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
        if (maxHits < 1)
        {
            KillEnemy();
        }
    }

    private void ProcessHit()
    {
        scoreBoard.ScoreHit(scorePerHit);
        maxHits--;
        // hitFX.SetActive(true); // TODO add effect when being hitted
    }

    private void KillEnemy()
    {
        GameObject fx = Instantiate(deathFX, transform.position, Quaternion.identity); // add the particle effect to current object, and dont rotate the particle
        // print("Particles collided with enemy " + gameObject.name);
        fx.transform.parent = parent;
        Destroy(gameObject);
    }
}
