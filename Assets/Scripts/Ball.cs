using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // YEŞİL KAZANA GİRİNCE OLACAKLAR
        if (other.gameObject.CompareTag("GreenHole"))
        {
            Destroy(gameObject);    
        }
        // KIRMIZI KAZANA GİRİNCE OLACAKLAR
        else if (other.gameObject.CompareTag("RedHole"))
        {
            Destroy(gameObject);
        }
        // PEMBE KAZANA GİRİNCE OLACAKLAR
        else if (other.gameObject.CompareTag("PinkHole"))
        {
            Destroy(gameObject);
        }
        // TURUNCU KAZANA GİRİNCE OLACAKLAR
        else if (other.gameObject.CompareTag("OrangeHole"))
        {
            Destroy(gameObject);
        }
        // MAVİ KAZANA GİRİNCE OLACAKLAR
        else if (other.gameObject.CompareTag("BlueHole"))
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Carrot"))
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Hazelnut"))
        {
            Destroy(other.gameObject);
            // FindObjectOfType<BoilerMovement>().
        }
    }
}
