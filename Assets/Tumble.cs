using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tumble : MonoBehaviour
{
    private Rigidbody rb;
    public float initialSpeed = 15f;
    public float Speed = 2f;
    public float TorqueSpeed = 20f;
    public float bounceAmount = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * initialSpeed, ForceMode.Impulse);
    }

    void Update()
    {
        
        rb.AddTorque(transform.right * TorqueSpeed * Time.deltaTime);
        
    }

    private void OnCollisionEnter(Collision other)
    {
        Bounce(other);
    }

    private void Bounce(Collision other)
    {
        var dir = (other.GetContact(0).normal + transform.forward).normalized * bounceAmount;
        rb.AddForce(dir, ForceMode.Impulse);
    }
}
