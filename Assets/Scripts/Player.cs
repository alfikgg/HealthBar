using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _maxHealth;

    public int MaxHealth { get; private set; }
    public int CurrentHealth { get; private set; }

    private void Start()
    {
        _maxHealth = 100;
        MaxHealth = _maxHealth;
        CurrentHealth = MaxHealth;
    }
    public void TakeDamage(int damage)
    {
        if(CurrentHealth > 0)
        {
            CurrentHealth -= damage;
        }
    }
}
