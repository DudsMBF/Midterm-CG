using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour
{

    public Camera playerCamera;
    public float speed;

    private Rigidbody rb;
    private Vector3 direction = Vector3.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            direction = Vector3.right * speed * Time.deltaTime;
            Debug.Log(direction);
            rb.transform.Translate(direction);
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction = Vector3.left * speed * Time.deltaTime;
            Debug.Log(direction);
            rb.transform.Translate(direction);
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction = Vector3.back * speed * Time.deltaTime;
            Debug.Log(direction);
            rb.transform.Translate(direction);
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction = Vector3.forward * speed * Time.deltaTime;
            Debug.Log(direction);
            rb.transform.Translate(direction);
        }
    }
}
