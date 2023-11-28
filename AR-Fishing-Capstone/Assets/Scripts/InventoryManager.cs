using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryManager : MonoBehaviour
{

    TextMeshProUGUI fishingPowerText;

    // Start is called before the first frame update
    void Start()
    {
        updateFishingPowerText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onClickEquip()
    {

    }


    void updateFishingPowerText()
    {
        fishingPowerText.text = "FP: " + Player.fishingPower;
    }
}
