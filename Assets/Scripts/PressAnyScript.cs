using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressAnyScript : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject buttonComponent;
    GameObject pressKey;

    void Start()
    {
        buttonComponent = GameObject.FindGameObjectWithTag("ButtonComponent");
        pressKey = GameObject.FindGameObjectWithTag("PressKey");
        buttonComponent.SetActive(false);
        pressKey.SetActive(true);
        Debug.Log("Hidden");
    }

    void Update() 
    {
        if (Input.anyKey)
        {
            buttonComponent.SetActive(true);
            pressKey.SetActive(false);
            Debug.Log("A key or mouse click has been detected");
        }
    }
}
