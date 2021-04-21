using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUIManager : MonoBehaviour
{
    #region Properties
    public static LevelUIManager Instance = null;

    [Header("Gameplay UI Component Reference")]
    [SerializeField] private Button punchBtn = null;
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

    #region Public Core Functions
    public void EnablePunchBtnInteraction(bool value)
    {
        punchBtn.interactable = value;
    }
    #endregion

    #region Btn Events Functions
    public void OnClick_Punch()
    {
        if (BoxingGloveCustomComponentsHandler.Instance.GetBoxingGloveRaycastHandler.ObjectInRange)
        {
            EnablePunchBtnInteraction(false);
            BoxingGloveCustomComponentsHandler.Instance.GetBoxingGloveHandler.Punch();
        }
    }
    #endregion
}
