using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropHandler : MonoBehaviour
{
    #region Properties
    [Header("Attributes")]
    [SerializeField] private Vector3 spawnPositionOffset = Vector3.zero;
    [SerializeField] private Vector3 rotationOffset = Vector3.zero;
    [SerializeField] private ParticleSystem splashPS = null;
    #endregion

    #region Getter And Setter
    public Vector3 GetSpawnPositionOffset { get => spawnPositionOffset; }

    public Vector3 GetRotationOffset { get => rotationOffset; }
    #endregion

    #region Public Core Functions
    public void PlaySplash(Vector3 newPosition)
    {
        if (splashPS != null)
        {
            splashPS.transform.position = newPosition;
            splashPS.Play();
        }
    }
    #endregion
}
