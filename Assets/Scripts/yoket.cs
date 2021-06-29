using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yoket : MonoBehaviour
{

    Transform top;
    // Start is called before the first frame update
    void Start()
    {
        top = GameObject.Find("ball").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z + 20f < top.position.z )
        {
            gameObject.SetActive(false);
        }
    }
}
