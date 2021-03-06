using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterKontrol : MonoBehaviour
{
    public Animator kontrol;
    public Vector3 topkonum;
    Rigidbody topfizik;
    Vector3 rotatetop = new Vector3(0f, 0f, 1000f);
    Vector3 toprot = new Vector3(90f, 0f, 0f);
    Vector3 basiliyken = new Vector3(45.0f, 0f, 0.0f);
    Transform yol1;
    Transform yol2;

   

    // Start is called before the first frame update
    void Start()
    {
        kontrol = GetComponent<Animator>();
        topkonum = gameObject.transform.position;
        topfizik = GetComponent<Rigidbody>();
        yol1 = GameObject.Find("yol1").transform;
        yol2 = GameObject.Find("yol2").transform;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name =="yol1")
        {
            yol2.position = new Vector3(yol2.position.x, yol2.position.y, yol1.position.z + 90f);
        }
        if(other.gameObject.name == "yol2")
        {
            yol1.position = new Vector3(yol1.position.x, yol1.position.y, yol2.position.z + 90f);
        }
    }


    // Update is called once per frame
    void Update()
    {

        if ((Input.touchCount > 0) && (topkonum != gameObject.transform.position))
        {

            Touch dokunus = Input.GetTouch(0);
            if ((dokunus.phase == TouchPhase.Stationary) || (dokunus.phase == TouchPhase.Moved))
            {

                topfizik.useGravity = true;
                kontrol.SetBool("kanadiAcmayaBasla", true);
                kontrol.SetBool("kanadiKapamayaBasla", false);
                //   GameObject.FindGameObjectWithTag("ball").GetComponent<Transform>().transform.rotation =   Quaternion.Euler (45f, transform.rotation.y, 0f);
                //   topfizik.rotation = Quaternion.Euler(45f, transform.rotation.y, 0f);
                //   GameObject.FindGameObjectWithTag("ball").transform.Translate(Vector3.forward * 50 * Time.deltaTime);
                //  topfizik.velocity = (transform.forward * 10f) + Physics.gravity.normalized;
                //  go.transform.position = new Vector3(x, y, z);
                //  x = transform.localEulerAngles.x;
              //  Quaternion toRot = Quaternion.LookRotation(gameObject.transform.position, Vector3.up);
               // transform.rotation = Quaternion.RotateTowards(transform.rotation, toRot, 3f * Time.deltaTime);

                //  topfizik.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;


            }

            else if ((dokunus.phase == TouchPhase.Ended))
            {

                kontrol.SetBool("kanadiAcmayaBasla", false);
                kontrol.SetBool("kanadiKapamayaBasla", true);

            }


        }
        else if ((Input.touchCount == 0) && (topkonum != gameObject.transform.position))
        {

    
            transform.Rotate(rotatetop * Time.deltaTime);
        }

    }
}

