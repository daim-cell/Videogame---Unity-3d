using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject Explosion;
    Scoreboard scoreboard;
    [SerializeField] int shipscore=10;

    private void Death()
    {
        scoreboard.Hit(shipscore);
        Destroy(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreboard = FindObjectOfType<Scoreboard>();
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
