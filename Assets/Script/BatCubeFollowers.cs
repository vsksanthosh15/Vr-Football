using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatCubeFollowers : MonoBehaviour
{
    private Bat _batFollower;
    private Rigidbody _rigidbody;
    private Vector3 _velocity; //calculate the velocity user produce

    [SerializeField]
    private float _sensitivity = 100f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _batFollower = GetComponentInParent<Bat>();
    }

    private void FixedUpdate()
    {
        //calculating the velocity of controller user produced and applay to rigidbody
        Vector3 destination = _batFollower.transform.position;
        _rigidbody.transform.rotation = transform.rotation;

        _velocity = (destination - _rigidbody.transform.position) * _sensitivity;

        _rigidbody.velocity = _velocity;
        transform.rotation = _batFollower.transform.rotation;
    }

    internal void SetFollowTarget(Bat bat)
    {
        _batFollower = bat;
    }
    public void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.CompareTag("Ball"))
        //{
        //    OVRHaptics.Channels[1].Preempt(new OVRHapticsClip());
        //}
    }
}
