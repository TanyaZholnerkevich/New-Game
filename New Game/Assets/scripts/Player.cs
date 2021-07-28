using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody rb;

    public float force = 5.0f;
    public float acceleration = 10.0f;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * force , ForceMode.Impulse);
        }
    }
    /*private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("cube"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }*/
    private void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.forward*acceleration);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-Vector3.forward* acceleration);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.left* acceleration);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(Vector3.right* acceleration);
        }
    }
 }
