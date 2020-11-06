using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Trejectory : MonoBehaviour
{
    
    [SerializeField] int dotsNumber;
    [SerializeField] GameObject dotsParent;
    [SerializeField] GameObject dotPrefab;
    [SerializeField] float dotSpacing;
    private float timeStamp;

    private Transform[] dotsList;

    private Vector2 pos;
    // Start is called before the first frame update
    void Start()
    {
        Hide();
        PrepareDots();
    }

    void PrepareDots()
    {
        dotsList = new Transform[dotsNumber];

        for (int i = 0; i < dotsNumber; i++)
        {
            dotsList[i] = Instantiate(dotPrefab, null).transform;
            dotsList[i].parent = dotsParent.transform;
        }
    }

    public void UpdateDots(Vector3 ballPoss, Vector2 InitialVelocity)
    {
        timeStamp = dotSpacing;
        for (int i = 0; i < dotsNumber; i++)
        {
            pos.x = (ballPoss.x + InitialVelocity.x * timeStamp);
            pos.y = (ballPoss.y + InitialVelocity.y * timeStamp) -(Physics2D.gravity.magnitude * timeStamp *timeStamp) / 2f;
            
            dotsList[i].position = pos;
            timeStamp += dotSpacing;
        }
    }

    public void Show()
    {
        dotsParent.SetActive(true);
    }
    
    public void Hide()
    {
        dotsParent.SetActive(false);
    }
}
