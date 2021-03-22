using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public delegate void ChangeHealthValue(float value);
    public static event ChangeHealthValue OnHealthChanged;

    [SerializeField] private float _maxHealth;
    private float _currentHealth;

    void Awake()
    {
        _currentHealth = _maxHealth;
        OnHealthChanged(_maxHealth);
    }

    public void ChangeHealthPoint(float value)
    {
        if (_currentHealth >= 0 & _currentHealth <= _maxHealth)
            _currentHealth -= value;
        else if (_currentHealth > _maxHealth)
            _currentHealth = _maxHealth;
        else if (_currentHealth < 0)
            _currentHealth = 0;

        if (OnHealthChanged != null)
        {
            OnHealthChanged(_currentHealth);
        }
    }
}
