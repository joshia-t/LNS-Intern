﻿using LNS.CameraMovement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LNS.Entities
{
    public class Player : Soldier
    {
        [SerializeField] CameraScript _cam;
        public override void Awake()
        {
            base.Awake();
            _cam.SetTarget(transform);
        }
        public override void OnKilled(Damagable other)
        {
            base.OnKilled(other);
            _cam.SetTarget(other.transform);
        }
        public override void OnRespawn()
        {
            base.OnRespawn();
            _cam.SetTarget(transform);
            transform.position = Vector3.zero;
        }
    }
}