using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Hybs.Unity.Realtime;

public class ButtonDialBehaviour : MonoBehaviour
{
    public GameObject networkClient;

    private Button _button;
    private HybsRealtimeClientBehaviour _client;
    // Start is called before the first frame update
    void Start()
    {
        _button = GetComponent<Button>();
        if (networkClient)
        {
            _client = networkClient.GetComponent<HybsRealtimeClientBehaviour>();
        }
        _button?.onClick.AddListener(buttonOnClick);
    }

    void buttonOnClick()
    {
        StartCoroutine(_client.Dial());
    }
}
