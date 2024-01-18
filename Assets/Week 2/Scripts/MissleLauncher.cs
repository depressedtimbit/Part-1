using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform spawnPoint;
    public GameObject missilePrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D() 
    {
        Instantiate(missilePrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
