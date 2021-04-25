using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    #region Properties
    public static LevelManager Instance = null;

    [Header("Attributes")]
    [Range(0,200)] [SerializeField] private int numberOfPunches_Energy = 0;

    [Header("Punching Prop Setup")]
    [SerializeField] private List<GameObject> propPrefabs = new List<GameObject>();
    [SerializeField] private Transform spawnPoint = null;

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
        SpawnPunchingProp();
    }
    #endregion

    #region Getter And Setter
    public int GetPunchEnergy { get => punchEnergy; set { punchEnergy = value; } }

    public int GetNumberOfPunches_Energy { get => numberOfPunches_Energy; }
    #endregion

    #region Private Core Functions
    private void SpawnPunchingProp()
    {
        GameObject propObj = propPrefabs[Random.Range(0, propPrefabs.Count)];
        PropHandler propHandler = propObj.GetComponent<PropHandler>();
        Instantiate(propObj, spawnPoint.position + propHandler.GetSpawnPositionOffset, Quaternion.Euler(propHandler.GetRotationOffset), spawnPoint);
    }
    #endregion
}
