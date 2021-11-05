using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 2.0f;
    [SerializeField] private float _hyperSpeed = 50.0f;

    [SerializeField] private float _hyperMoveInterval;
    private float _prevHyperMove;

    [SerializeField] private Button _shootButton;
    [SerializeField] private GameObject _lazerPrefab;
    
    private float _nextFire;
    [SerializeField] private float _rateFire;
    
    [SerializeField] private int _lvlSpeedBonus = 0;
    [SerializeField] private float _speedBonus = 0.1f;
    
    [SerializeField] private int _lvlFireBonus = 0;
    [SerializeField] private float _fireBonus = 0.01f;

    [SerializeField] private AudioClip _boom;
    [SerializeField] private AudioClip _hypermove;
    
    
    // Start is called before the first frame update
    private void Start()
    {
        transform.position = new Vector3(0, -2.0f, 0);
        _shootButton.onClick.AddListener(Shoot);
        _nextFire = Time.timeSinceLevelLoad;
        _prevHyperMove = Time.timeSinceLevelLoad;
    }
    public void Moving(Vector3 direction)
    {
        Vector3 additional = direction * _speed * Time.deltaTime;
        Vector3 goIn = additional + transform.position;
        if(goIn.y >= -2.0f && goIn.y <= 0.5f && goIn.x >= -2.0f && goIn.x <= 2.0f && this.gameObject)
            transform.Translate(additional);
    }
    
    public void HyperMoving(Vector3 direction)
    {
        Vector3 additional = direction * _hyperSpeed * Time.deltaTime;
        Vector3 goIn = additional + transform.position;
        if (goIn.y >= -2.0f && goIn.y <= 0.5f && goIn.x >= -2.0f && goIn.x <= 2.0f && this.gameObject 
            && Time.time - _prevHyperMove >= _hyperMoveInterval)
        {
            _prevHyperMove = Time.timeSinceLevelLoad;
            AudioSource.PlayClipAtPoint(_hypermove, transform.position, 0.3f);
            transform.Translate(additional);
        }
    }

    private void Shoot()
    {
        if (_nextFire <= Time.timeSinceLevelLoad)
        {
            Vector3 laserSpawn = transform.position;
            laserSpawn.y += 0.6f;
            Instantiate(_lazerPrefab, laserSpawn, Quaternion.identity);
            _nextFire = Time.timeSinceLevelLoad + _rateFire;
        }
    }

    public void Die()
    {
        AudioSource.PlayClipAtPoint(_boom, transform.position, 1.0f);
        Destroy(gameObject);
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Time.timeSinceLevelLoad / 5 - _lvlSpeedBonus > 1.0f)
        {
            _lvlSpeedBonus += 1;
            _speed += _speedBonus;
        }
        
        if (Time.timeSinceLevelLoad / 15 - _lvlFireBonus > 1.0f)
        {
            _lvlFireBonus += 1;
            _rateFire -= _fireBonus;
        }
    }
}
