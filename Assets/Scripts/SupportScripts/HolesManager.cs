using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolesManager : MonoBehaviour
{
    #region Properties
    [Header("Editor Setup")]
    [SerializeField] private List<GameObject> holeObjs = new List<GameObject>();
    #endregion

    #region MonoBehaviour Functions
    private void Start()
    {
        holeObjs[Random.Range(0, holeObjs.Count)].SetActive(true);
    }
    #endregion
}
