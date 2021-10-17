using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hybs.Realtime;

namespace Hybs.Unity.Realtime
{
    public class HybsRealtimeLobbyBehaviour : MonoBehaviour
    {
        public string lobbyId { get => _clientBehaviour?.lobby?.id; }
        public string userId { get => _clientBehaviour?.lobby?.self?.id; }

        protected HybsRealtimeClientBehaviour _clientBehaviour;
        // Start is called before the first frame update
        void Start()
        {
            _clientBehaviour = GetComponent<HybsRealtimeClientBehaviour>();
        }

        // Update is called once per frame
        void Update()
        {
        }
    }
}
