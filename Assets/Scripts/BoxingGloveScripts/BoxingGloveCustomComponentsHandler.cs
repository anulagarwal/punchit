using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxingGloveCustomComponentsHandler : MonoBehaviour
{
    #region Properties
    public static BoxingGloveCustomComponentsHandler Instance = null;

    [Header("Component Reference")]
    [SerializeField] private BoxingGloveHandler boxingGloveHandler = null;
    [SerializeField] private BoxingGloveRaycastHandler boxingGloveRaycastHandler = null;
    #endregion

    #region MonoBehaviour Functions
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        Instance = this;
    }
    #endregion

    #region Getter And Setter
    public BoxingGloveHandler GetBoxingGloveHandler { get => boxingGloveHandler; }

    public BoxingGloveRaycastHandler GetBoxingGloveRaycastHandler { get => boxingGloveRaycastHandler; }
    #endregion
}
