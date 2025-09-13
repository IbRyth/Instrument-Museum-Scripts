using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnimatorManager : MonoBehaviour
{

    public Animator[] AniArray;

    Animator t_animator;

    
    void Start()
    {
        t_animator = gameObject.GetComponent<Animator>();
    }



    public void playAnimator(string AnimatorName)
    {

        t_animator.SetTrigger(AnimatorName);
    }

    public void pauseAnimator()
    {

        t_animator.speed = 0;
    }
    public void rePlayAnimator()
    {

        t_animator.speed = 1;
    }

    public void stopAnimator(string AnimationName)
    {
        t_animator.SetTrigger("Stop");

        //Debug.Log("current_animation_name" + AnimationName);
        //t_animator.Update(0f);
        //t_animator.Play(AnimationName, 0, 0);
        //t_animator.Update(0);
        //t_animator.enabled = false;
        //string name = animator.GetCurrentAnimatorClipInfo(0)[0].clip.name;//获取当前播放动画的名称
        //Debug.Log("当前播放的动画名为：" + name);
        //float length = animator.GetCurrentAnimatorClipInfo(0)[0].clip.length;//获取当前动画的时间长度
        //Debug.Log("播放动画的长度：" + length);

        //AnimationClip clip = t_animator.runtimeAnimatorController.animationClips[0];
        //Debug.Log("clip" + clip.name);
        //t_animator.Play(clip.name, 0, 0.001f);
        //t_animator.Update(0);
    }

    void Update()
    {

        //var _info = t_animator.GetCurrentAnimatorStateInfo(0);
        ////var _pTime = _info.length / (_info.speed * _info.speed);
        ////Debug.Log("动画时间" + _pTime + "  " + _info.length + "  " + _info.speed);
        ////Debug.Log("动画时间" + _info.normalizedTime);
        //AnimationClip clip = t_animator.runtimeAnimatorController.animationClips[0];

        ////Debug.Log("clip" + clip.);
    }
}