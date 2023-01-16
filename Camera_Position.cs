using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Position : MonoBehaviour
{
    public Transform camTarget;
    public float pLerp = .02f;
    public float rLerp = .01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, camTarget.position, pLerp);
        transform.rotation = Quaternion.Lerp(transform.rotation, camTarget.rotation, rLerp);
    }
}
