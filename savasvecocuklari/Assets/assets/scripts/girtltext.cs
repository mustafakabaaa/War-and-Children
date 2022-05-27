using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girtltext : MonoBehaviour
{
    
    public GameObject girltext1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            girltext1.SetActive(true);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            girltext1.SetActive(false);
        }
    }
}
