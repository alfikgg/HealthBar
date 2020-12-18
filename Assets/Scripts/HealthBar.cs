using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private Player _player;
    [SerializeField] private float _fillingSpeed;
    [SerializeField] private float _maxFillingSpeed;
    [SerializeField] private float _tmpValue = 0;

    private void Start()
    {
        _healthBar.maxValue = _player.MaxHealth;
        _healthBar.value = _player.CurrentHealth;
    }

    private void Update()
    {
        
        //_healthBar.value = Mathf.Lerp(_player.PreviousHealthPoint, _player.CurrentHealth, _fillingSpeed);
        _healthBar.value = Mathf.SmoothDamp(_player.PreviousHealthPoint, _player.CurrentHealth, ref _tmpValue, _fillingSpeed);
    }

}
