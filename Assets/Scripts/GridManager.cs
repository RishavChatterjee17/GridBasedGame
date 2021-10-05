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
    public LineRenderer newLine;
    Vector2 firstClick;
    bool firstTouch = true;
    bool secTouch,thirdTouch,fourthTouch,fifthTouch = false;
    bool sixTouch,sevenTouch,eightTouch,nineTouch = false;
    Vector2 currentPos, nextPos, nextPos1, nextPos2,nextPos3 ,nextPos4, nextPos5, nextPos6, nextPos7;

    void Awake() 
    {
       
    }

    void Start()
    {
        nstp = new NumericStepper();
        newLine = GetComponent<LineRenderer>();

        newLine.startWidth = .1f;
        newLine.endWidth = .1f;
        newLine.startColor = Color.black;
        newLine.endColor = Color.black;
        newLine.positionCount = 2;
        newLine.useWorldSpace = true;    
    }

    // Update is called once per frame
    void Update()
    {
        gridSize = nstp.gridSize;

        if (Input.GetKeyDown(KeyCode.Mouse0) && withinBoundary)
        {      
            Vector3 gridPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);

            Vector3 adjust = new Vector3(Mathf.Round(gridPoint.x/2.5f)*1.5f, Mathf.Round(gridPoint.y), Mathf.Round(redDot.transform.position.z));

            SpawnDot(adjust);     
            DrawLinesOnDots(); 
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
        if (firstTouch)
        {
            firstClick = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);
            currentPos = new Vector2(Mathf.Round(firstClick.x/2.5f)*1.5f, Mathf.Round(firstClick.y));
            firstTouch = false;
            secTouch = true;
        }
        else if (secTouch)
        {
            Vector2 secondClick = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);
            nextPos = new Vector2(Mathf.Round(secondClick.x/2.5f)*1.5f, Mathf.Round(secondClick.y));

            newLine.SetPosition(0, currentPos);
            newLine.SetPosition(1, nextPos);

            newLine.positionCount = 3;

            secTouch = false;
            thirdTouch = true;
            
        }
        else if (thirdTouch)
        {
            Vector2 thirdClick = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);
            nextPos1 = new Vector2(Mathf.Round(thirdClick.x/2.5f)*1.5f, Mathf.Round(thirdClick.y));

            newLine.SetPosition(0, currentPos);
            newLine.SetPosition(1, nextPos);
            newLine.SetPosition(2, nextPos1);

            newLine.positionCount = 4;

            thirdTouch = false;
            fourthTouch = true;
        }
        else if (fourthTouch)
        {
            Vector2 thirdClick = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);
            nextPos2 = new Vector2(Mathf.Round(thirdClick.x/2.5f)*1.5f, Mathf.Round(thirdClick.y));

            newLine.SetPosition(0, currentPos);
            newLine.SetPosition(1, nextPos);
            newLine.SetPosition(2, nextPos1);
            newLine.SetPosition(3, nextPos2);

            newLine.positionCount = 5;

            fourthTouch = false;
            fifthTouch = true;
        }
        else if (fifthTouch)
        {
            Vector2 thirdClick = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);
            nextPos3 = new Vector2(Mathf.Round(thirdClick.x/2.5f)*1.5f, Mathf.Round(thirdClick.y));

            newLine.SetPosition(0, currentPos);
            newLine.SetPosition(1, nextPos);
            newLine.SetPosition(2, nextPos1);
            newLine.SetPosition(3, nextPos2);
            newLine.SetPosition(4, nextPos3);

            newLine.positionCount = 6;

            fifthTouch = false;
            sixTouch = true;
        }
        else if (sixTouch)
        {
            Vector2 thirdClick = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);
            nextPos4 = new Vector2(Mathf.Round(thirdClick.x/2.5f)*1.5f, Mathf.Round(thirdClick.y));

            newLine.SetPosition(0, currentPos);
            newLine.SetPosition(1, nextPos);
            newLine.SetPosition(2, nextPos1);
            newLine.SetPosition(3, nextPos2);
            newLine.SetPosition(4, nextPos3);
            newLine.SetPosition(5, nextPos4);

            newLine.positionCount = 7;

            sixTouch = false;
            sevenTouch = true;
        }
        else if (sevenTouch)
        {
            Vector2 thirdClick = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);
            nextPos5 = new Vector2(Mathf.Round(thirdClick.x/2.5f)*1.5f, Mathf.Round(thirdClick.y));

            newLine.SetPosition(0, currentPos);
            newLine.SetPosition(1, nextPos);
            newLine.SetPosition(2, nextPos1);
            newLine.SetPosition(3, nextPos2);
            newLine.SetPosition(4, nextPos3);
            newLine.SetPosition(5, nextPos4);
            newLine.SetPosition(6, nextPos5);

            newLine.positionCount = 8;

            sevenTouch = false;
            eightTouch = true;
        }
        else if (eightTouch)
        {
            Vector2 thirdClick = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);
            nextPos6 = new Vector2(Mathf.Round(thirdClick.x/2.5f)*1.5f, Mathf.Round(thirdClick.y));

            newLine.SetPosition(0, currentPos);
            newLine.SetPosition(1, nextPos);
            newLine.SetPosition(2, nextPos1);
            newLine.SetPosition(3, nextPos2);
            newLine.SetPosition(4, nextPos3);
            newLine.SetPosition(5, nextPos4);
            newLine.SetPosition(6, nextPos5);
            newLine.SetPosition(7, nextPos6);

            newLine.positionCount = 9;

            eightTouch = false;
            nineTouch = true;
        }
        else if (nineTouch)
        {
            Vector2 thirdClick = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);
            nextPos7 = new Vector2(Mathf.Round(thirdClick.x/2.5f)*1.5f, Mathf.Round(thirdClick.y));

            newLine.SetPosition(0, currentPos);
            newLine.SetPosition(1, nextPos);
            newLine.SetPosition(2, nextPos1);
            newLine.SetPosition(3, nextPos2);
            newLine.SetPosition(4, nextPos3);
            newLine.SetPosition(5, nextPos4);
            newLine.SetPosition(6, nextPos5);
            newLine.SetPosition(7, nextPos6);
            newLine.SetPosition(8, nextPos7);

            newLine.positionCount = 10;

            nineTouch = false;
        }
    }
}
