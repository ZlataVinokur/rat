using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rat_move))]


public class Rat_input : MonoBehaviour
{
    [SerializeField] private Rat_move _mover;

    private void Start()
    {
        _mover = GetComponent<Rat_move>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _mover.MoveUp();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            _mover.MoveDown();
        }
    }
}
