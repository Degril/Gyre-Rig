using System;
using System.Collections;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

namespace Cubes
{
    public class CubeSpawner : MonoBehaviour
    {
        [SerializeField] private InputField intervalInputField;
        [SerializeField] private InputField speedInputField;
        [SerializeField] private InputField distanceInputField;
        [SerializeField] private CubeAnimation cubeAnimationPrefab;

        private float interval;
        private float speed;
        private float distance;

        private void Start()
        {
            interval = Parse(intervalInputField.text);
            speed = Parse(speedInputField.text);
            distance = Parse(distanceInputField.text);
            intervalInputField.onValueChanged.AddListener(newValue => interval = Parse(newValue));
            speedInputField.onValueChanged.AddListener(newValue => speed = Parse(newValue));
            distanceInputField.onValueChanged.AddListener(newValue => distance = Parse(newValue));
            StartCoroutine(CubeSpawnerCoroutine());
        }

        private float Parse(string text)
            => float.Parse(text, CultureInfo.InvariantCulture.NumberFormat);


        private IEnumerator CubeSpawnerCoroutine()
        {
            while (true)
            {
                Instantiate(cubeAnimationPrefab, transform).Init(speed,distance);
                yield return new WaitForSeconds(interval);
            }
        }
    }
}