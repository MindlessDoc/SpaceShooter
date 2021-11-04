using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _asteroidPrefab;
    [SerializeField] private float _asteroidSpawnTime;
    private float _asteroidNextTime;

    void Start()
    {
        _asteroidNextTime = _asteroidSpawnTime;
    }


    void Update()
    {
        if (_asteroidSpawnTime < Time.time)
        {
            Instantiate(_asteroidPrefab, new Vector3(Random.Range(-2.2f, 2.2f), 5.7f, transform.position.z),
                Quaternion.identity);
            _asteroidSpawnTime = Time.time + _asteroidSpawnTime;
        }
    }
}
