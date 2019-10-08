using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animHelper : MonoBehaviour
{
    skaterScript skSc;

    private void Start()
    {
        skSc = GameObject.Find("skater").GetComponent<skaterScript>();
    }

    public void push()
    {
        skSc.Push();
    }

}
