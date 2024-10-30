using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    float _time = 0.0f;
    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;
        _text.text = _time.ToString();
    }
}
