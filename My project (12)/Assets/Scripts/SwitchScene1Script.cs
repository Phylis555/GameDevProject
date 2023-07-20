using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene1Script : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BGmusic;
    void Start()
    {
        DontDestroyOnLoad(BGmusic);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(4);
    }
}
