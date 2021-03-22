using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private int _fillingSpeed;

    private float _targetHealth;

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
        _healthBar.maxValue = _targetHealth;
    }

    private void FixedUpdate()
    {
        _healthBar.value = Mathf.Lerp(_healthBar.value, _targetHealth , Time.deltaTime * _fillingSpeed);
    }

    private void ChangeHealth(float value)
    {
        _healthBar.value = _targetHealth;
        _targetHealth = value;
    }

}
