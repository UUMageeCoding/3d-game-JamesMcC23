using UnityEngine;

public class player_particle_effect : MonoBehaviour
{
    [SerializeField] GameObject player_mesh;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = player_mesh.transform.position;
    }
}
