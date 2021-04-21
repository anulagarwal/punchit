using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxingGloveRaycastHandler : MonoBehaviour
{
    #region Properties
    [Header("Attributes")]
    [SerializeField] private float raycastRange = 0f;
    [SerializeField] private LayerMask hitMask = 0;

    [Header("Component Reference")]
    [SerializeField] private Transform objectCheckerTransform = null;
    #endregion

    #region MonoBehaviour Functions
    private void Start()
    {
        ObjectInRange = false;
    }

    private void Update()
    {
        ObjectInRange = Physics.Raycast(objectCheckerTransform.position, objectCheckerTransform.forward, raycastRange, hitMask);
    }
    #endregion

    #region Getter And Setter
    public bool ObjectInRange { get; set; }
    #endregion
}
