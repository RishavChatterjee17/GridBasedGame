using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GridManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int gridSize;
    NumericStepper nstp;
    public GameObject redDot;
    bool withinBoundary = false;

    void Awake() 
    {
       
    }

    void Start()
    {
        nstp = new NumericStepper();
    }

    // Update is called once per frame
    void Update()
    {
        gridSize = nstp.gridSize;

        Debug.Log(gridSize);

        if (Input.GetKeyDown(KeyCode.Mouse0) && withinBoundary)
        {      
            Vector3 gridPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);

            Vector3 adjust = new Vector3(Mathf.Round(gridPoint.x/2.5f)*1.5f, Mathf.Round(gridPoint.y), Mathf.Round(redDot.transform.position.z));

            SpawnDot(adjust);      
        }

        withinBoundary = false;
    }

    void SpawnDot(Vector3 position)
    {
        Instantiate(redDot).transform.position = position;
    }

    void OnMouseOver() 
    {
        withinBoundary = true;
    }

    void DrawLinesOnDots()
    {
        
    }
}
