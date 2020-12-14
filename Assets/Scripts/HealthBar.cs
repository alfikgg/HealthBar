using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;

    private float _currentValue;

    private void Start()
    {
        _healthBar.maxValue = 100;
        _currentValue = _healthBar.maxValue / 2;
        _healthBar.value = _currentValue;
    }

    public void ChangeValue(int value)
    {
        if (_currentValue >= 0 & _currentValue <= _healthBar.maxValue)
            _currentValue -= value;
        else if (_currentValue > _healthBar.maxValue)
            _currentValue = _healthBar.maxValue;
        else if (_currentValue < 0)
            _currentValue = 0;        
    }

    public void FixedUpdate()
    {
        _healthBar.value = Mathf.Lerp(_healthBar.value, _currentValue, Time.deltaTime * 2);
    }

}
