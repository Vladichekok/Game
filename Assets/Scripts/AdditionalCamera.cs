using UnityEngine;

public class CameraController : MonoBehaviour
{
    // ѕеременна€ дл€ определени€, находитс€ ли камера в режиме следовани€ за игроком
    private bool followPlayer = true;

    // ѕеременна€ дл€ хранени€ максимального положени€ камеры по оси X
    public float maxXPosition = -35.3f;

    // ѕеременна€ дл€ хранени€ минимального положени€ камеры по оси X
    public float minXPosition = -148f;

    // —сылка на игрока
    public Transform player;

    void Update()
    {
        // ѕровер€ем, следует ли камера за игроком
        if (followPlayer)
        {
            // ѕолучаем текущее положение камеры
            Vector3 newPosition = transform.position;

            // ќграничиваем движение камеры влево и вправо
            newPosition.x = Mathf.Clamp(player.position.x, minXPosition, maxXPosition);

            // ѕримен€ем новое положение камеры
            transform.position = newPosition;
        }
    }

    // ћетод дл€ отключени€ режима следовани€ за игроком
    public void StopFollowingPlayer()
    {
        followPlayer = false;
    }
}

