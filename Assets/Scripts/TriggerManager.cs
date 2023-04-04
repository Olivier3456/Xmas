using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


// Ce script est attach� � un objet avec un Collider "Is Trigger".

public class TriggerManager : MonoBehaviour
{
    private bool deactivate = false;    // Deviendra true si notre TriggerManager est d�sactiv� (il faudra ex�cuter notre fonction DeactivateTrigger()
                                        // dans Unity, sur le composant Trigger Manager de l'objet, dans la case "Trigger Entered").
    public UnityEvent TriggerEntered;
    public UnityEvent TriggerExited;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " est entr� dans le trigger de " + gameObject.name);

        if (other.name == "PlayerCapsule" && deactivate == false)
            TriggerEntered.Invoke();            // Quand le joueur entre dans notre trigger, �a d�clenche l'�v�nement "TriggerEntered".
                                                // Dans Unity, on attache ce script � chaque objet qui a un Is Trigger et qui doit d�clencher un
                                                // �v�nement quand on le traverse. Dans le champ "Trigger Entered", on fait glisser l'objet sur
                                                // lequel on veut agir, et on s�lectionne l'action qu'on veut avoir sur lui.
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name + " est sorti du trigger de " + gameObject.name);

        if (other.name == "PlayerCapsule" && deactivate == false)
            TriggerExited.Invoke();
    }

    public void DeactivateTrigger()
    { deactivate = true; }
}
