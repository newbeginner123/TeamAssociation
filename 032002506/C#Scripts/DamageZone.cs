using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    public int damageNumber = -1;
    private void OnTriggerStay2D(Collider2D collision)
    {
        RubyController rubyController = collision.GetComponent<RubyController>();
        if(rubyController != null)
        {
            rubyController.ChangeHealth(damageNumber);
        }
        
    }
}
