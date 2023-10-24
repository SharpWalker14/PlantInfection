using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour
{
    public Text numberSeeds, numberAdn, buySeedText, buyAnimalText;
    public Currency currency;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShowText();
    }

    void ShowText()
    {
        numberSeeds.text = currency.seeds + "";
        numberAdn.text = currency.adn + "";
        buySeedText.text = "Buy " + "(" + 10 * currency.seedMultiplier + ")";
        buyAnimalText.text = "Buy " + "(" + 100 * currency.animalMultiplier + ")";
    }
}
