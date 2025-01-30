using UnityEngine;

/// <summary>
/// Power-up que otorga puntos de magia al jugador cuando es recogido.
/// </summary>
public class PickupMagic : MonoBehaviour, iPowerUp
{
    [SerializeField] private int magicAmount = 1; // Cantidad de magia que otorga el power-up

    /// <summary>
    /// Ejecuta la lógica de recoger el power-up de magia y aplicarlo al jugador.
    /// </summary>
    public void PickupPowerup(GameObject other)
    {
        if (other.TryGetComponent<SolidMagicSystem>(out SolidMagicSystem magicSystem))
        {
            magicSystem.ModifyMagic(magicAmount);
            Debug.Log("¡You’re a wizard, Harry!");
            Destroy(gameObject); // Se destruye después de ser recogido
        }
    }
}

