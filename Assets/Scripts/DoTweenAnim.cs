using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class DoTweenAnim : MonoBehaviour
{
    // Start is called before the first frame update
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
}
