using System;
using System.Collections;
using UnityEngine;

namespace Cubes
{
    public class CubeAnimation : MonoBehaviour
    {
        private float speed;
        private float liveTime;

        private float spawnTime;
        private Vector3 direction = Vector3.up;

        public void Init(float speed, float distance)
        {
            spawnTime = Time.time;
            this.speed = speed;
            this.liveTime = distance / speed;
        }

        private void Update()
        {
            transform.Translate(direction * Time.deltaTime * speed);
            if(Time.time >= liveTime + spawnTime)
                Destroy(gameObject);
        }
    }
}