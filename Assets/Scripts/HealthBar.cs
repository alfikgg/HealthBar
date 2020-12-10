using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;

    private void Start()
    {
        _healthBar.maxValue = 100;
        _healthBar.value = _healthBar.maxValue -50;
    }

    public void TakeDamage(int damage)
    {
        if (_healthBar.value > 0)
            _healthBar.value -= damage;
    }

    public void GetHeal(int heal)
    {
        if(_healthBar.value < _healthBar.maxValue)
        {
            _healthBar.value += heal;
            if (_healthBar.value > _healthBar.maxValue)
                _healthBar.value = _healthBar.maxValue;
        }
    }
}
