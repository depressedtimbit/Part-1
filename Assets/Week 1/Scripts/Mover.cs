using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 3f;
    public float turretSpeed = 7f;
    public Transform turret;
    public GameObject missilePrefab;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        transform.Translate(direction * speed * Time.deltaTime, 0, 0);
        float turretdirection = Input.GetAxis("Vertical");
        turret.Rotate(0, 0, turretdirection * turretSpeed * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.Space))
        {   
            Instantiate(missilePrefab, turret.position, turret.rotation);
        }
    }
}
