using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _asteroidPrefab;
    [SerializeField] private float _asteroidSpawnTime;
    private float _asteroidNextTime;
    
    [SerializeField] private GameObject _fragmentPrefab;
    [SerializeField] private float _fragmentSpawnTime;
    private float _fragmentNextTime;

    void Start()
    {
        _asteroidNextTime = _asteroidSpawnTime;
        _fragmentNextTime = _fragmentSpawnTime;
    }


    void Update()
    {
        if (_asteroidNextTime < Time.time)
        {
            Instantiate(_asteroidPrefab, new Vector3(Random.Range(-2.2f, 2.2f), 5.7f, transform.position.z),
                Quaternion.identity);
            _asteroidNextTime = Time.time + _asteroidSpawnTime;
        }
        
        if (_fragmentNextTime < Time.time)
        {
            Instantiate(_fragmentPrefab, new Vector3(Random.Range(-2.2f, 2.2f), 5.7f, transform.position.z),
                Quaternion.identity);
            _fragmentNextTime = Time.time + _fragmentSpawnTime;
        }
    }
}
