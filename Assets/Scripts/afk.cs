using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DialogueAnimator : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        // Получаем доступ к компоненту анимации
        animator = GetComponent<Animator>();
    }

    // Метод вызывается при начале диалога
    public void afk()
    {
        // Если персонаж бежит (используйте свои собственные условия, если нужно)
        if (animator.GetBool("IsRunning"))
        {
            // Переключаем анимацию на покой
            animator.SetBool("IsRunning", false);
        }
    }
}