using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject Explosion;
   

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
        Instantiate(Explosion, transform.position, Quaternion.identity);

        Death();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
