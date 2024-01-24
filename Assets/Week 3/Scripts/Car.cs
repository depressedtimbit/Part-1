using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Car : MonoBehaviour
{
    float acceleration;
    float steering;
    public float forward_speed = 500;
    public float steering_speed = 100;
    public float maxSpeed = 50;
    Rigidbody2D riggybody;
    // Start is called before the first frame update
    void Start()
    {
        riggybody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        acceleration = Input.GetAxis("Vertical");
        steering = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate() 
    {
        riggybody.AddTorque(steering * -steering_speed * Time.deltaTime);
        Vector2 force = transform.up * acceleration * forward_speed * Time.deltaTime;
        if(riggybody.velocity.magnitude < maxSpeed) 
        {
        riggybody.AddForce(force);
        }
    }
}
