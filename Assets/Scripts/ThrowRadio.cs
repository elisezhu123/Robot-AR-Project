using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowRadio : MonoBehaviour
{
    public float throwForce = 200f;

    public Vector3 stanTra = new(0, 1f, 0); //stanTra = stanTra + offset;


    private bool isTouched = false;
    private bool isThrown = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Vector3 startPosition;
    private Vector3 endPosition;
    
    private Vector3 offset;
        private int timeFlick; 
        
    private float disFlick;

    private float speedFlick;

    private Camera ARcamera;


    void Start()
    {
        ARcamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTouched){
            Handslip();
        }
    }

    private void resetVari(){
        startPosition = Input.mousePosition;
        endPosition = Input.mousePosition;
    }
    
    private void OnMouseDown()
    {
        if (!isTouched == false)
        {
            isTouched = true;
        }
    }

    private void Handslip()
    {
        timeFlick += 25;
        if (Input.GetMouseButtonDown(0))
        {
            resetVari();
        }

        if (Input.GetMouseButton(0))
        {
            endPosition = Input.mousePosition;
            offset = ARcamera.transform.rotation * (endPosition - startPosition);
            disFlick = Vector3.Distance(startPosition, endPosition);
        }

        if (Input.GetMouseButtonUp(0))
        {
            speedFlick = disFlick / timeFlick;
            isTouched = false;
            timeFlick = 0;
            if (disFlick > 20 &&endPosition.y - startPosition.y > 0)
            {
                Throw();
            }
        }
    }
    private void Throw(){
        transform.gameObject.AddComponent<Rigidbody>();
        Rigidbody _rigRadio = transform.GetComponent<Rigidbody>();
#pragma warning disable UNT0024 // Give priority to scalar calculations over vector calculations
        _rigRadio.linearVelocity = offset * 0.003f * speedFlick;
#pragma warning restore UNT0024 // Give priority to scalar calculations over vector calculations
        _rigRadio.AddForce(transform.parent.parent.transform.forward * throwForce);
        _rigRadio.AddTorque(transform.right);
        _rigRadio.linearDamping= 0.5f;
        isThrown = true;
        transform.parent = null;
    }
}


