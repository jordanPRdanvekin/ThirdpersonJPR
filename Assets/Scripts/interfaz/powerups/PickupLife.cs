using UnityEngine;

/// <summary>
/// Power-up que otorga puntos de vida al jugador cuando es recogido.
/// </summary>
public class PickupLife : MonoBehaviour, iPowerUp
{
    [SerializeField] private int healthAmount = 1; // Cantidad de salud que otorga el power-up

    /// <summary>
    /// Ejecuta la lógica de recoger el power-up de vida y aplicarlo al jugador.
    /// </summary>
    public void PickupPowerup(GameObject other)
    {
        // Intenta obtener el sistema de salud del jugador
        if (other.TryGetComponent<SolidHealthSystem>(out SolidHealthSystem healthSystem))
        {
            healthSystem.ModifyHealth(healthAmount);
            Debug.Log("¡Has recuperado salud!");
            Destroy(gameObject); // Se destruye después de ser recogido
        }
    }
}

