using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantCounter : MonoBehaviour
{
    private GameObject[] plants;
    public int numberPlants;

    public void Counting()
    {
        plants = GameObject.FindGameObjectsWithTag("Plant");
        numberPlants = plants.Length;
    }
}
