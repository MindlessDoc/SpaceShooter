using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] private float _speed;

    [SerializeField] private AudioClip _fire;

    void Start()
    {
        AudioSource.PlayClipAtPoint(_fire, transform.position, 1.0f);
    }

    void Update()
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);
        if(transform.position.y >= 6.0f)
            Destroy(gameObject);
    }
}
