using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class beyhudegames : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(ekrangecis());
    }
    IEnumerator ekrangecis()
    {
       
        yield return new WaitForSecondsRealtime(7f);
        SceneManager.LoadScene(1);
    }
}
