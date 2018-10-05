using Player;
using UnityEngine;

public class RightButtonHandler : MonoBehaviour, IButtonHandler
{
    public PlayerMover playerMover;

    public void Tap()
    {
        playerMover.SetMoveDirection(GameEnum.MOVE_DIR.RIGHT);
    }

    public void Release()
    {
        playerMover.SetMoveDirection(GameEnum.MOVE_DIR.STOP);
    }
}
