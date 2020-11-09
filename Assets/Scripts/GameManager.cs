using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int globalScore;
    public BoilerMovement boilerMovement;
    public static GameManager instance;
    public bool isGameOn;
    public Trejectory trejectory;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        instance = this;
    }

    public void OnDrag()
    {
        trejectory.UpdateDots(boilerMovement.pos, boilerMovement.force);
    }

    public void OnDragStart()
    {
        trejectory.Show();
    }

    public void OnDragEnd()
    {
        trejectory.Hide();
    }

    
    
}
