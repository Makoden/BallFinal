using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallControl : MonoBehaviour
{
    public float moveStrength;
    public float jumpStrength;
    
    bool isGrounded;
    public float maxSpeed;
    Vector3 lastGoodPos;
    

    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;

    }

    private void OnCollisionExit(Collision collision)
    {
        if (isGrounded)
        {
            isGrounded = false;
        }
    }
    // Update is called once per frame
    void Update()
    {


        if ((Input.GetKeyDown("space") || OVRInput.Get(OVRInput.Button.SecondaryHandTrigger)) && isGrounded)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpStrength);
        }
        if (Input.GetKey("w") || OVRInput.Get (OVRInput.Button.SecondaryThumbstickUp))

        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * moveStrength);
        }
        if (Input.GetKey("a") || OVRInput.Get(OVRInput.Button.SecondaryThumbstickDown))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * moveStrength);
        }
        if (Input.GetKey("s") || OVRInput.Get(OVRInput.Button.SecondaryThumbstickLeft))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back * moveStrength);
        }
        if (Input.GetKey("d") || OVRInput.Get(OVRInput.Button.SecondaryThumbstickRight))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * moveStrength);
        }
        if (Input.GetKeyDown("g") && isGrounded )
        {
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.up * jumpStrength);
        }
    }
    
} 

