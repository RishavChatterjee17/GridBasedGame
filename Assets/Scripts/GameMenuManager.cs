using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuManager : MonoBehaviour
{
    public GridManager gm;
    public AudioClip valvesfx;
    private AudioSource audioSource;

    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
        audioSource = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            audioSource.enabled = true;

            if (!audioSource.isPlaying) {
                audioSource.clip = valvesfx;
                audioSource.Play ();
            }
        }
    }

    public void BackGame()
    {
        SceneManager.LoadScene("MenuScene");
        Debug.Log("Back Pressed");
    }

    public void ResetGame()
    {
        GameObject[] allObjects = GameObject.FindGameObjectsWithTag("Dot");
        foreach(GameObject obj in allObjects) 
        {
            Destroy(obj);
        }

        gm.newLine.positionCount = 0;
        Debug.Log("Reset Pressed");
    }

    public void FillBoard()
    {
 
        Debug.Log("Fill Pressed");
    }
}
