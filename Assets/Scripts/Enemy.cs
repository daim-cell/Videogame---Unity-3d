using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject Explosion;
    [SerializeField] float Loaddelay = 1f;

    private void Death()
    {
        Destroy(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnParticleCollision(GameObject other)
    {
        Explosion.SetActive(true);
        Invoke("Death", Loaddelay);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
