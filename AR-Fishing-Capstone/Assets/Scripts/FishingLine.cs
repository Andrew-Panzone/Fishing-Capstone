using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingLine : MonoBehaviour
{
    // Start is called before the first frame update
    public Texture texture;
    public Sprite sprite;
    public string lineName;
    public string id; // line_tierNumber -> line_1 for example
    public int cost;
    public int tier;
    public string description;
    public int fishingPower;
    public bool isBought;
    public bool isEquipped;

    public FishingLine(Texture _texture, Sprite _sprite, string _lineName, string _id, int _cost,
                      int _tier, string _description, int _fishingPower, bool _isBought, bool _isEquipped)
    {
        texture = _texture;
        sprite = _sprite;
        lineName = _lineName;
        id = _id;
        cost = _cost;
        tier = _tier;
        description = _description;
        fishingPower = _fishingPower;
        isBought = _isBought;
        isEquipped = _isEquipped;

    }
}
