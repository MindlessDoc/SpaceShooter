using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawn : MonoBehaviour
{
    [SerializeField] private FragmentsScore _fragmentsScore;
    
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
        if (_asteroidNextTime < Time.timeSinceLevelLoad)
        {
            Instantiate(_asteroidPrefab, new Vector3(Random.Range(-2.2f, 2.2f), 5.7f, transform.position.z),
                Quaternion.identity);
            _asteroidNextTime = Time.timeSinceLevelLoad + _asteroidSpawnTime;
        }
        
        if (_fragmentNextTime < Time.timeSinceLevelLoad)
        {
            var add = Instantiate(_fragmentPrefab, new Vector3(Random.Range(-2.2f, 2.2f), 5.7f, transform.position.z),
                Quaternion.identity);
            add.GetComponent<Fragment>().FragmentsScore = _fragmentsScore;
            _fragmentNextTime = Time.timeSinceLevelLoad + _fragmentSpawnTime;
        }
    }
}
