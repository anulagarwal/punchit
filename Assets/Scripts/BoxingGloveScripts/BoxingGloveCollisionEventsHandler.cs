using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxingGloveCollisionEventsHandler : MonoBehaviour
{
    #region Properties
    [Header("Component Reference")]
    [SerializeField] private BoxingGloveRepositionHandler boxingGloveRepositionHandler = null;
    [SerializeField] private ParticleSystem punchSmokePS = null;
    #endregion

    #region MonoBehaviour Functions
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Prop")
        {
            punchSmokePS.transform.position = this.transform.position;
            punchSmokePS.Play();

            boxingGloveRepositionHandler.EnableRBKinematic(true);
            boxingGloveRepositionHandler.Reposition = true;

            if(collision.gameObject.TryGetComponent<PropHandler>(out PropHandler propHandler))
            {
                propHandler.PlaySplash(transform.position);
            }
        }
    }
    #endregion
}
