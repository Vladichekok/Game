using UnityEngine;

public class CameraController : MonoBehaviour
{
    // ���������� ��� �����������, ��������� �� ������ � ������ ���������� �� �������
    private bool followPlayer = true;

    // ���������� ��� �������� ������������� ��������� ������ �� ��� X
    public float maxXPosition = -35.3f;

    // ���������� ��� �������� ������������ ��������� ������ �� ��� X
    public float minXPosition = -148f;

    // ������ �� ������
    public Transform player;

    void Update()
    {
        // ���������, ������� �� ������ �� �������
        if (followPlayer)
        {
            // �������� ������� ��������� ������
            Vector3 newPosition = transform.position;

            // ������������ �������� ������ ����� � ������
            newPosition.x = Mathf.Clamp(player.position.x, minXPosition, maxXPosition);

            // ��������� ����� ��������� ������
            transform.position = newPosition;
        }
    }

    // ����� ��� ���������� ������ ���������� �� �������
    public void StopFollowingPlayer()
    {
        followPlayer = false;
    }
}

