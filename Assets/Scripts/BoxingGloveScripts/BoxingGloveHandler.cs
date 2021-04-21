using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxingGloveHandler : MonoBehaviour
{
    #region Properties
    [Header("Attributes")]
    [SerializeField] private float forceAmount = 0f;

    [Header("Component Reference")]
    [SerializeField] private Rigidbody rb = null;
    #endregion

    #region MonoBehaviour Functions
    #endregion

    #region Public Core Functions
    public void Punch()
    {
        rb.AddForce(Vector3.forward * forceAmount, ForceMode.Impulse);
    }
    #endregion
}
