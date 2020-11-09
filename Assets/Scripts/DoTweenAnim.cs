using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;
using UnityEngine.UI;

public class DoTweenAnim : MonoBehaviour
{
    public static int localScore = 100;
    public GameObject floatingTextPrefab;
    void Start()
    {
        StartTweenAnimation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void StartTweenAnimation()
    {
        if (gameObject.CompareTag("Hazelnut"))
        {
            transform.localScale = Vector3.zero;
            transform.DOScale(new Vector3(0.6f, 0.6f, 0.6f), UnityEngine.Random.Range(0f, 1f)).SetDelay(UnityEngine.Random.Range(0f, 1f));
        }
        else if (gameObject.CompareTag("Carrot"))
        {
            transform.localScale = Vector3.zero;
            transform.DOScale(new Vector3(1f, 1f, 1f), UnityEngine.Random.Range(0f, 0.5f)).SetDelay(UnityEngine.Random.Range(0f, .5f));
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            UpdateScore();
            ShowFloatingText();
            UIManager.instance.UpdateScore(GameManager.instance.globalScore);
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
