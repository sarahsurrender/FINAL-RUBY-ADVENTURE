using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDownController : MonoBehaviour
{
    public AudioClip speedSlowSound;
    public ParticleSystem healthEffectObject;

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            controller.SpeedSlow(1);
            healthEffectObject = Instantiate(healthEffectObject, transform.position, Quaternion.identity);
            Destroy(gameObject);

            controller.PlaySound(speedSlowSound);

        }
    }
}
