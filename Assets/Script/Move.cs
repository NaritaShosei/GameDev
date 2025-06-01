using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidBody;
    bool isStop = false;
    [SerializeField] Transform _goal;
    [SerializeField] float _moveSpeed;
    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isStop)
        {
            //確実に停止させる
            _rigidBody.linearVelocity = Vector3.zero;
            return;
        }

        var dir = _goal.position - transform.position;

        if (dir.magnitude < 0.3f)
        {
            isStop = true;
        }

        _rigidBody.linearVelocity = dir.normalized * _moveSpeed;
    }
}