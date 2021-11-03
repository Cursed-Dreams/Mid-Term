using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeathScript : MonoBehaviour
{
    public GameObject deathbox;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (deathbox != null)
            SceneManager.LoadScene("level 1");
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
