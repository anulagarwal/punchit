using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxingGloveRepositionHandler : MonoBehaviour
{
    #region Properties
    [Header("Attributes")]
    [SerializeField] private float repositionSpeed = 0f;

    [Header("Component Reference")]
    [SerializeField] private Transform boxingGloveTargetPositionTransform = null;
    [SerializeField] private Rigidbody rb = null;
    #endregion

    #region MonoBehaviour Functions
    private void Start()
    {
        Reposition = false;
    }

    private void Update()
    {
        if (Reposition)
        {
            if (Vector3.Distance(transform.position, boxingGloveTargetPositionTransform.position) >= 0.2f)
            {
                transform.position = Vector3.Lerp(transform.position, boxingGloveTargetPositionTransform.position, Time.deltaTime * repositionSpeed);
            }
            else
            {
                LevelUIManager.Instance.EnablePunchBtnInteraction(true);
                EnableRBKinematic(false);
                Reposition = false;
            }
        }
    }
    #endregion

    #region Getter And Setter
    public bool Reposition { get; set; }
    #endregion

    #region Public Core Functions
    public void EnableRBKinematic(bool value)
    {
        rb.isKinematic = value;
    }
    #endregion
}
