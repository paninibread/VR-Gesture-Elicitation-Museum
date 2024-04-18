using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    Animator animator;
    public GameObject opponentText;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
        opponentText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetFun()
    {
        animator.SetTrigger("Fun");
        opponentText.SetActive(true);
    }

    public void SetAngry()
    {
        animator.SetTrigger("Angry 1");
        opponentText.SetActive(true);
    }

    public void SetSad()
    {
        animator.SetTrigger("Sad");
        opponentText.SetActive(true);
    }
}
