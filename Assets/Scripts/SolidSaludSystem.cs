using UnityEngine;

/// <summary>
/// Sistema de salud modular basado en el principio SOLID.
/// </summary>
public class SolidHealthSystem : MonoBehaviour
{
    [SerializeField] private int maxHealth = 5; // Máxima salud permitida
    [SerializeField] private int currentHealth = 2; // Salud actual
    private Animator animator; // Referencia al componente Animator

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    /// <summary>
    /// Modifica la cantidad de salud del jugador.
    /// </summary>
    /// <param name="amount">Cantidad de salud a modificar (puede ser positiva o negativa).</param>
    public void ModifyHealth(int amount)
    {
        if (currentHealth == maxHealth)
        {
            Debug.Log("Vida a tope!");
            return;
        }

        currentHealth += amount;

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("*pacman dead sounds* YOU DEAD");
            HandleDeath();
        }
        else if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
            Debug.Log("Vida a tope!");
        }
        else
        {
            Debug.Log($"Recuperas {amount} puntos de vida.");
        }
    }

    /// <summary>
    /// Maneja la muerte del personaje, activando animaciones o lógica adicional.
    /// </summary>
    private void HandleDeath()
    {
        if (animator != null)
        {
            animator.SetTrigger("Die"); // Dispara la animación de muerte si existe
        }
        else
        {
            Debug.LogWarning("No se encontró un Animator en el objeto.");
        }
        // Aquí puedes agregar lógica adicional, como desactivar al personaje.
    }

    /// <summary>
    /// Obtiene el valor actual de salud.
    /// </summary>
    public int GetCurrentHealth() => currentHealth;

    /// <summary>
    /// Obtiene el valor máximo de salud.
    /// </summary>
    public int GetMaxHealth() => maxHealth;
}

