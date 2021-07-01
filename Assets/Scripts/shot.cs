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
    float donushizi = 2f;
    float count = 1;
    bool sag, sol;
    // -7 ve 10 sag sol

    public GameObject gameOverPnl;

    void Start()
    {
        topfizik = GetComponent<Rigidbody>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "kup")
        {
            topfizik.useGravity = true;
          //  tops.velocity = (transform.up * uppower * 2f);
          topfizik.constraints = RigidbodyConstraints.FreezePositionX;
          
            tops.velocity = (transform.forward * shootpower) + (transform.up * uppower *5);

        }
    

        if (collision.gameObject.tag == "silindir")
        {
            topfizik.useGravity = true;
            topfizik.constraints = RigidbodyConstraints.FreezePositionX;

            tops.velocity = (transform.forward * shootpower) + (transform.up * uppower * 10);
        }
        if(collision.gameObject.tag !="kup" || collision.gameObject.tag !="silindir")
        {
            topfizik.constraints &= ~RigidbodyConstraints.FreezePositionX;
        }

        if(collision.gameObject.tag == "yol")
        {
            gameOverPnl.SetActive(true);
            Time.timeScale = 0.0f;
        }
        
          
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
                if( dokunus.deltaPosition.x >100f)
                {
                    sag = true;
                    sol = false;
                }
                if( dokunus.deltaPosition.x < -100f)
                {
                    sag = false;
                    sol = true;
                }
                if ( sag== true)
                {
                    transform.position = Vector3.Lerp(transform.position, new Vector3(12f,  transform.position.y, transform.position.z),donushizi *Time.deltaTime  );
                }
                if ( sol == true)
                {
                  transform.position = Vector3.Lerp(transform.position, new Vector3(-12f, transform.position.y, transform.position.z), donushizi * Time.deltaTime);
                }


            }

        }

    }
}
