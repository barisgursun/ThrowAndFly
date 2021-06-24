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
    float birkere = 1;
    // Start is called before the first frame update
    void Start()
    {
        topfizik = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {

            Touch dokunus = Input.GetTouch(0);
            if ((dokunus.phase == TouchPhase.Ended) && (birkere == 1))
            {

                topfizik.useGravity = true;
                tops.velocity = (transform.forward * shootpower) + (transform.up * uppower);
                birkere += 1;
            }
            else if ( ( (dokunus.phase == TouchPhase.Stationary) || (dokunus.phase == TouchPhase.Moved)) && (birkere == 2))
            {
                topfizik.useGravity = true;
                tops.velocity = (transform.forward * flypower) + Physics.gravity.normalized;
            }

        }
    }
}
