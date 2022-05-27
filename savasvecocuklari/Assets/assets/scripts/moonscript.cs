using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moonscript : MonoBehaviour
{
    Rigidbody2D rgb;
    Vector3 velocity;

    float speedAmount = 2f;
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);

        transform.position += velocity * speedAmount * Time.deltaTime;
    }
}
