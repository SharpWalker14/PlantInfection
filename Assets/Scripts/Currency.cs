using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currency : MonoBehaviour
{
    public int seeds, adn;
    [HideInInspector]
    public int seedMultiplier, animalMultiplier;
    public Growth invent;

    void Start()
    {
        seedMultiplier = 1;
        animalMultiplier = 1;
    }
    public void BuySeed()
    {
        if (adn >= 10 * seedMultiplier)
        {
            seeds++;
            adn -= 10 * seedMultiplier;
            seedMultiplier *= 2;
        }
        else
        {

        }
    }
    public void BuyAnimal()
    {
        if (adn >= 100 * animalMultiplier)
        {
            adn -= 100 * animalMultiplier;
            animalMultiplier *= 2;
            invent.AppearAnimal();
        }
        else
        {

        }
    }
}
