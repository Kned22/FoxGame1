using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CharacterAnimation : MonoBehaviour
{
    private Animator _controller;
    void Start()
    {
        _controller = GetComponent<Animator>();        
    }

    void Update()
    {
        _controller.SetBool("IsMoving", Input.GetAxis("Horizontal") != 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _controller.SetTrigger("JumpTrigger");            
        }
    }
}
