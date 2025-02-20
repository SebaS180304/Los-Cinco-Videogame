using UnityEngine;

public class EndingDeActivate : StateMachineBehaviour
{
    // Codigo hecho con la finalidad de do
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.gameObject.SetActive(false);
    }




}
