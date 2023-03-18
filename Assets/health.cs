using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public float totalHealth = 100;
    public float currentHealth;
    public Image healthbar;
    // Start is called before the first frame update
    void Start()
    {

        currentHealth = totalHealth;
        healthbar.fillAmount = currentHealth / totalHealth;
    }
    public void TakeDamage(float damage) {
        currentHealth -= damage;
        healthbar.fillAmount = currentHealth / totalHealth;
        if (currentHealth <= 0)
        {
            Destroy(gameObject);    
        }
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("lol2");
        if (collision.gameObject.CompareTag("eNEMY")) {
            Debug.Log("lol");
            TakeDamage(5);
        }
    }
}
