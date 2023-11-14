using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int money;
    public static int fishingPower;
    public static FishingRod rod; // current rod equipped
    public static FishingLine line; // current line equipped
    public static FishingHook hook; // current hook equipped

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("money"))
        {
            money = PlayerPrefs.GetInt("money");
        } else
        {
            money = 1000;
            PlayerPrefs.SetInt("money", money);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void saveMoney(int cash)
    {
        PlayerPrefs.SetInt("money", cash);
    }

    public static void saveItemBuy(string id)
    {
        PlayerPrefs.SetString(id + "bought", "true");
    }

    public static void updateFishingPower()
    {
        fishingPower = rod.fishingPower + line.fishingPower + hook.fishingPower;
    }
}
