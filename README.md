# Mad Birds - A 2D Unity & C# Game

Mad Birds is yet another 2D Unity & C# game that I have created to polish my game development skills. It took me ~10 days to learn and implement all the skills required to create this game. However, I did not design the UI art work used in the game. It was obtained from the [Game Courses](https://game.courses/birds) Website.

## What I Learned

While working on this app, I learnt the following techniques of C# and Unity engine. These are just my personal notes; they are there for me to come back to for revision purposes. However, you are more than welcome too to give my notes a go!

- **Sprite Tiling:** This is like the `background-repeat: 'repeat';` property of CSS. Using sprite tiling, we can repeat the background without having to copy-paste our sprites again and again. For this, we select the `Draw Mode` to `Tile` in our Sprite Renderer component of the bird object. Afterwards, by switching to the `Rect Mode`, we can drag and repeat the background easily.

- **Object Layers:** We can use layers to set the visibility of several objects. It is like the `z-index` property of CSS. The smaller the layer number, the smaller its z-index will be, and, therfore, that object will be displayed behind the other one with a bigger layer number.

- **Animations:** Here, we have to add the `Animator` compoenent to our objects to successfully show animations in them. Then, we have to create the animation in Unity using multiple image assets by dragging them together to the hierarchy. Finally, we drag and drop the animation itself to the animator component and set the display mode to `always` to make our objects always switch back and forth, createing an animation effect.

- **Rigid Body Types: Kinematic Vs. Dynamic:** If we set the `Body Type` field of our rigid body to `Kinematics` from `Dynamics`, we can stop the force of gravity from acting on it. This is because Kinematics is that branch of mechanics which disregards the forces acting on the bodies while observing thier motion. So, the bird does not fall downwards anymore according to the principles of physics.

- **Getting Same Vs. Different Object's Components Dynamically in C#:** Rather than dragging and dropping one component into the pointer field of our C# script from the game Engine, we can use the following alternative which is a completely programmatic way of doing the same thing: `GetComponent<Rigidbody2D>()`. If we do it in the `Start( ... )` method, we can easily change the fields in our Rigidbody2D before `Update( ... )` is called in the first frame.
  However, the syntax for getting another object's components is a little different, as the script sitting in this object is not aware of the other object or its components. So, we tag the other object in oru Unity engine and then use the following syntax: `gameObject.getObjectWithTag("Other's Tag Name").getComponent<Rigidbody2D>();`

- **transform.position Vs. Rigidbody2D.position:** The former returns a Vector3 whereas the latter returns Vector2. Is really annoying to have to set the values of z-axis in 2D, as they literally have no use. So, we use the second option rather than the first one.

- **Making the Bird Fly:** At first, we took the default position of the bird in the `Start( ... )` method. Then, in `OnMouseUp( ... )`, we computed the current position. For computing 2D positions, we used `Rididbody2D.position`. Then, we subtracted both, so that we could get the flying direction and magnitude in 2D vector. Finally, we added force to the object after making its Rigibody2D's body type `Dynamic` from `Kinematic`.

- **Lifecycle Methods:** The Unity engine has several phases in its lifecycle, each with its own set of functions that are automatically called at different points during the game's execution. Here are the main phases and the functions that are called during each of the phases in the official [Unity Docs](https://docs.unity3d.com/Manual/ExecutionOrder.html)
