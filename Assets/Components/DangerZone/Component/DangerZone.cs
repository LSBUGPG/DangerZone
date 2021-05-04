using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerZone : MonoBehaviour
{
    public float damagePerSecond = 10.0f;
    
    void OnTriggerStay(Collider collider)
    {
        collider.SendMessage("TakeDamage", damagePerSecond * Time.deltaTime, SendMessageOptions.DontRequireReceiver);
    }
}
