using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject Explosion;
    Scoreboard scoreboard;
    [SerializeField] int shipscore=10;
    [SerializeField] int hit = 10;

    private void Death()
    {
        Instantiate(Explosion, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreboard = FindObjectOfType<Scoreboard>();
    }

    void OnParticleCollision(GameObject other)
    {
        scoreboard.Hit(shipscore);
        hit-=1;
        if (hit < 0)
        {
            Death();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
