using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventoryScript : MonoBehaviour
{
    public int NumberOfDiamonds { get; private set; }
    [SerializeField] private AudioSource collectSound;

    public UnityEvent<PlayerInventoryScript> OnDiamondCollected;
    void Start()
    {
        scoreScript.harts = 3;
        scoreScript.keyColected = false;
        scoreScript.score = 0;
        scoreScript.inMaze = false;
        
    }

        public void DiamondCollected()
    {
        collectSound.Play();
        NumberOfDiamonds++;
        scoreScript.score=NumberOfDiamonds;
        OnDiamondCollected.Invoke(this);
    }
  
}
