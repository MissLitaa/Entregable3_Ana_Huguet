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
       //Escalado +0.5

        if (Input.GetKeyDown(KeyCode.X))
        {
            transform.localScale += new Vector3(scaleX, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            transform.localScale += new Vector3(0, scaleY, 0);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.localScale += new Vector3(0, 0, scaleZ);
        }

    }
}
