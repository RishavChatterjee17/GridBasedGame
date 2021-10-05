using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public AudioClip valvesfx;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource> ();
        DontDestroyOnLoad(transform.gameObject);
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
