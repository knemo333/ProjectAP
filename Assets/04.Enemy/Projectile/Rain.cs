using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    const string PLAYER = "Player";
    const string WALL = "WALL";

    public GameObject hitEffect;
    
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag(PLAYER))
        {
            other.GetComponent<PlayerTakeDamage>().TakeDamage(1);
            GameObject effect = Instantiate(hitEffect, transform.position, transform.rotation);
            Destroy(effect, 1.2f);
            Destroy(gameObject);
        }
        if(other.CompareTag(WALL))
        {
            Destroy(gameObject);
        }
    }
}
