using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickKontrol : MonoBehaviour
{
    private karakterKontrol tophareketlimi;
    public Animator cubukKontrol;
    private Vector3 top;
    Rigidbody topfizik;
   // Transform egikmi;
   

    // Start is called before the first frame update
    void Start()
    {
        tophareketlimi = GameObject.FindWithTag("ball").GetComponent<karakterKontrol>();
        cubukKontrol = GetComponent<Animator>();
        top = tophareketlimi.gameObject.transform.position;
        topfizik = tophareketlimi.GetComponent<Rigidbody>();
       // egikmi = GameObject.FindWithTag("egik").GetComponent<Transform>();
        

    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.touchCount > 0) && (top == tophareketlimi.gameObject.transform.position))
        {

            Touch dokunus = Input.GetTouch(0);
            if ((dokunus.phase == TouchPhase.Stationary) || (dokunus.phase == TouchPhase.Moved))
            {
               // tophareketlimi.GetComponent < Transform >().rotation = egikmi.rotation;
                topfizik.useGravity = false;
                cubukKontrol.SetBool("cekmeyeBasla", true);
                cubukKontrol.SetBool("cekmeyiBirak", false);
            }

            else if ((dokunus.phase == TouchPhase.Ended))
            {
                cubukKontrol.SetBool("cekmeyeBasla", false);
                cubukKontrol.SetBool("cekmeyiBirak", true);
            }


        }
    }
}
