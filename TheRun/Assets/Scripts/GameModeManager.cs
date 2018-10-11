using UnityEngine;

namespace GameManager
{
    public class GameModeManager : MonoBehaviour
    {
        private GameEnum.GAME_MODE gameMode;

        private void Start()
        {
            gameMode = GameEnum.GAME_MODE.PLAY;
        }

        internal GameEnum.GAME_MODE GetGameMode()
        {
            return gameMode;
        }

        internal void SetGameMode(GameEnum.GAME_MODE gameMode)
        {
            this.gameMode = gameMode;
        }
    }
}
