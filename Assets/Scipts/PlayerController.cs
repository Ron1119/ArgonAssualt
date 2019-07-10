using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController: MonoBehaviour
{
    
    [Header ("General")]
    [Tooltip("In ms^-1")] [SerializeField] float xSpeed = 15f;
    [Tooltip("In ms^-1")] [SerializeField] float ySpeed = 15f;
    [Tooltip("In m")] [SerializeField] float xRange = 5f;
    [Tooltip("In m")] [SerializeField] float yRange = 3f;

    [Header("Screen-Position Based")]

  
    
    [SerializeField] float positionPitchFactor = -5f;
    [SerializeField] float positionYawFactor = -10f;

    [Header("Control-throw Based")]
    //[SerializeField] float positionYawFactor = -5f;
    [SerializeField] float controlPitchFactor = -5f;
    [SerializeField] float controlRollFactor = -40f;

    // Start is called before the first frame update
    float xThrow, yThrow;
    bool isControlEnabled = true;

    void Start()
    {

    }
    void OnCollisionEnter(Collision collision)
    { print("Player collide something");
    }
   
        // Update is called once per frame
        void Update()
    {
        ProcessTranslation();
        ProcessRotation();
    }
    void OnPlayerDeath()  // used to receive the message from other scripts
    { print("Controller is frozen");
    }

    private void ProcessRotation()
    {
        float pitch = transform.localPosition.y * positionPitchFactor + controlPitchFactor * yThrow;
        float yaw = xThrow * positionYawFactor;
        float roll = xThrow * controlRollFactor;
        transform.localRotation = Quaternion.Euler(pitch, yaw, roll);
    }

    private void ProcessTranslation()
    {
        // move horizontally

        xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        yThrow = CrossPlatformInputManager.GetAxis("Vertical");


        float xOffset = xThrow * xSpeed * Time.deltaTime;
        float rawNewPosX = transform.localPosition.x + xOffset;
        float clampedPosX = Mathf.Clamp(rawNewPosX, -xRange, xRange);
        // move vertically


        float yOffset = yThrow * ySpeed * Time.deltaTime;
        float rawNewPosY = transform.localPosition.y + yOffset;
        float clampedPosY = Mathf.Clamp(rawNewPosY, -yRange, yRange);

        transform.localPosition = new Vector3(clampedPosX, clampedPosY, transform.localPosition.z); // new position
    }
    
}
