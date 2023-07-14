using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventoryScript playerInventory = other.GetComponent<PlayerInventoryScript>();

        if (playerInventory != null)
        {
            playerInventory.DiamondCollected();
            gameObject.SetActive(false);
        }
    }
}
