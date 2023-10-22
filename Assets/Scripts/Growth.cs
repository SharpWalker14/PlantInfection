using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Growth : MonoBehaviour
{
    public int seeds;
    public GameObject seedObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlantProcess();
    }

    void PlantProcess()
    {
        if (Input.GetMouseButtonDown(0) && seeds > 0) 
        {
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 plantLocate = new Vector2(worldPoint.x, worldPoint.y);
            Debug.Log(plantLocate);
            seedObject.transform.position = plantLocate;
            Instantiate(seedObject);
            seeds--;
        }

    }
}
