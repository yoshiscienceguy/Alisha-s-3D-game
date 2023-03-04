using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public float maxhealth = 100;
    public float currenthealth;
    void Start()
    {
        currenthealth = maxhealth;
    }
    public void takedamage(float damage) 
    {
        currenthealth = currenthealth - damage;
        if (currenthealth <= 0) 
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    { 
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) 
        {
            takedamage(5);
        }
    }
}
