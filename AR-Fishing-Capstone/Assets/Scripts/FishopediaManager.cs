using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishopediaManager : MonoBehaviour
{
    public bool clearPrefs;

    public GameObject fishDetail;
    // Start is called before the first frame update
    void Start()
    {
        if (clearPrefs)
        {
            PlayerPrefs.DeleteAll();
        }
    }


    public void openFishPopup(string id)
    {
        Fish fish = PlayerInventory.fishDict[id];
        if (fish.discovered == Discovered.CAUGHT)
        {
            openFishDetail(fish);
        }
    }

    private void openFishDetail(Fish fish)
    {
        fishDetail.GetComponent<FishDetailPopup>().fishImage.texture = fish.textureCaught;
        fishDetail.GetComponent<FishDetailPopup>().fishName.text = "Name: " + fish.fishName;
        fishDetail.GetComponent<FishDetailPopup>().description.text = "Description: " + fish.description;
        fishDetail.GetComponent<FishDetailPopup>().weight.text = "Weight: " + fish.weight.ToString() + "lbs";
        fishDetail.GetComponent<FishDetailPopup>().tier.text = "Tier: " + fish.tier.ToString();
        fishDetail.SetActive(true);
    }

    public void closeFishDetail()
    {
        fishDetail.SetActive(false);
    }
}
