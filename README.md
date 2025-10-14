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
## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 