using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class fishElement : MonoBehaviour
{

    public string f_id;
    public RawImage image;
    public TextMeshProUGUI fishName;

    private Fish fish;
    
    // Start is called before the first frame update
    void Start()
    {
        //load the fishObj
        Fish fish = PlayerInventory.fishDict[f_id];
        Debug.Log(f_id);
        if (fish.discovered == Discovered.CAUGHT)
        {
            Debug.Log(f_id + " discover type is: Caught!");
            fishName.text = fish.fishName;
            image.texture = fish.textureCaught;
            image.color = Color.white;
        } else
        {
            fishName.text = "???";

            //set image based on discover
            if (fish.discovered == Discovered.SEEN)
            {
                Debug.Log(f_id + " discover type is: Seen!");
                image.texture = fish.textureSeen;
                image.color = Color.white;
            } else
            {
                Debug.Log(f_id + " discover type is: UNSeen");
                image.color = Color.black; // make it unknown
            }
        }
    }
}
