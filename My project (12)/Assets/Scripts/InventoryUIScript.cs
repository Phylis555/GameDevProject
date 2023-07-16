using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUIScript : MonoBehaviour
{
    private TextMeshProUGUI diamondText;

    // Start is called before the first frame update
    void Start()
    {
        diamondText = GetComponent<TextMeshProUGUI>();
        diamondText.text = scoreScript.score.ToString();
    }

    public void UpdateDiamondText(PlayerInventoryScript playerInventory)
    {
         
        diamondText.text = scoreScript.score.ToString();
    }
}
