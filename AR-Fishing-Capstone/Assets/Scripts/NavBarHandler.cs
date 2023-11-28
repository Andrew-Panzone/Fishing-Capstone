using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class NavBarHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void navToInventory()
    {
        SceneManager.LoadScene("Inventory");
    }
    public void navToShop()
    {
        SceneManager.LoadScene("Shop");
    }
    public void navToFishopedia()
    {
        SceneManager.LoadScene("Fishopedia");
    }
    public void navToMap()
    {
        SceneManager.LoadScene("Map");
    }


}
