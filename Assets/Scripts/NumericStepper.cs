using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumericStepper : MonoBehaviour
{
    // Start is called before the first frame update
    TextMeshProUGUI TextMeshProObject;
    public int gridSize = 30;
    const int maxGrid = 35;
    const int minGrid = 25;

    void Start()
    {
        TextMeshProObject = GetComponent<TextMeshProUGUI>();
        TextMeshProObject.text = gridSize.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProObject.text = gridSize.ToString();
    }

    public void Increment()
    {
        if(gridSize <= maxGrid)
        {
            gridSize += 5;
            Debug.Log("Incremented by 5");
        }
    }

    public void Decerement()
    {
        if(gridSize >= minGrid)
        {
            gridSize -= 5;
            Debug.Log("Decremented by 5");
        }
    }
}
