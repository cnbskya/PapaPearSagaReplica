using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("BigCloud"))
        {
            if (transform.position.x <= -11.5f)
            {
                gameObject.transform.position = new Vector3(12.5f, transform.position.y, gameObject.transform.position.z);
            }

            transform.Translate(-0.8f * Time.deltaTime, 0, 0);
        }

        if (gameObject.CompareTag("SmallCloud"))
        {
            if (transform.position.x <= -11.5f)
            {
                gameObject.transform.position = new Vector3(12.5f, transform.position.y, gameObject.transform.position.z);
            }

            transform.Translate(-0.3f * Time.deltaTime, 0, 0);
        }
    }
}