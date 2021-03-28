using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    Rigidbody fizik;
    public int hiz;

    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(yatay, 0, dikey);

        fizik.AddForce(vec*hiz);

        //Debug.Log("yatay = "+ yatay+"   dikey = "+ dikey);
    }

    void OnTriggerEnter(Collider other) //enter,stay,exit
    {
        if (other.gameObject.tag == "engel")
        {
            other.gameObject.SetActive(false);
        }

        
    }
}
