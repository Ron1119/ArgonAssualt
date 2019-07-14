using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject deathFX; // create object for use the enemy explosion
    [SerializeField] Transform parent;
    void Start()
    {
        // gameObject.AddComponent<BoxCollider>();  // add the boxcollider at the beginning of the game
        Collider boxCollider = gameObject.AddComponent<BoxCollider>();  // assign a name to the component
        boxCollider.isTrigger = false;
        
    }

    void OnParticleCollision(GameObject other)
    {

        GameObject fx =Instantiate(deathFX, transform.position, Quaternion.identity); // add the particle effect to current object, and dont rotate the particle
        // print("Particles collided with enemy " + gameObject.name);
        fx.transform.parent = parent;
         Destroy(gameObject);
    }



}
