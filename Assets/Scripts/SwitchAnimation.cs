using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAnimation : MonoBehaviour
{
    [SerializeField] private string[] animationNames;
    private int index;
    private Animator animator;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Switch()
    {
        animator.Play(animationNames[index++ % animationNames.Length]);
    }
}