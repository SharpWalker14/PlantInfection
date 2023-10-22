using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedPlanted : MonoBehaviour
{
    public GameObject seedBorn;
    // Start is called before the first frame update
    void Awake()
    {
        seedBorn.transform.position = transform.position;
        Instantiate(seedBorn);
        Destroy(gameObject);
    }
}
