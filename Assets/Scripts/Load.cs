using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    void Awake()
    {
        int num = FindObjectsOfType<Load>().Length;
        if (num > 1) Destroy(this.gameObject);
        else
        DontDestroyOnLoad(this.gameObject);
    }

// Start is called before the first frame update
void Start()
    {
        Invoke("UpdateP", 5f);
    }

    // Update is called once per frame
    void UpdateP()
    {
        SceneManager.LoadScene(1);
    }
}