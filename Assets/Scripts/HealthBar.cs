using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private Player _player;
    [SerializeField] private float _fillingSpeed;


    private void Start()
    {
        _healthBar.maxValue = _player.MaxHealth;
        _healthBar.value = _player.CurrentHealth;
    }

    public void FixedUpdate()
    {
        float tempValue = _player.CurrentHealth - _healthBar.value;

        if (Mathf.Abs(tempValue) < 0.09)
            _healthBar.value = _player.CurrentHealth;

        _healthBar.value = Mathf.Lerp(_healthBar.value, _player.CurrentHealth, Time.deltaTime * _fillingSpeed);

    }

}
