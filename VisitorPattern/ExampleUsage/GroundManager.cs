using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace DesignPattern.Behavioral.VisitorPattern.ExampleUsage
{
    public class GroundManager : MonoBehaviour
    {
        private List<IVisitableGround> groundTiles = new List<IVisitableGround>();

        void Start()
        {
            foreach (var ground in FindObjectsOfType<MonoBehaviour>().OfType<IVisitableGround>())
            {
                groundTiles.Add(ground);
            }
        }

        public void HandlePlayerOnGround(GameObject player)
        {
            var playerVisitor = new PlayerGroundInteractionVisitor();

            foreach (var ground in groundTiles)
            {
                if (Vector3.Distance(player.transform.position, ((MonoBehaviour)ground).transform.position) < 1f)
                {
                    ground.Accept(playerVisitor);
                    break;
                }
            }
        }
    }
}