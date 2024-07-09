using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator playerAnimator;

    public void playerAttack()
    {
        playerAnimator.SetTrigger("goAttack");
    }

}
