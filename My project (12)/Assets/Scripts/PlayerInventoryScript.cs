using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventoryScript : MonoBehaviour
{
    public int NumberOfDiamonds { get; private set; }

    public UnityEvent<PlayerInventoryScript> OnDiamondCollected;

   
    public void DiamondCollected()
    {
        NumberOfDiamonds++;
        scoreScript.score=NumberOfDiamonds;
        OnDiamondCollected.Invoke(this);
    }
  
}
