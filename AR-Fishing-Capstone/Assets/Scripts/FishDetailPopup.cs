using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FishDetailPopup : MonoBehaviour
{
    public GameObject fishDetailDisplay;
    public RawImage fishImage;
    public TextMeshProUGUI fishName;
    public TextMeshProUGUI description;
    public TextMeshProUGUI tier;
    public TextMeshProUGUI weight;


    // Start is called before the first frame update
    public void onClickClosePopUp()
    {
        fishDetailDisplay.SetActive(false);
    }

}
