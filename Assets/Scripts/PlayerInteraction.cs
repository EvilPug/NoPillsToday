using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public Animator fridge_anim;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("interactable"))
        {
            fridge_anim.SetBool("is_opened", true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("interactable"))
        {
            fridge_anim.SetBool("is_opened", false);
        }
    }


}

