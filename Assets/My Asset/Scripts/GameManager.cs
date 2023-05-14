using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Data;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [HeaderTextColor(0.2f, 1, 1, headerText = "Bird")]
    public Player_Component Bird;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
