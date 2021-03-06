﻿using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using UnityEngine;

namespace Assets.scripts
{
    [PublicAPI]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "UnassignedField.Global")]
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    public class PlayerData : MonoBehaviour
    {
        public int HealthPoint;
        public int HealthPointMax;
        public AudioClip MoveSound;
        public AudioClip DieSound;
        public bool IsAlive => HealthPoint > 0;
    }
}
