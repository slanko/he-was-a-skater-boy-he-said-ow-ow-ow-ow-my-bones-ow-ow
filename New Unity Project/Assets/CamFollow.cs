using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public GameObject followTarget;
    public float lerpSpeed;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, followTarget.transform.position.x, lerpSpeed * Time.deltaTime), Mathf.Lerp(transform.position.y, followTarget.transform.position.y, lerpSpeed * Time.deltaTime), Mathf.Lerp(transform.position.z, followTarget.transform.position.z, lerpSpeed * Time.deltaTime));
    }
}
