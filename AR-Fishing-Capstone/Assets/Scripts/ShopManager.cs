using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rodPopUp;
    public GameObject hookPopUp;
    public GameObject linePopUp;

    public Button rodButton; // hacky way to show we have button selected when we navigate to shop screen

    public TextMeshProUGUI money;
    public bool clearPrefs;

    void Start()
    {
        if (clearPrefs)
        {
            PlayerPrefs.DeleteAll();
        }
        rodPopUp.SetActive(true);
        rodButton.Select();
        hookPopUp.SetActive(false);
        linePopUp.SetActive(false);
        updateMoneyText();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void generatePurchasedItems()
    {
       
    }

    public void updateMoneyText()
    {

        if (!PlayerPrefs.HasKey("money"))
        {
            Player.money += 1000;
            PlayerPrefs.SetInt("money", Player.money);
        } 
        money.text = "Money: " + Player.money;
    }


    public void onClickRod()
    {
        rodPopUp.SetActive(true);
        hookPopUp.SetActive(false);
        linePopUp.SetActive(false);

    }

    public void onClickHook()
    {
        rodPopUp.SetActive(false);
        hookPopUp.SetActive(true);
        linePopUp.SetActive(false);
    }

    public void onClickLine()
    {
        rodPopUp.SetActive(false);
        hookPopUp.SetActive(false);
        linePopUp.SetActive(true);
    }

}
