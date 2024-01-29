using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingSpawner : MonoBehaviour
{
    public GameObject player;
    public GameObject copyPrefab;

    public float distance;
    // Start is called before the first frame update

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < player.transform.position.x - distance)
        {
            Instantiate(copyPrefab, new Vector3(transform.position.x + (distance*2), transform.position.y, 1), transform.rotation);
            Destroy(gameObject);
        }
    }
}
