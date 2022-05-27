using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class civienemy : MonoBehaviour
{
    public float damage;
    bool playerCollider=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Player"&&!playerCollider)
        {

            playerCollider = true;
            collision.GetComponent<newchar>().getDamage(damage);
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag=="Player")
        {
            playerCollider = false;
        }
    }
}
