using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxingGloveCollisionEventsHandler : MonoBehaviour
{
    #region Properties
    [Header("Component Reference")]
    [SerializeField] private BoxingGloveRepositionHandler boxingGloveRepositionHandler = null;
    #endregion

    #region MonoBehaviour Functions
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Prop")
        {
            boxingGloveRepositionHandler.EnableRBKinematic(true);
            boxingGloveRepositionHandler.Reposition = true;
        }
    }
    #endregion
}
