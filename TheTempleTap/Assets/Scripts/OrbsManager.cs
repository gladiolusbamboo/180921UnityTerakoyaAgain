using UnityEngine;

namespace Orb
{
    public class OrbsManager : MonoBehaviour
    {
        public const int MAX_ORB = 10;

        private int currentOrb;

        internal int GetMaxOrb()
        {
            return MAX_ORB;
        }

        internal int GetCurrentOrbMaxOrbDifference()
        {
            return MAX_ORB - currentOrb;
        }

        internal void DeleteOrb()
        {
            currentOrb--;
            if (currentOrb < 0)
                currentOrb = 0;
        }

        internal void GenerateOrb()
        {
            currentOrb++;
            if (currentOrb > MAX_ORB)
                currentOrb = MAX_ORB;
        }

        internal int GetCurrentOrb()
        {
            return currentOrb;
        }

        internal void SetCurrentOrb(int val)
        {
            currentOrb = val;
        }
    }
}