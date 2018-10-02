using UnityEngine;
using UnityEngine.UI;

namespace Orb
{
    public class OrbGenerator : MonoBehaviour
    {
        public OrbsManager orbsManager;
        public GameObject orbPrefab;
        public OrbPositionRandomSetter orbPositionRandomSetter;
        public Sprite[] sprites;

/*        void Start()
        {
            for (int i = 0; i < orbsManager.GetCurrentOrb(); i++)
            {
                GenerateOrb();
            }
        }*/

        internal GameObject GenerateOrb()
        {
            GameObject orb = Instantiate(orbPrefab);
            var orbData = orb.GetComponent<OrbData>();
            orbData.SetOrbKind();
            orb.GetComponent<Image>().sprite = sprites[(int)orbData.GetOrbKind()];
            orbPositionRandomSetter.SetRandomPosition(orb);
            return orb;
        }
    }
}