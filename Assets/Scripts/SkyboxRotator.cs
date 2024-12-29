using UnityEngine;

public class SkyboxRotator : MonoBehaviour
{
    [SerializeField] float RotateSpeed = 10;
    [SerializeField] Material skybox;
    void Update()
    {
        skybox.SetFloat("_Rotation", Time.time * RotateSpeed);
    }
}
