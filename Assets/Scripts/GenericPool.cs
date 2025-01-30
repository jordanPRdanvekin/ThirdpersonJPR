using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab; // Prefab de la bala
    [SerializeField] private int poolSize = 10; // Número de balas en la pool

    private Queue<GameObject> _bulletQueue = new Queue<GameObject>(); // Cola de balas disponibles

    void Start()
    {
        InitializePool();
    }

    /// <summary>
    /// Inicializa la pool de balas creando los objetos y desactivándolos.
    /// </summary>
    private void InitializePool()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab, Vector3.zero, Quaternion.identity);
            bullet.SetActive(false);
            bullet.GetComponent<BulletBehavior>().SetPool(this); // Asigna la pool a la bala
            _bulletQueue.Enqueue(bullet);
        }
    }

    /// <summary>
    /// Obtiene una bala de la pool o crea una nueva si no hay disponibles.
    /// </summary>
    public GameObject GetBullet()
    {
        if (_bulletQueue.Count > 0)
        {
            return _bulletQueue.Dequeue();
        }
        else
        {
            GameObject newBullet = Instantiate(bulletPrefab, Vector3.zero, Quaternion.identity);
            newBullet.SetActive(false);
            newBullet.GetComponent<BulletBehavior>().SetPool(this);
            return newBullet;
        }
    }

    /// <summary>
    /// Devuelve una bala a la pool para su reutilización.
    /// </summary>
    public void ReturnBullet(GameObject bullet)
    {
        bullet.SetActive(false);
        _bulletQueue.Enqueue(bullet);
    }
}


