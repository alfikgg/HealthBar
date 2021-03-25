using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private float _fillingSpeed;

    private float _targetValue;

    private void OnEnable()
    {
        Player.OnHealthChanged += ChangeHealth;
    }

    private void OnDisable()
    {
        Player.OnHealthChanged -= ChangeHealth;
    }

    private void Start()
    {
        _healthBar.maxValue = _targetValue;    
    }

    private void ChangeHealth(float value)
    {        
        _healthBar.value = _targetValue;
        _targetValue = value;

        StartCoroutine(ChangeHealthValue());
    }

    private IEnumerator ChangeHealthValue()
    {
        while(_healthBar.value != _targetValue)
        {
            _healthBar.value = Mathf.MoveTowards(_healthBar.value, _targetValue, _fillingSpeed);

            yield return null;
        }

        
    }
}
