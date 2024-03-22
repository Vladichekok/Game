using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DialogueAnimator : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        // �������� ������ � ���������� ��������
        animator = GetComponent<Animator>();
    }

    // ����� ���������� ��� ������ �������
    public void afk()
    {
        // ���� �������� ����� (����������� ���� ����������� �������, ���� �����)
        if (animator.GetBool("IsRunning"))
        {
            // ����������� �������� �� �����
            animator.SetBool("IsRunning", false);
        }
    }
}