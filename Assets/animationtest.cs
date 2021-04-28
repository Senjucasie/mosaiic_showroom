using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationtest : MonoBehaviour
{
    public Animator anim;
    public Animation anim1;
    public AnimationClip clip1;
    // Start is called before the first frame update
    void Start()
    {
        anim1.Play("explode_clip");
        anim1.AddClip(clip1, "explode");
        anim1.Play("explode");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.U))
        {
            anim1.Play("explode");
           
        }
        //if (Input.GetKeyDown(KeyCode.I))
        //{
        //    anim.speed = -1;
        //}

    }
}
