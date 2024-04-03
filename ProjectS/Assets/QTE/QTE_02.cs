using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.ShaderData;

public class QTE_02 : MonoBehaviour
{
    int i = 1;
    private KeyCheck _KeyCheck;
    private static KeyCode[] keyCodevalidkeys1 = new KeyCode[] { KeyCode.S, KeyCode.S, KeyCode.D };
    private static KeyCode[] keyCodevalidkeys2 = new KeyCode[] { KeyCode.S, KeyCode.S, KeyCode.D };
    private static KeyCode[] keyCodevalidkeys3 = new KeyCode[] { KeyCode.S, KeyCode.S, KeyCode.D };
    private static KeyCode[] keyCodevalidkeys4 = new KeyCode[] { KeyCode.S, KeyCode.S, KeyCode.D };
    private KeyCode[][] keyCodes = new KeyCode[][] { keyCodevalidkeys1, keyCodevalidkeys2 , keyCodevalidkeys3 , keyCodevalidkeys4 };
    private void Start()
    {
        _KeyCheck = new KeyCheck(keyCodes[i]);
        _KeyCheck.OnMisstake.AddListener(OnMisstake);
        _KeyCheck.OnPass.AddListener(OnPass);
    }
    private void OnMisstake()
    {

    }
    private void OnPass()
    {

    }
    private void Update()
    {
        foreach (var key in keyCodes[i])
        {
            _KeyCheck.InputKey(key);
            break;
        }
    }
}
