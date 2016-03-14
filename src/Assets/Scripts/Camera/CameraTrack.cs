using UnityEngine;

namespace Assets.Scripts.Camera
{
    public class CameraTrack : MonoBehaviour
    {
        public GameObject GameObject;
        public Vector3 Offset;
        public float Leeway;

        void Start()
        {
            transform.position = GameObject.transform.position + Offset;
        }

        void Update()
        {
            if (GameObject.transform.position.x + Leeway < transform.position.x)
            {
                transform.position = new Vector3(GameObject.transform.position.x + Leeway, transform.position.y) + Offset;
            }
            else if (GameObject.transform.position.x - Leeway > transform.position.x)
            {
                transform.position = new Vector3(GameObject.transform.position.x - Leeway, transform.position.y) + Offset;
            }

            if (GameObject.transform.position.y + Leeway < transform.position.y)
            {
                transform.position = new Vector3(transform.position.x, GameObject.transform.position.y + Leeway) + Offset;
            }
            else if (GameObject.transform.position.y - Leeway > transform.position.y)
            {
                transform.position = new Vector3(transform.position.x, GameObject.transform.position.y - Leeway) + Offset;
            }
        }
    }
}