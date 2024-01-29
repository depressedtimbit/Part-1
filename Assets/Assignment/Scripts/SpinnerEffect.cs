using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerEffect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      private void OnTriggerEnter2D(Collider2D collider) 
    {
        Debug.Log("enter radius");
        collider.GetComponent<ShipMovement>().speed = 2000;
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        collider.GetComponent<ShipMovement>().speed = 1000;
    }
}
