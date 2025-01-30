using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShootAbility : MonoBehaviour
{
    [SerializeField] private BulletPool bulletPool; // Pool de balas reutilizables
    private StarterAssetsInputs _input; // Referencia a la entrada del jugador

    void Start()
    {
        _input = GetComponent<StarterAssetsInputs>();
    }

    void Update()
    {
        if (_input.shoot) // Dispara solo cuando el jugador presiona el bot�n de disparo
        {
            Shoot();
            _input.shoot = false; // Evita disparos m�ltiples con una sola pulsaci�n
        }
    }

    /// <summary>
    /// M�todo que obtiene una bala de la pool y la activa en la posici�n del jugador.
    /// </summary>
    private void Shoot()
    {
        GameObject bullet = bulletPool.GetBullet();
        if (bullet != null)
        {
            bullet.transform.position = transform.position + transform.up * 0.5f + transform.forward * 0.5f;
            bullet.transform.rotation = transform.rotation;
            bullet.SetActive(true);
            Debug.Log("BANG BANG BANG"); // Registro del disparo
        }
    }
}

