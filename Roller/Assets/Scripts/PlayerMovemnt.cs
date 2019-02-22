using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemnt : MonoBehaviour
{

    public Rigidbody rb;
  
    void Start()
    {

        rb.GetComponent<Rigidbody>();

    }

    
    void Update()
    {

        rb.velocity = new Vector3(0, 0, 12);

        if (Input.GetButtonDown("D"))
        {
            rb.velocity = new Vector3(7, 0, 0);

        }



    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemie")
            Destroy(gameObject);

    }


}
