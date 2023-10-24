using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedGrowth : MonoBehaviour
{
    public float maxTime, frecuency, minDistance, maxDistance;
    public float maxTimeModifier;
    private float timer;
    public GameObject seedObject;
    public GameObject rotator, locater;
    public Currency currency;
    public PlantCounter planter;
    // Start is called before the first frame update
    void Start()
    {
        currency = FindObjectOfType<Currency>();
        planter = FindObjectOfType<PlantCounter>();
        planter.Counting();
    }

    // Update is called once per frame
    void Update()
    {
        PlantGrow();
    }

    void PlantGrow()
    {
        GameObject[] animalCount = GameObject.FindGameObjectsWithTag("Animal");
        maxTimeModifier = 0.5f * animalCount.Length;
        timer += Time.deltaTime * frecuency;
        if (timer >= maxTime - maxTimeModifier)
        {
            timer -= maxTime;
            float localDistance;
            float angleThrow;
            localDistance = Random.Range(minDistance, maxDistance);
            angleThrow = Random.Range(0f, 360f);
            rotator.transform.localEulerAngles = new Vector3(0, 0, angleThrow);
            locater.transform.localPosition = new Vector2(0, localDistance);
            seedObject.transform.position = locater.transform.position;
            currency.adn++;
            Instantiate(seedObject);
        }
    }

}
