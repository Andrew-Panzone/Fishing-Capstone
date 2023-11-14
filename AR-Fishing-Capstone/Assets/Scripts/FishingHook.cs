using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingHook : MonoBehaviour
{
    public Texture texture;
    public Sprite sprite;
    public string hookName;
    public string id; // hook_tierNumber -> hook_1 for example
    public int cost;
    public int tier;
    public string description;
    public int fishingPower;
    public bool isBought;
    public bool isEquipped;

    public FishingHook(Texture _texture, Sprite _sprite, string _hookName, string _id, int _cost,
                      int _tier, string _description, int _fishingPower, bool _isBought, bool _isEquipped)
    {
        texture = _texture;
        sprite = _sprite;
        hookName = _hookName;
        id = _id;
        cost = _cost;
        tier = _tier;
        description = _description;
        fishingPower = _fishingPower;
        isBought = _isBought;
        isEquipped = _isEquipped;

    }
}
