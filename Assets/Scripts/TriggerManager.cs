using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


// Ce script est attaché à un objet avec un Collider "Is Trigger".

public class TriggerManager : MonoBehaviour
{
    private bool deactivate = false;    // Deviendra true si notre TriggerManager est désactivé (il faudra exécuter notre fonction DeactivateTrigger()
                                        // dans Unity, sur le composant Trigger Manager de l'objet, dans la case "Trigger Entered").
    public UnityEvent TriggerEntered;
    public UnityEvent TriggerExited;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " est entré dans le trigger de " + gameObject.name);

        if (other.name == "PlayerCapsule" && deactivate == false)
            TriggerEntered.Invoke();            // Quand le joueur entre dans notre trigger, ça déclenche l'événement "TriggerEntered".
                                                // Dans Unity, on attache ce script à chaque objet qui a un Is Trigger et qui doit déclencher un
                                                // événement quand on le traverse. Dans le champ "Trigger Entered", on fait glisser l'objet sur
                                                // lequel on veut agir, et on sélectionne l'action qu'on veut avoir sur lui.
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
