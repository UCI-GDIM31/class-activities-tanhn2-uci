# in-class-activities
## Devlogs
### W1
Attached player component into a cat object to give it ability to move with AWSD. Relocate cat object to new starting point  

### W2
1.All the variable r,g,b have to be float type because the RGB value can only be in scale from 0.0 to 1.0 which is a decimal value. Int type can only hold the whole number, string can only hold the sequence of characters and boolean can only hold true and false. So, float is the one can hold a number with decimal. In this circumstance, we're prefer to use float over any of them.

2.The _bounces variable have to be an int type because we represent a total number of bounces as a whole number. It would make no sense if the ball bounces and we add up 0.8 or 0.6 so we can't use float type in this circumstance. Boolean is only can hold true or false so this is also not a good choice. String type is the one we can use to display whole number as a text but we can not increment or adding up whenever the ball bounces.

3.The error stated "Literal of type double cannot be implicitly converted to type float. Use an F suffix to create a literal of this type"

### W3
Table #12: Our method would take two parameters. The first parameter. The first parameter would be int type would take how closed is this relationship based on number and the second parameter is boolean to detemrine whether or not character know secret. And the return type for this method will be string type which is a text response. 

Think of a class as a blueprint for a robot in a robot factory. The blueprint defines what parts the robot has and what tasks it can perform, but it isn’t an actual robot yet. When you use that blueprint to build a real robot, that robot becomes a Component. The member variables are the robot’s traits or features like its color, size, or battery capacity These can differ from one robot to another, even if they come from the same blueprint. The methods are the robot’s abilities or actions, such as walking, talking, or picking up objects. These are the things every robot built from that blueprint knows how to do.

### W4
Line 17: _isGrounded is a member variable of CatW4, and the type is boolean. We set this member variable to true because we want player's character would be on the ground when starting the game.
Line 28: This line of code would check whether or not player hit the space and whether or not character is on the ground. If both of conditions are true, below block of code will execute.
Line 32: This line of code is set a member variable _isGrounded to false to prevent chacracter that jump while in the air.

1. The solution I came up with the activity was Rigidbody added into cat and soccer ball object. And Is Trigger checked on a goal.
2. I had an issue when my cat object kick the ball and cat started rolling. I fixed it by checking the freeze rotation on X and Z

### W5 
1. How does GetComponent() method work ? -> is a method that looks for a component of specify type attached to the same GameObject and returns it.
2. DeerW5 class will need a Transform _destination object and NavMeshAgent object as a member variable. A method might need for this class is update() method. This update() method will call every frame and transform a Deer object position to target object.

### W6
Inherite MonoBehaviour 
Speed variable with SerializeField
We need Start and Update method

Unity Coding [In-class Activity](https://docs.google.com/document/d/1wrY73yJ_km0ig2SehlUSuSx3rOOu84QnORwQ0mV305o/edit?tab=t.0)

### W7 
Physics and Gameplay [In-class Activity](https://docs.google.com/document/d/12FkLu3TyiaSycwzMFiDzaApR5NOht5-WelRo95wzODg/edit?tab=t.0)

In step #2, When directly adding to transform.position, the character moves along the world space Z axis rather than its local forward direction. This is because Vector3.forward is a static vector constant that always points in the global z axis, regardless of the GameObject's rotation.
## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 