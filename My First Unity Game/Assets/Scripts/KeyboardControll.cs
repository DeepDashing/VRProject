using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardControll : MonoBehaviour
{
    Vector3 originalPos;
    public float speed;
    private Rigidbody rb;
    public GameObject PreFabe;

    void Start()
    {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        //alternatively, just: originalPos = gameObject.transform.position
        originalPos = new Vector3(PreFabe.transform.position.x, PreFabe.transform.position.y, PreFabe.transform.position.z);
        rb = GetComponent<Rigidbody>();
    }
    void Awake()
    {
        PreFabe.GetComponent<KeyboardControll>().enabled = true;
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        //alternatively, just: originalPos = gameObject.transform.position
        originalPos = new Vector3(PreFabe.transform.position.x, PreFabe.transform.position.y, PreFabe.transform.position.z);
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }
    

 
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Goal")
        {
            Destroy(gameObject);
            gameObject.transform.position = originalPos;
            Instantiate(PreFabe, originalPos, Quaternion.Euler(0, 0, 0));
            
        }

    }
}

