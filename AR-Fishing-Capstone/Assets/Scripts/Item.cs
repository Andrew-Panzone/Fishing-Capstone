using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    // Start is called before the first frame update
    public string item_id;
    public GameObject soldImage;
    public GameObject buyButton;
    public bool isBought;
    public TextMeshProUGUI moneyText;
    public ItemType type;
    void Start()
    {
        string boughtId = item_id + "bought";
        if (PlayerPrefs.HasKey(boughtId) || isBought)
        {
            //set the item to purchased
            soldImage.SetActive(true);
            buyButton.SetActive(false);
            Player.saveItemBuy(item_id);
        } else
        {
            soldImage.SetActive(false);
            buyButton.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void buyItem(int cost) 
    {
        Debug.Log(Player.money - cost);
        if (Player.money - cost < 0)
        {
            return;
        } else
        {

            if (type == ItemType.ROD)
            {
                Debug.Log(item_id);
                if (PlayerInventory.rodDict.ContainsKey(item_id))
                {
                    Debug.Log("it contains key!");
                }
                FishingRod rod =  PlayerInventory.rodDict[item_id];
                rod.isBought = true;

            }
            else if (type == ItemType.HOOK)
            {
                FishingHook hook = PlayerInventory.hookDict[item_id];
                hook.isBought = true;
            }
            else if (type == ItemType.LINE)
            {
                FishingLine line = PlayerInventory.lineDict[item_id];
                line.isBought = true;
            }

            soldImage.SetActive(true);
            buyButton.SetActive(false);
            isBought = true;

            Player.saveItemBuy(item_id);
            Player.money -= cost;
            Player.saveMoney(Player.money);
            moneyText.text = "Money: " + Player.money;
        }
    }

}

public enum ItemType
{
    ROD,
    LINE,
    HOOK
}
