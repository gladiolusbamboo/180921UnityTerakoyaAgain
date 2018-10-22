using GameManager;
using Player;
using UnityEngine;

namespace OutZone
{
    public class OutZoneHitHandlerCaller : MonoBehaviour, IPlayerHitHandlerCaller
    {
        internal ILabelDisplayer gameOverDisplayer;
        internal IPlayerMissAnimator playerOutZoneAnimator;
        public GameModeManager gameModeManager;
        public OutZoneSEPlayer outZoneSEPlayer;

        void Start()
        {
            gameOverDisplayer = GameObject.Find("GameOverDisplayer").GetComponent<ILabelDisplayer>();
            playerOutZoneAnimator = GameObject.Find("Player").GetComponent<PlayerOutZoneAnimator>();
        }

        public void CallHandler()
        {
            gameOverDisplayer.Show();
            gameModeManager.SetGameMode(GameEnum.GAME_MODE.GAMEOVER);
            playerOutZoneAnimator.Animate();
            outZoneSEPlayer.Play();
        }
    }
}