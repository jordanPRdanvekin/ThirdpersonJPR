using UnityEngine;

/// <summary>
/// Permite al jugador recoger power-ups cuando entra en contacto con ellos.
/// </summary>
public class PlayerPickUpAbility : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Intenta obtener el componente iPowerUp. Si existe, ejecuta la acción de recoger el power-up.
        if (other.TryGetComponent<iPowerUp>(out iPowerUp powerUp))
        {
            powerUp.PickupPowerup(this.gameObject);
            Debug.Log($"Has recogido {other.gameObject.name}");
        }
    }
}

