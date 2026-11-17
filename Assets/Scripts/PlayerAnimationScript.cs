using UnityEngine;

public class PlayerAnimationScript : MonoBehaviour
{
    Animator hugosAnimator;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hugosAnimator = GetComponent<Animator>();
        
        hugosAnimator.SetBool("run", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            hugosAnimator.SetBool("run", true);
        }
       
        if (Input.GetKeyUp("w"))
        {
            hugosAnimator.SetBool("run", false);
        }
    }
}
