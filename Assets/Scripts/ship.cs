using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ship : MonoBehaviour
{
    bool ColliderShip = true;

    [SerializeField] float xmov = 20f;
    [SerializeField] float xspeed = 17f;

    [SerializeField] float ymov = 17f;
    [SerializeField] float yspeed = 12f;

    [SerializeField] float controlpitch = 10f;
    [SerializeField] float controlroll = 14f;

    private float xThrow;
    private float yThrow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ColliderShip)
        {
            xMovement();

            yMovement();

            rotations();
        }
    }

    private void rotations()
    {
        float pitch = transform.localPosition.y + yThrow * controlpitch;
        float yaw = transform.localPosition.x;
        float roll = xThrow * controlroll;
        transform.localRotation = Quaternion.Euler(-pitch, yaw, roll);
    }

    private void yMovement()
    {
        yThrow = CrossPlatformInputManager.GetAxis("Vertical");
        float yoffset = yspeed * yThrow * Time.deltaTime;
        float ynew = transform.localPosition.y + yoffset;
        float yrnge = Mathf.Clamp(ynew, -ymov, ymov);
        transform.localPosition = new Vector3(transform.localPosition.x, yrnge, transform.localPosition.z);
    }

    private void xMovement()
    {
        xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float xoffset = xspeed * xThrow * Time.deltaTime;
        float xnew = transform.localPosition.x + xoffset;
        float xrnge = Mathf.Clamp(xnew, -xmov, xmov);
        transform.localPosition = new Vector3(xrnge, transform.localPosition.y, transform.localPosition.z);
    }

    void disable()
    {
        ColliderShip = false;
    }

}
