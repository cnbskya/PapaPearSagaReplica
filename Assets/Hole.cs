using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (gameObject.CompareTag("BlueHole"))
        {
            AudioManager.instance.PlayBlueHole();
        }else if (gameObject.CompareTag("OrangeHole"))
        {
            AudioManager.instance.PlayOrangeHole();
        }else if (gameObject.CompareTag("PinkHole"))
        {
            AudioManager.instance.PlayPinkHole();
        }else if (gameObject.CompareTag("RedHole"))
        {
            AudioManager.instance.PlayRedHole();
        }else if (gameObject.CompareTag("GreenHole"))
        {
            AudioManager.instance.PlayGreenHole();
        }
    }
}
