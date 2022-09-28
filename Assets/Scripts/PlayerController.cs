using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

   private CharacterController _characterController;
    private Vector3 _direction;
    [SerializeField] private float _speed;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _direction.z = _speed;
        
    }
    private void Update()
    {
        _characterController.Move(_direction * Time.deltaTime);
    }
}
