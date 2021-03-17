using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTime : MonoBehaviour
{

    public float timer;
    public PotConditions b;
    private Animator animator;



    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (b.amountOfBottles == 2)
        {
            Achieved();
            timer += Time.deltaTime;

            if (timer > 7)
            {
                this.gameObject.GetComponent<BoxCollider>().enabled = true;// Collider doesn't follow animation. So I set it and when the animation was done then I enabled the box Collider

            }

        }
    }

    public void Achieved()
    {
        animator.SetBool("Achieved", true);
    }
}
