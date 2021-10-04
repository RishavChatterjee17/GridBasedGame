﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackGame()
    {
        SceneManager.LoadScene("MenuScene");
        Debug.Log("Back Pressed");
    }

    public void ResetGame()
    {

        Debug.Log("Reset Pressed");
    }

    public void FillBoard()
    {
 
        Debug.Log("Fill Pressed");
    }
}