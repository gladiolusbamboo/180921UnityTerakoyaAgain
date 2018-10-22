using UnityEngine;

public class GameEnum : MonoBehaviour {
    public enum MOVE_DIR
    {
        STOP,LEFT,RIGHT
    }

    public enum GAME_MODE
    {
        PLAY,CLEAR,GAMEOVER
    }

    public enum ENEMY_SE
    {
        DEFEAT, MISS
    }
}
