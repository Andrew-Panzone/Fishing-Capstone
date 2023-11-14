using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingRod : MonoBehaviour
{
    // Start is called before the first frame update
    public Texture texture;
    public Sprite sprite;
    public string rodName;
    public string id; // rod_tierNumber -> rod_1 for example
    public int cost;
    public int tier;
    public string description;
    public int fishingPower;
    public bool isBought;
    public bool isEquipped;

    public FishingRod(Texture _texture, Sprite _sprite, string _rodName, string _id, int _cost,
                      int _tier, string _description, int _fishingPower, bool _isBought, bool _isEquipped)
    {
        texture = _texture;
        sprite = _sprite;
        rodName = _rodName;
        id = _id;
        cost = _cost;
        tier = _tier;
        description = _description;
        fishingPower = _fishingPower;
        isBought = _isBought;
        isEquipped = _isEquipped;

    }
}
