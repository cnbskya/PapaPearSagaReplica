using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Ball : MonoBehaviour
{
    
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
            DoTweenAnim.localScore = 100;
        }
        // KIRMIZI KAZANA GİRİNCE OLACAKLAR
        else if (other.gameObject.CompareTag("RedHole"))
        {
            Destroy(gameObject);
            DoTweenAnim.localScore = 100;
        }
        // PEMBE KAZANA GİRİNCE OLACAKLAR
        else if (other.gameObject.CompareTag("PinkHole"))
        {
            Destroy(gameObject);
            DoTweenAnim.localScore = 100;
        }
        // TURUNCU KAZANA GİRİNCE OLACAKLAR
        else if (other.gameObject.CompareTag("OrangeHole"))
        {
            Destroy(gameObject);
            DoTweenAnim.localScore = 100;
        }
        // MAVİ KAZANA GİRİNCE OLACAKLAR
        else if (other.gameObject.CompareTag("BlueHole"))
        {
            Destroy(gameObject);
            DoTweenAnim.localScore = 100;
        }
        else if (other.gameObject.CompareTag("Carrot"))
        {
            Destroy(other.gameObject);
            AudioManager.instance.PlayCarrotObstacleSound();
        }
        else if (other.gameObject.CompareTag("Hazelnut"))
        {
            Destroy(other.gameObject);
            AudioManager.instance.PlayHazelObstacleSound();
            
        }else if (other.gameObject.CompareTag("CircleCol"))
        {
            AudioManager.instance.PlayCircleColObstacleSound();
        }
    }
    
    
}
