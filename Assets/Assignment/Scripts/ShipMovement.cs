using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    float steering;
    public float steering_speed = 50;
    public float speed = 100;

    public GameObject gibPrefab;
    Rigidbody2D ship_rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        ship_rigidbody = GetComponent<Rigidbody2D>();
    }

       // Update is called once per frame
    void Update() 
    {
        steering = Input.GetAxis("Vertical");
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        Instantiate(gibPrefab, transform.position, transform.rotation);
        Instantiate(gibPrefab, transform.position, transform.rotation); //spawn 3 gibs
        Instantiate(gibPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }

 
    private void FixedUpdate()
    {
        Vector2 force = transform.right * speed * Time.deltaTime;
        ship_rigidbody.AddForce(force);

        ship_rigidbody.AddTorque(steering * steering_speed * Time.deltaTime);
        
        if(ship_rigidbody.rotation < -40) //if rotation is less than -40 in Z, set it to -40
        {
            ship_rigidbody.MoveRotation(-40);
            ship_rigidbody.angularVelocity = 0; //reset angular Velocity (), rigid body seems to still try and move even if it set rotation, behaves nicely with this
        }
        if(ship_rigidbody.rotation > 40) // do the same for postive values
        {
            ship_rigidbody.MoveRotation(40);
            ship_rigidbody.angularVelocity = 0;
        }
    }
}
