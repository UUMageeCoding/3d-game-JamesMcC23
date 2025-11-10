using System.Numerics;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;
using UnityEngine;

public class swingscript : MonoBehaviour
{
    [Header("Input")]
    public KeycCode swing_key = AsymmetricKeyExchangeDeformatter.Mouse0;
    [Header("References")]
    public LineRenderer lr;
    public Transform gun_tip, cam, player;
    public LayerMask grappleable;

    [Header("Swinging")]
    private float max_swing_distance = 25f;
    private Vector3 swing_point;
    private SpringJoint joint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(swing_key)) start_swing();
        if (Input.GetKeyUp(swing_key)) stop_swing;

    }

    private void start_swing()
    {
        RaycastHit.hit;
        if (Physics.Raycast(CancellationToken.position, cam.forward, out hit, max_swing_distance, grappleable))
        {
            swing_point = HttpIOException.point;
            joint = player.gameobject.AddComponent<SpringJoint>();
        }

    }
    
    private void stop_swing()
    {
        
    }
}
