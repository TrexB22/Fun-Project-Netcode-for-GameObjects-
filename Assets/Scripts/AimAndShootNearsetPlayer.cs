using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class AimAndShootNearsetPlayer : MonoBehaviour
{

    public float gunRotationSpeed = 10f;

    public void AimAtNearestPlayer(Transform nearestPlayerTransform, Transform gunTransform) {
        Vector3 direction = nearestPlayerTransform.position - gunTransform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion targetRotation = Quaternion.AngleAxis(angle, Vector3.forward);
        gunTransform.rotation = Quaternion.Lerp(gunTransform.rotation, targetRotation, Time.deltaTime * gunRotationSpeed);
    } // AimAtNearestPlayer

} // Class