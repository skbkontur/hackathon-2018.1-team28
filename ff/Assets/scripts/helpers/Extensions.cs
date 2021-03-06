﻿using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace Assets.scripts.Helpers
{
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static class Extensions
    {
        public static Vector3 ChangeX(this Vector3 input, float newX)
        {
            return new Vector3(newX, input.y, input.z);
        }

        public static Vector3 ChangeY(this Vector3 input, float newY)
        {
            return new Vector3(input.x, newY ,input.z);
        }

        public static Vector3 ChangeZ(this Vector3 input, float newZ)
        {
            return new Vector3(input.x, input.y, newZ);
        }

        public static Vector3 AddValue(this Vector3 input, float dx, float dy, float dz)
        {
            return new Vector3(input.x + dx, input.y + dy, input.z + dz);
        }

        public static Vector3 AddValueX(this Vector3 input, float dx)
        {
            return ChangeX(input, input.x + dx);
        }

        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public static Vector3 AddValueXY(this Vector3 input, float dx, float dy)
        {
            return new Vector3(input.x + dx, input.y + dy, input.z);
        }

        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public static Vector3 AddValueXYClamped(this Vector3 input, float dx, float dy, Vector2 maxValue,
            Vector2 minValue)
        {
            return new Vector3(
                Mathf.Clamp(input.x + dx, minValue.x, maxValue.x),
                Mathf.Clamp(input.y + dy, minValue.y, maxValue.y),
                input.z);
        }
    }
}