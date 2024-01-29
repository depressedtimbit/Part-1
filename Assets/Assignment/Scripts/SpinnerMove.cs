using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerMove : MonoBehaviour
{
    public float speedMin = 5;
    public float speedMax = 50;
    float speed;
    Rigidbody2D spinner_rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(speedMin, speedMax);
        spinner_rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        spinner_rigidbody.MoveRotation(spinner_rigidbody.rotation + speed * Time.deltaTime);
    }

}
