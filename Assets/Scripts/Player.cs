using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private float _maxHealth;

    public float MaxHealth { get; private set; }
    public float CurrentHealth { get; private set; }

    void Start()
    {
        MaxHealth = _maxHealth;
        CurrentHealth = _maxHealth;
    }

    public void ChangeHealthPoint(float value)
    {
        if (CurrentHealth >= 0 & CurrentHealth <= MaxHealth)
            CurrentHealth -= value;
        else if (CurrentHealth > MaxHealth)
            CurrentHealth = MaxHealth;
        else if (CurrentHealth < 0)
            CurrentHealth = 0;
    }
}
