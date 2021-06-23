using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterKontrol : MonoBehaviour
{
    Animator kontrol;
    // Start is called before the first frame update
    void Start()
    {
        kontrol = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch dokunus = Input.GetTouch(0);
            if ((dokunus.phase == TouchPhase.Stationary) || (dokunus.phase == TouchPhase.Moved))
            {
                kontrol.SetBool("kanadiAcmayaBasla",true);
                kontrol.SetBool("kanadiKapamayaBasla", false);
            }

            else if ((dokunus.phase == TouchPhase.Ended))
            {
                kontrol.SetBool("kanadiAcmayaBasla", false);
                kontrol.SetBool("kanadiKapamayaBasla",true);
            }

       
        }

    }
}

