using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody rb;

    public float force = 5.0f;
    public float acceleration = 10.0f;

    [SerializeField] private AudioSource audio;
    private bool isGround = false;


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
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("coin"))
        {
            Destroy(col.gameObject);
            audio.Play();
        }
        if (col.gameObject.CompareTag("cube"))
        {
            isGround = true;
        }
    }
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
        if (isGround)
        {
            Time.timeScale = 0;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                Time.timeScale = 1;
            }
        }
    }
 }
