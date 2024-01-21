using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _cameraTransform;
    [SerializeField] private int _speed;
    [SerializeField] private Vector2[] _bound;


    private void Update()
    {
        Vector3 direction = Input.GetAxisRaw("Horizontal") * Vector3.right + Input.GetAxisRaw("Vertical") * Vector3.forward; 
        _cameraTransform.transform.Translate(direction * (_speed + 666) * Time.deltaTime, Space.World);
    }
}
