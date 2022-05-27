using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kalp : MonoBehaviour
{
    public float kalp1;
    bool playerCollider = false;
    public GameObject kalpkaybol;
    
   
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
            playerCollider = true;
            collision.GetComponent<newchar>().kalp(kalp1);
            kalpkaybol.SetActive(false);
            
        }
    }
    
}
