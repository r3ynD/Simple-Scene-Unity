# Simple-Scene-Unity
<h3>Simple Unity scene with using C# script to switch scenes and to show particle system and control starship</h3>

<h2>Creating Particle System:</h2>

Firstly you need to download images of your particle system and import it to your project

To create a particle system in Unity, follow these steps:

1. Create a new Particle System GameObject by selecting `GameObject`(figure or model to which you want to bind the particle system) ->`Effects`->`Particle System`.

![image](https://github.com/r3ynD/Simple-Scene-Unity/assets/127958857/39e16b00-5613-41d0-8579-a2608f9be68c)


2. In the Particle System component, adjust properties such as emission rate, duration, start speed, start size, and color to customize the appearance of your particles.

![image](https://github.com/r3ynD/Simple-Scene-Unity/assets/127958857/181b709e-bee5-4314-9aed-d7883c43555a)

3. Under the `Shape` module, you can choose the shape of the area where particles will be emitted from, such as a cone, sphere, or box. You can also adjust the radius, angle, and position of the shape to fine-tune its appearance.

![image](https://github.com/r3ynD/Simple-Scene-Unity/assets/127958857/9bfd61f6-041d-47f2-baba-a40e1dbed240)


4. In the `Renderer` module, choose how the particles should be rendered, such as with billboards (2D planes) or mesh objects. Adjust the texture and material properties to further customize the look of your particles.

![image](https://github.com/r3ynD/Simple-Scene-Unity/assets/127958857/9ede03d7-0718-494c-b5a1-85968f86b94d)


5. You can add additional modules such as `Noise`, `Trail`, and `Lights` to further enhance the appearance of your particle system.

6. Finally, use the `Inspector` window to preview your particle system and adjust any remaining settings until you're happy with the result.

By combining different settings and modules, you can create a wide variety of particle effects, from smoke and fire to rain and explosions. Once you have created your particle system, you can use it in your game by either attaching it to an existing object or instantiating it programmatically using scripts.

![image](https://github.com/r3ynD/Simple-Scene-Unity/assets/127958857/ce3915b5-dc99-44b6-911b-8c91bb8b4b11)

![image](https://github.com/r3ynD/Simple-Scene-Unity/assets/127958857/050ceb93-9560-4e6a-8c7a-6e345e728cf1)

<h2>Control script:</h2>

<h3>Script "shipcontroller.cs" is responsible for control starship</h3>

![image](https://github.com/r3ynD/Simple-Scene-Unity/assets/127958857/cd7f682e-ed69-4809-8092-9157a553223d)


- `private Rigidbody _rb;` creates a private variable with a Rigidbody component to control the physics of the object.

- `[SerializeField] private float speed = 5f;` and `[SerializeField] private float angularSpeed = 0.5f;` create two serialized variables for setting the speed of movement and rotation of the spaceship.

- `[SerializeField] private ParticleSystem[] particles;` creates an array of ParticleSystem particles that will be used for motion effects.

![image](https://github.com/r3ynD/Simple-Scene-Unity/assets/127958857/e0dd136f-5c03-4b59-9076-86a31e3e0b3c)

- `void Start()` sets up the Rigidbody component and disables all ParticleSystems so they are not active at the beginning of the game.

- `void Update()` tracks user input, reacting to changes in the ship's state by changing the activity of ParticleSystems.

![image](https://github.com/r3ynD/Simple-Scene-Unity/assets/127958857/31de69b5-3b2e-4b55-ab2e-a6cc499972ee)

- Variables `x` and `y` determine user input for horizontal and vertical movement of the spaceship.

- In the following if/else blocks, the state of the spaceship is checked and the corresponding ParticleSystem is enabled to create motion effects.

![image](https://github.com/r3ynD/Simple-Scene-Unity/assets/127958857/467eaad5-6fff-4e5b-9e19-c039d4538b86)

- `_rb.AddRelativeForce(speed*y,0f,0f);` adds force to move the spaceship depending on the user input.

- `_rb.AddRelativeTorque(0f,x*angularSpeed,0f);` adds torque to rotate the spaceship depending on the user input.


<h3>Result:</h3>

<img src="https://github.com/r3ynD/Simple-Scene-Unity/assets/127958857/c021fbf8-0d05-42bd-88e7-c24fac8f5178" width=60%>
