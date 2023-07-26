using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour {
    [SerializeField] private Ball ball;

    [SerializeField] private Transform ballSpawn;

    [SerializeField] private float velocity = 10;

    [SerializeField] private AudioSource BoomSound;
    private int num;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G)&& scoreScript.inMaze&&num<=6) {
            BoomSound.Play();
            var Nball = Instantiate(ball, ballSpawn.position, ballSpawn.rotation);
            Nball.Init(velocity);
            num++;
        }
    }
}
