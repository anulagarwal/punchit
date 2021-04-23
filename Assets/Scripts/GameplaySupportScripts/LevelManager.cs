using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    #region Properties
    public static LevelManager Instance = null;

    [Header("Attributes")]
    [Range(0,200)] [SerializeField] private int numberOfPunches_Energy = 0;

    private int punchEnergy = 0;
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

    private void Start()
    {
        punchEnergy = numberOfPunches_Energy;
    }
    #endregion

    #region Getter And Setter
    public int GetPunchEnergy { get => punchEnergy; set { punchEnergy = value; } }

    public int GetNumberOfPunches_Energy { get => numberOfPunches_Energy; }
    #endregion
}
