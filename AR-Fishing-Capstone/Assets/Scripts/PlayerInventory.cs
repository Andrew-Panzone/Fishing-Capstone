using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour
{
    // Start is called before the first frame update
    public static Dictionary<string, FishingRod> rodDict;
    public static Dictionary<string, FishingLine> lineDict;
    public static Dictionary<string, FishingHook> hookDict;
    public static Dictionary<string, Fish> fishDict;


    void Start()
    {
        rodDict = new Dictionary<string, FishingRod>();
        lineDict = new Dictionary<string, FishingLine>();
        hookDict = new Dictionary<string, FishingHook>();
        fishDict = new Dictionary<string, Fish>();

        GameObject[] rodObjects = GameObject.FindGameObjectsWithTag("rod");
        GameObject[] lineObjects = GameObject.FindGameObjectsWithTag("line");
        GameObject[] hookObjects = GameObject.FindGameObjectsWithTag("hook");
        GameObject[] fishObjects = GameObject.FindGameObjectsWithTag("fish");

        generateRodDict(rodObjects);
        generateLineDict(lineObjects);
        generateHookDict(hookObjects);
        generateFishDict(fishObjects);

    }

    private void generateFishDict(GameObject[] fishObjects)
    {
        for (int i = 0; i < fishObjects.Length; i++)
        {
            GameObject gameObj = fishObjects[i];

            Texture textureCaught = gameObj.GetComponent<Fish>().textureCaught;
            Sprite spriteCaught = gameObj.GetComponent<Fish>().spriteCaught;
            Texture textureSeen = gameObj.GetComponent<Fish>().textureSeen;
            Sprite spriteSeen = gameObj.GetComponent<Fish>().spriteSeen;
            string fishName = gameObj.GetComponent<Fish>().fishName;
            string id = gameObj.GetComponent<Fish>().id;
            string desc = gameObj.GetComponent<Fish>().description;
            int tier = gameObj.GetComponent<Fish>().tier;
            int weight = gameObj.GetComponent<Fish>().weight;
            int fp = gameObj.GetComponent<Fish>().fp;
            float encounterRate = PlayerPrefs.HasKey(id + "encounter") ? Fish.getEncounterRate(id) : gameObj.GetComponent<Fish>().encounterRate;
            Discovered discovered = PlayerPrefs.HasKey(id + "discover") ? Fish.getSavedFishDiscovery(id) : gameObj.GetComponent<Fish>().discovered;

            Fish fish = new Fish(textureCaught, spriteCaught, textureSeen, spriteSeen, fishName,
                                 id, desc, tier, weight, fp, encounterRate, discovered);
            fishDict.Add(id, fish);
            Debug.Log("fish name: " + fishName);

        }
        Debug.Log("fish dict size: " + fishDict.Keys.Count);
    }


    private void generateRodDict(GameObject[] rodObjects)
    {
        for (int i = 0; i < rodObjects.Length; i++)
        {
            GameObject gameObj = rodObjects[i];
            Texture texture = gameObj.GetComponent<FishingRod>().texture;
            Sprite sprite = gameObj.GetComponent<FishingRod>().sprite;
            string id = gameObj.GetComponent<FishingRod>().id;
            string rodName = gameObj.GetComponent<FishingRod>().rodName;
            int cost = gameObj.GetComponent<FishingRod>().cost;
            int tier = gameObj.GetComponent<FishingRod>().tier;
            string description = gameObj.GetComponent<FishingRod>().description;
            int fishingPower = gameObj.GetComponent<FishingRod>().fishingPower;
            bool isBought = PlayerPrefs.HasKey(id + "bought");
            bool isEquipped = PlayerPrefs.HasKey(id + "equipped");

            FishingRod rod = new FishingRod(texture, sprite, id, rodName, cost, tier, description, fishingPower, isBought, isEquipped);
            rodDict.Add(id, rod);
          
        }

    }

    private void generateLineDict(GameObject[] lineObjects)
    {
        for (int i = 0; i < lineObjects.Length; i++)
        {
            GameObject gameObj = lineObjects[i];
            Texture texture = gameObj.GetComponent<FishingLine>().texture;
            Sprite sprite = gameObj.GetComponent<FishingLine>().sprite;
            string id = gameObj.GetComponent<FishingLine>().id;
            string rodName = gameObj.GetComponent<FishingLine>().lineName;
            int cost = gameObj.GetComponent<FishingLine>().cost;
            int tier = gameObj.GetComponent<FishingLine>().tier;
            string description = gameObj.GetComponent<FishingLine>().description;
            int fishingPower = gameObj.GetComponent<FishingLine>().fishingPower;
            bool isBought = PlayerPrefs.HasKey(id + "bought");
            bool isEquipped = PlayerPrefs.HasKey(id + "equipped");

            FishingLine line = new FishingLine(texture, sprite, id, rodName, cost, tier, description, fishingPower, isBought, isEquipped);
            lineDict.Add(id, line);

        }

    }

    private void generateHookDict(GameObject[] hookObjects)
    {
        for (int i = 0; i < hookObjects.Length; i++)
        {
            GameObject gameObj = hookObjects[i];
            Texture texture = gameObj.GetComponent<FishingHook>().texture;
            Sprite sprite = gameObj.GetComponent<FishingHook>().sprite;
            string id = gameObj.GetComponent<FishingHook>().id;
            string rodName = gameObj.GetComponent<FishingHook>().hookName;
            int cost = gameObj.GetComponent<FishingHook>().cost;
            int tier = gameObj.GetComponent<FishingHook>().tier;
            string description = gameObj.GetComponent<FishingHook>().description;
            int fishingPower = gameObj.GetComponent<FishingHook>().fishingPower;
            bool isBought = PlayerPrefs.HasKey(id + "bought");
            bool isEquipped = PlayerPrefs.HasKey(id + "equipped");
            FishingHook hook = new FishingHook(texture, sprite, id, rodName, cost, tier, description, fishingPower, isBought, isEquipped);
            hookDict.Add(id, hook);

        }

    }

}
