using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{
    [SerializeField] float Loaddelay = 1f;
    [SerializeField] GameObject Explosion;
    void OnTriggerEnter(Collider other)
    {
        Explosion.SetActive(true);
        Invoke("Death",Loaddelay);
    }

    private void Death()
    {
        //SendMessage("disable");
        print("you touched");
        //SceneManager.LoadScene(1);
    }
}  
