using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Growth : MonoBehaviour
{
    public GameObject seedObject, animalObject;
    public Pause pauseScript;
    public Currency currency;
    public PlantCounter plantCount;
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
        if (Input.GetMouseButtonDown(0) && currency.seeds > 0 && !pauseScript.paused) 
        {
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 plantLocate = new Vector2(worldPoint.x, worldPoint.y);
            Debug.Log(plantLocate);
            seedObject.transform.position = plantLocate;
            Instantiate(seedObject);
            currency.seeds--;
        }
        if (plantCount.numberPlants >= 300)
        {
            pauseScript.OnVictory();
        }
    }
    public void AppearAnimal()
    {
        Vector2 locationer;
        locationer.x = Random.Range(-9f, 9f);
        locationer.y = Random.Range(-5f, 5f);
        animalObject.transform.position = locationer;
        Instantiate(animalObject);

    }
}
