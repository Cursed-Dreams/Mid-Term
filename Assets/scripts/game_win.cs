using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_win : MonoBehaviour
{
    public GameObject winbox;
    public GameObject winscreen;
    public void OnTriggerEnter(Collider other)
    {
        if(winbox != null)
        {
            winscreen.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            winscreen.SetActive(false);
            Time.timeScale = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
