using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fragment : MonoBehaviour
{
    [SerializeField] private float _speed = 3.0f;
    [SerializeField] public FragmentsScore FragmentsScore;

    [SerializeField] private AudioClip _loot;
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
        if (collision.tag == "Player")
        {
            AudioSource.PlayClipAtPoint((_loot), transform.position, 1.0f);
            Destroy(gameObject);
            PlayerPrefs.SetInt("Fragment", PlayerPrefs.GetInt("Fragment") + 1);
            FragmentsScore.UpdateScore();
        }
    }
}
