using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ziel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player") 
        {
            Debug.Log("Ziel Erreicht");
			//Optional: Player teleportieren
			//thePlayer.transform.position = teleportTarget.transform.position;
        }
    }
}
