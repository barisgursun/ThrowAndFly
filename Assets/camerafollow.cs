using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{

    GameObject tophareketlimi;
    float kamerabasla = 5f;
    public Transform Target;
    public Transform camTransform;
    public Vector3 Offset;
    public float SmoothTime = 0.3f;
    private Vector3 velocity = Vector3.zero;

    private void Start()
    {
        Offset.z = camTransform.position.z - Target.position.z;
        tophareketlimi = GameObject.FindWithTag("ball");
    }

    private void LateUpdate()
    {
        if (tophareketlimi.transform.position.z > kamerabasla)
        {

            Vector3 targetPosition = Target.position + Offset;
            camTransform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, SmoothTime);
            transform.LookAt(Target);

        }

    }


}
