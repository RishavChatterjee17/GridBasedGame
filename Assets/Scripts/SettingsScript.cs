using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SettingsScript : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animatorController;
    bool settingstoggle;

    void Awake() 
    {
        animatorController = GetComponent<Animator>();
    }

    void Start()
    {
        animatorController.SetBool("IsSetActive?", false);
        settingstoggle = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Settings()
    {
        if(settingstoggle == false)
        {
            settingstoggle = true;
            animatorController.SetBool("IsSetActive?", true);
            Debug.Log("Settings Toggle ON has been detected");
        }
    }

    public void Close()
    {
        if (settingstoggle == true)
        {
            animatorController.SetBool("IsSetActive?", false);
            settingstoggle = false;
            Debug.Log("Settings Toggle OFF has been detected");
        }
    }
}
