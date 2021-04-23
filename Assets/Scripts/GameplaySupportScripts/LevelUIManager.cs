using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelUIManager : MonoBehaviour
{
    #region Properties
    public static LevelUIManager Instance = null;

    [Header("Gameplay UI Component Reference")]
    [SerializeField] private Button punchBtn = null;
    [SerializeField] private Image enemyBarFG = null;
    [SerializeField] private TextMeshProUGUI energyAmountTxt = null;
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

    public void UpdateEnergyBarFG(int value)
    {
        energyAmountTxt.SetText(((int)(100 * ((float)value / (float)LevelManager.Instance.GetNumberOfPunches_Energy))).ToString() + "%");
        enemyBarFG.fillAmount = (float)value / (float)LevelManager.Instance.GetNumberOfPunches_Energy;
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
