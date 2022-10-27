using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerFollow : MonoBehaviour
{
    private Vector3 _offset;
    [SerializeField] private Transform target;
    [SerializeField] private float smoothtime;
    private Vector3 _currentvelocity = Vector3.zero;

    private void Awake()
    {
        _offset = transform.position - target.position;
    }

    private void LateUpdate()
    {
        Vector3 targetposition = target.position + _offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetposition, ref _currentvelocity, smoothtime);
    }
}
