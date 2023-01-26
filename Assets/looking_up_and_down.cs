using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class looking_up_and_down : MonoBehaviour
{
    public float rotationspeed = 90; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Mouse Y");
        Vector3 rotation = new Vector3(-h, 0, 0)*rotationspeed;
        transform.Rotate(rotation * Time.deltaTime);
    }
}
