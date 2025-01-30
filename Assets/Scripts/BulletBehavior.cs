using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    private BulletPool _bulletPool;
    private float _speed = 10f;
    private float _lifeTime = 3f;
    private float _timer;

    void OnEnable()
    {
        _timer = _lifeTime; // Reinicia el temporizador cada vez que la bala se activa
    }

    void Update()
    {
        transform.position += transform.forward * _speed * Time.deltaTime;

        _timer -= Time.deltaTime;
        if (_timer <= 0)
        {
            _bulletPool.ReturnBullet(gameObject);
        }
    }

    /// <summary>
    /// Asigna la referencia de la pool de balas a la bala.
    /// </summary>
    public void SetPool(BulletPool pool)
    {
        _bulletPool = pool;
    }
}

