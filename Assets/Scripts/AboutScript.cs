using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutScript : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animatorController;
    bool abouttoggle;

    void Awake() 
    {
        animatorController = GetComponent<Animator>();
    }

    void Start()
    {
        abouttoggle = false;
        animatorController.SetBool("IsAboutActive?", false);
    }

    // Update is called once per frame
    void Update()
    {
        CheckAbtToggle();
    }

    public void About()
    {
        if(abouttoggle == false)
        {
            abouttoggle = true;
            animatorController.SetBool("IsAboutActive?", true);
            Debug.Log("About Toggle ON has been detected");
        }
    }

    public void CheckAbtToggle()
    {
        if (abouttoggle == true && Input.anyKey)
        {
            animatorController.SetBool("IsAboutActive?", false);
            abouttoggle = false;
            Debug.Log("About Toggle OFF has been detected");
        }
    }
}
