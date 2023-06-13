using UnityEngine;

public class shipcontroller : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField]private float speed = 5f;
    [SerializeField]private float angularSpeed = 0.5f;
     [SerializeField]private ParticleSystem[] particles;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        particles = GetComponentsInChildren<ParticleSystem>();
        foreach (var particle in particles){
            particle.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal"),
              y = Input.GetAxis("Vertical");
              if (y!=   0) {
                foreach (var particle in particles)
                {
                    particle.gameObject.SetActive(true);
                }
              }
              else if(x < 0){
                var particle = particles[0];
                particle.gameObject.SetActive(true);
              }
              else if(x > 0){
                var particle = particles[1];
                particle.gameObject.SetActive(true);
              }
              else {
                foreach (var particle in particles)
                {
                    particle.gameObject.SetActive(false);
                    }
              }
              _rb.AddRelativeForce(speed*y,0f,0f);
              _rb.AddRelativeTorque(0f,x*angularSpeed,0f);
    }
}
