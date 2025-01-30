using UnityEngine;

/// <summary>
/// Sistema de magia modular y reutilizable basado en el principio SOLID.
/// </summary>
public class SolidMagicSystem : MonoBehaviour
{
    [SerializeField] private int maxMagic = 5; // M�ximo de magia permitido
    [SerializeField] private int currentMagic = 2; // Magia actual

    /// <summary>
    /// Modifica la cantidad de magia del jugador.
    /// </summary>
    /// <param name="amount">Cantidad de magia a modificar (puede ser positiva o negativa).</param>
    public void ModifyMagic(int amount)
    {
        if (currentMagic == maxMagic)
        {
            Debug.Log("Magia a tope!");
            return;
        }

        currentMagic += amount;

        if (currentMagic <= 0)
        {
            currentMagic = 0;
            Debug.Log("Me qued� sin man�... PERO NO SIN OPCIONES");
        }
        else if (currentMagic > maxMagic)
        {
            currentMagic = maxMagic;
            Debug.Log("Magia a tope!");
        }
        else
        {
            Debug.Log($"Recuperas {amount} puntos de magia.");
        }
    }

    /// <summary>
    /// Obtiene el valor actual de magia.
    /// </summary>
    public int GetCurrentMagic() => currentMagic;

    /// <summary>
    /// Obtiene el valor m�ximo de magia.
    /// </summary>
    public int GetMaxMagic() => maxMagic;
}
