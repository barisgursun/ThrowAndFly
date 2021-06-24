using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterKontrol : MonoBehaviour
{
    public Animator kontrol;
    public Vector3 topkonum;
    // Start is called before the first frame update
    void Start()
    {

        kontrol = GetComponent<Animator>();
        topkonum = gameObject.transform.position;
        Debug.Log(topkonum);
    }

    // Update is called once per frame
    void Update()
    {

        if ((Input.touchCount > 0) && (topkonum != gameObject.transform.position))
        {

            Touch dokunus = Input.GetTouch(0);
            if ((dokunus.phase == TouchPhase.Stationary) || (dokunus.phase == TouchPhase.Moved))
            {
                kontrol.SetBool("kanadiAcmayaBasla", true);
                kontrol.SetBool("kanadiKapamayaBasla", false);
            }

            else if ((dokunus.phase == TouchPhase.Ended))
            {
                kontrol.SetBool("kanadiAcmayaBasla", false);
                kontrol.SetBool("kanadiKapamayaBasla", true);
            }


        }

    }
}

