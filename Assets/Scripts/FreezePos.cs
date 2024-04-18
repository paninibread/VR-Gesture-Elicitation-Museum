using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezePos : MonoBehaviour
{
    Vector3 defaultPos;
    Quaternion defaultRot;
    void Awake()
    {
        defaultPos = transform.position;
        defaultRot = transform.rotation;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = defaultPos;

        //StartCoroutine(fixRotation());

        transform.rotation = Quaternion.Euler(0, transform.eulerAngles.y, 0);

        //transform.rotation = new Quaternion (defaultRot.x, transform.rotation.y, defaultRot.z, defaultRot.w);
    }

    IEnumerator fixRotation()
    {
        //transform.rotation = new Quaternion(defaultRot.x, transform.rotation.y, defaultRot.z, defaultRot.w);

        transform.rotation = Quaternion.Euler(0, transform.eulerAngles.y, 0);

        yield return new WaitForSeconds(3f);
    }
}
