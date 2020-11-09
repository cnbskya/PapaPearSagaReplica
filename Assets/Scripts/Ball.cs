using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Ball : MonoBehaviour
{
    public int localScore = 100;
    public GameObject floatingTextPrefab;
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
            localScore = 100;
        }
        // KIRMIZI KAZANA GİRİNCE OLACAKLAR
        else if (other.gameObject.CompareTag("RedHole"))
        {
            Destroy(gameObject);
            localScore = 100;
        }
        // PEMBE KAZANA GİRİNCE OLACAKLAR
        else if (other.gameObject.CompareTag("PinkHole"))
        {
            Destroy(gameObject);
            localScore = 100;
        }
        // TURUNCU KAZANA GİRİNCE OLACAKLAR
        else if (other.gameObject.CompareTag("OrangeHole"))
        {
            Destroy(gameObject);
            localScore = 100;
        }
        // MAVİ KAZANA GİRİNCE OLACAKLAR
        else if (other.gameObject.CompareTag("BlueHole"))
        {
            Destroy(gameObject);
            localScore = 100;
        }
        else if (other.gameObject.CompareTag("Carrot"))
        {
            Destroy(other.gameObject);
            AudioManager.instance.PlayCarrotObstacleSound();
            UpdateScore();
            ShowFloatingText();
            UIManager.instance.UpdateScore(GameManager.instance.globalScore);
        }
        else if (other.gameObject.CompareTag("Hazelnut"))
        {
            Destroy(other.gameObject);
            AudioManager.instance.PlayHazelObstacleSound();
            UpdateScore();
            ShowFloatingText();
            UIManager.instance.UpdateScore(GameManager.instance.globalScore);
            
        }else if (other.gameObject.CompareTag("CircleCol"))
        {
            AudioManager.instance.PlayCircleColObstacleSound();
        }
    }
    void UpdateScore()
    {
        localScore += 20;
        GameManager.instance.globalScore += localScore;
    }
    void ShowFloatingText()
    {
        GameObject go = Instantiate(floatingTextPrefab, transform.position, Quaternion.identity);
        go.GetComponent<TextMesh>().text = localScore.ToString();
    }
}
