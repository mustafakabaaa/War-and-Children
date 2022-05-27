using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemysolider : MonoBehaviour
{
    public int speed;
    bool faceRight = false;
    public int donmesuresi;
    public float damage;
    bool playerCollider = false;

    private void Start()
    {
        StartCoroutine(SwitchDiretion());   
    }
    private void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    IEnumerator SwitchDiretion()
    {
        yield return new WaitForSeconds(donmesuresi);
        Switch();
    }
    private void Switch()
    {
        faceRight = !faceRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
        speed *= -1;

        StartCoroutine(SwitchDiretion());
    }
   
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !playerCollider)
        {

            playerCollider = true;
            collision.GetComponent<newchar>().getDamage(damage);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerCollider = false;
        }
    }
}
