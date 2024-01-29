
using UnityEngine;


public class ShipGibs : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D gib_rigidbody; 
    void Start()
    {
        gib_rigidbody = GetComponent<Rigidbody2D>();
        float randomScale = Random.Range(0.25f, 0.50f); //randomize the size of gibs 
        Vector3 gibScale = new Vector3(randomScale, randomScale, 1); //set the X and Y to our random number and Z to 1
        transform.localScale = gibScale;

        float randomTime = Random.Range(5f, 10f);

        Destroy(gameObject, randomTime); //randomize the time before gibs are destoyed

        float randomX = Random.Range(50f, 100f);
        float randomY = Random.Range(-25f, 25f);

        Vector2 InitalVel = new Vector2(randomX, randomY);

        gib_rigidbody.AddForce(InitalVel); //set some random velcoity // technically not in fixed update but i guess this works, meant to be a single burst of force anyway
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
