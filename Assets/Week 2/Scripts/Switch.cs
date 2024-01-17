using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Switch : MonoBehaviour
{
    // Start is called before the first frame update

    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
    private void OnTriggerEnter2D(Collider2D collider) 
    {
        Debug.Log("switch enter");
        spriteRenderer.color = Color.red;
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        spriteRenderer.color = Color.white;
        
    }
}
