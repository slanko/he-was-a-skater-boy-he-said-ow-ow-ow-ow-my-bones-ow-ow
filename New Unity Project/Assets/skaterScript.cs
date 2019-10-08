using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skaterScript : MonoBehaviour
{
    Animator anim;

    Rigidbody rb;

    public float pushForce;
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
    }



    public void Push()
    {
        rb.AddForce(transform.forward * pushForce, ForceMode.Impulse);
    }
}
