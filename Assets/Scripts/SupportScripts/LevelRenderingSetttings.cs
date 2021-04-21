using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRenderingSetttings : MonoBehaviour
{
    #region Properties
    [Header("Editor Setup")]
    [SerializeField] private Material bgMat = null;
    [SerializeField] private List<Color> colors_1 = new List<Color>();
    [SerializeField] private List<Color> colors_2 = new List<Color>();
    #endregion

    #region MonoBehaviour Functions
    private void Start()
    {
        int index = Random.Range(0, colors_1.Count);
        bgMat.SetColor("Color_1", colors_1[index]);
        bgMat.SetColor("Color_2", colors_2[index]);
    }
    #endregion
}
