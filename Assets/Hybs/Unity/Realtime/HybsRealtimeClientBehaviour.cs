using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hybs.Realtime;

namespace Hybs.Unity.Realtime
{
    public class HybsRealtimeClientBehaviour : MonoBehaviour
    {
        protected HybsRealtimeSettingsBehaviour _settings;
        protected GameClient _gameClient;

        public Lobby lobby { get => _gameClient?.lobby; }
        public IEnumerator Dial()
        {
            _gameClient.Start();
            yield return null;
        }
        public IEnumerator Disconnect()
        {
            _gameClient.Stop();
            yield return null;
        }

        // Start is called before the first frame update
        void Start()
        {
            _settings = GetComponent<HybsRealtimeSettingsBehaviour>();
            _gameClient = new GameClient(_settings.region, _settings.credential, _settings.environment);
        }

        // Update is called once per frame
        void Update()
        {
            _gameClient.Update();
        }

        void OnDestory()
        {
            _gameClient?.Stop();
        }
    }
}