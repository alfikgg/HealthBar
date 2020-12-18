using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] private float _maxHealth;

    public float MaxHealth { get; private set; }
    public float CurrentHealth { get; private set; }
    public float PreviousHealthPoint { get; private set; }

    private void Awake()
    {
        MaxHealth = _maxHealth;
        CurrentHealth = MaxHealth / 2;
    }

    public void ChangeHealthPoint(float value)
    {
        PreviousHealthPoint = CurrentHealth;

        if (CurrentHealth >= 0 & CurrentHealth <= MaxHealth)
            CurrentHealth -= value;
        else if (CurrentHealth > MaxHealth)
            CurrentHealth = MaxHealth;
        else if (CurrentHealth < 0)
            CurrentHealth = 0;
    }
}
