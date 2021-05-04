using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider indicator;
    public int maxHitPoints;
    float hitPoints;

    void Start()
    {
        hitPoints = maxHitPoints;
    }

    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
        if (hitPoints < 0.0f)
        {
            hitPoints = 0.0f;
        }
    }

    void Update()
    {
        indicator.value = hitPoints / (float)maxHitPoints;
    }
}
