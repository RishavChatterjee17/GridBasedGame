using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game Exited");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
        Debug.Log("Game Started");
    }
}
