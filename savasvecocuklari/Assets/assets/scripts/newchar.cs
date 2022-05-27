using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class newchar : MonoBehaviour
{
    Rigidbody2D rgb;
    Vector3 velocity;

    public float speedAmount = 4f;
    float jumpAmount = 6.2f;
    public Animator animator;
    public Image heaaltbar;
    public float inithealth;
    public float boyhealth;

    public bool dead = false;
    public GameObject restartButton;
    public GameObject dieMenu;
    public GameObject DeadCikis;
    public GameObject DeadArka;
    public GameObject Oldun;
    public GameObject genelmenukapat;
    public GameObject healthbar;
    public GameObject healthbarKapat;
    AudioSource audioSource;
   


    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
        inithealth = boyhealth;
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        animator.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));

        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);

        transform.position += velocity * speedAmount * Time.deltaTime;

       
       

        

        if (Input.GetButtonDown("Jump")&& Mathf.Approximately(rgb.velocity.y,0))
        {
            rgb.AddForce(Vector3.up * jumpAmount, ForceMode2D.Impulse);
            animator.SetBool("isJumping", true);
            audioSource.Play();
            
        }
        if (animator.GetBool("isJumping") && Mathf.Approximately(rgb.velocity.y, 5/10))
        {
            animator.SetBool("isJumping", false);
        }

        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }

        else if (Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        if (boyhealth>0)
        {
            Time.timeScale = 1;
        }
        HealthBar();

    }
    public void HealthBar()
    {
        heaaltbar.fillAmount = boyhealth / inithealth;
    }
   
    public void kalp(float kalp)
    {
        if (boyhealth+ kalp>=0&& boyhealth<100)
        {
            boyhealth += kalp;
            
            
        }
    }
    public void getDamage(float damage)
    {
        if (boyhealth - damage >= 0)
        {
            boyhealth -= damage;

            StartCoroutine(damageanimator());

        }
        else
        {
            boyhealth = 0;

        }
        amIdead();


    }
    void amIdead()
    {
        if (boyhealth == 0)
        {
            dead = true;
            Time.timeScale = 0;
            ////animator.SetBool("Dead", true);
            restartButton.SetActive(true);
            dieMenu.SetActive(true);
            DeadCikis.SetActive(true);
            DeadArka.SetActive(true);
            Oldun.SetActive(true);
            genelmenukapat.SetActive(false);
            healthbarKapat.SetActive(false);

        }
    }
    IEnumerator damageanimator()
    {
        animator.SetBool("isDamage", true);
        yield return new WaitForSecondsRealtime(0.4f);
        animator.SetBool("isDamage", false);
    }
    public void finish(bool finish)
    {
        if (finish == true)
        {


            Time.timeScale = 0;
            //animator.SetBool("Dead", true);
            //restartButton.SetActive(true);
            dieMenu.SetActive(true);
            DeadCikis.SetActive(true);
            DeadArka.SetActive(true);
            genelmenukapat.SetActive(false);
            healthbarKapat.SetActive(false);
        }
    }
}
