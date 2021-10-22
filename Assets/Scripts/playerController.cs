using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private float scaleX = 0.5f;
    private float scaleY = 0.5f;
    private float scaleZ = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        //Posición 0,0,0.
        transform.position = Vector3.zero ;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            transform.localScale.x + new Vector3(scaleX, transform.localScale.y, transform.localScale.z);
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            transform.localScale.y + new Vector3(transform.localScale.x, scaleY, transform.localScale.z);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.scale.z + new Vector3(transform.localScale.x, transform.localScale.y, scaleZ);
        }

    }
}
