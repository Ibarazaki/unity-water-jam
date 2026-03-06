using UnityEngine;

public class LakeAnimSpeed : MonoBehaviour
{
    [SerializeField] private float speed = 0.5f;
    private Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
        if (anim != null) anim.speed = speed;
    }
}