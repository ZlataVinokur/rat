using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rat_move : MonoBehaviour
{

    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _speedSize;
    [SerializeField] private float _maxHeight;
    [SerializeField] private float _minHeight;

    private Vector3 _targetPosition;
    private void Start()
    {
        _targetPosition = transform.position;

    }

    private void Update()
    {
        if (transform.position != _targetPosition)
            transform.position = Vector2.MoveTowards(transform.position, _targetPosition, _moveSpeed * Time.deltaTime);
            
    }

    public void MoveUp()
    {
        if (_targetPosition.y < _maxHeight)
            SetNextPosition(_speedSize); 
    }

    public void MoveDown()
    {
        if (_targetPosition.y > _minHeight)
            SetNextPosition(-_speedSize);
    }

    private void SetNextPosition(float stepSize)
    {
        _targetPosition = new Vector2(_targetPosition.x, _targetPosition.y + stepSize);
    }
}
