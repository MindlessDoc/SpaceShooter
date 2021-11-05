using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] private float _speed = 3.0f;

    [SerializeField] private AudioClip _boom;
    void Start()
    {
        
    }
    
    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
        if(transform.position.y < -6)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Lazer")
        {
            AudioSource.PlayClipAtPoint(_boom, transform.position, 1.0f);
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(_boom, transform.position, 1.0f);
            Destroy(gameObject);
            collision.gameObject.GetComponent<Player>().Die();
        }
    }
}
