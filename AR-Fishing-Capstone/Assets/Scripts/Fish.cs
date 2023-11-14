using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public Texture textureCaught;
    public Sprite spriteCaught;
    public Texture textureSeen;
    public Sprite spriteSeen;
    public string fishName;
    public string id; // naming convention do f_someNumber
    public string description;
    public int tier;
    public int weight;
    public int fp; // used to determine difficulty -> fishing power recommended;
    public float encounterRate;
    public Discovered discovered;
    public readonly static float errorEncounterRate = -1f;

    // Start is called before the first frame update
    public Fish(Texture _textureCaught, Sprite _spriteCaught, Texture _textureSeen, Sprite _spriteSeen, string _fishName, string _id,
        string _description, int _tier, int _weight, int _fp, float _encounterRate, Discovered _discovered)
    {
        textureCaught = _textureCaught;
        spriteCaught = _spriteCaught;
        textureSeen = _textureSeen;
        spriteSeen = _spriteSeen;
        fishName = _fishName;
        id = _id;
        description = _description;
        tier = _tier;
        weight = _weight;
        fp = _fp;
        encounterRate = _encounterRate;
        discovered = _discovered;
    }

   
    void Start()
    {
        
    }

    public static void setEncounterRate(string id, float encounterRate)
    {
        PlayerPrefs.SetFloat(id, encounterRate);
    }

    public static Discovered getSavedFishDiscovery(string f_id)
    {
        string type = PlayerPrefs.GetString(f_id + "discover");
        if (type == "caught")
        {
            return Discovered.CAUGHT;
        }
        else if (type == "seen")
        {
            return Discovered.SEEN;
        }
        else
        {
            return Discovered.UNSEEN;
        }
    }

    public static float getEncounterRate(string f_id)
    {
        if (PlayerPrefs.HasKey(f_id + "encounter")) {
            return PlayerPrefs.GetFloat(f_id + "encounter");
        }
        else
        {
            return -1f;
        }
    }

    public static void saveDiscovery(string f_id, string type)
    {
        PlayerPrefs.SetString(f_id + "discover", type);
    }

    public static void saveEncounterRate(string f_id, float rate)
    {
        PlayerPrefs.GetFloat(f_id + "encounter", rate);
    }
}



public enum Discovered
{
    SEEN,
    UNSEEN,
    CAUGHT
}