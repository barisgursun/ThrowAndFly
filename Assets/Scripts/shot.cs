using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    public Rigidbody tops;
    Rigidbody topfizik;
    public float shootpower = 35f;
    public float flypower = 10f;
    public float downpower = 5f;
    public float uppower = 10f;
    float count = 1;

    void Start()
    {
        topfizik = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (Input.touchCount > 0)
        {

            Touch dokunus = Input.GetTouch(0);
            if ((dokunus.phase == TouchPhase.Ended) && (count == 1))
            {

                topfizik.useGravity = true;
                tops.velocity = (transform.forward * shootpower) + (transform.up * uppower);


                count = 2;
            }

            else if (((dokunus.phase == TouchPhase.Stationary) || (dokunus.phase == TouchPhase.Moved)) && (count >= 2))
            {

                topfizik.useGravity = true;
                tops.velocity = (transform.forward * flypower) + Physics.gravity.normalized;
                count += 1;
            }

        }

    }
}
