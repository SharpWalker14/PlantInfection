using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedGrowth : MonoBehaviour
{
    public float maxTime, frecuency, minDistance, maxDistance;
    private float timer;
    public GameObject seedObject;
    public GameObject rotator, locater;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlantGrow();
    }

    void PlantGrow()
    {
        timer += Time.deltaTime * frecuency;
        if (timer >= maxTime)
        {
            timer -= maxTime;
            float localDistance;
            float angleThrow;
            localDistance = Random.Range(minDistance, maxDistance);
            angleThrow = Random.Range(0f, 360f);
            rotator.transform.localEulerAngles = new Vector3(0, 0, angleThrow);
            locater.transform.localPosition = new Vector2(0, localDistance);
            seedObject.transform.position = locater.transform.position;
            Instantiate(seedObject);
        }
    }
}
