using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skaterScript : MonoBehaviour
{
    Animator anim;

    Rigidbody rb;

    public float pushForce, steeringAmount, secretSpeed;

    float jumpForce = 0;
    // Start is called before the first frame update
    void Start()
    {
        anim = GameObject.Find(transform.name + "/everyman").GetComponent<Animator>();

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("push", true);
            rb.AddForce(transform.forward * secretSpeed, ForceMode.Force);
        }
        else
        {
            anim.SetBool("push", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("braking", true);
        }
        else
        {
            anim.SetBool("braking", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -3, 0));
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 3, 0));
        }

        if (Input.GetKey(KeyCode.Space))
        {
            jumpForce = jumpForce + 1f;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpForce = 0;
        }
    }



    public void Push()
    {
        rb.AddForce(transform.forward * pushForce, ForceMode.Impulse);
    }
}
