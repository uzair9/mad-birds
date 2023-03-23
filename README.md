# Mad Birds - A 2D Unity & C# Game

Mad Birds is yet another 2D Unity & C# game that I have created to polish my game development skills. It took me ~10 days to learn and implement all the skills required to create this game. However, I did not design the UI art work used in the game. It was obtained from the [Game Courses](https://game.courses/birds) Website.

## What I Learned

While working on this app, I learnt the following techniques of C# and Unity engine. These are just my personal notes; they are there for me to come back to for revision purposes. However, you are more than welcome too to give my notes a go!

- **Sprite Tiling:** This is like the `background-repeat: 'repeat';` property of CSS. Using sprite tiling, we can repeat the background without having to copy-paste our sprites again and again. For this, we select the `Draw Mode` to `Tile` in our Sprite Renderer component of the bird object. Afterwards, by switching to the `Rect Mode`, we can drag and repeat the background easily.

- **Object Layers:** We can use layers to set the visibility of several objects. It is like the `z-index` property of CSS. The smaller the layer number, the smaller its z-index will be, and, therfore, that object will be displayed behind the other one with a bigger layer number.

- **Animations:** Here, we have to add the `Animator` compoenent to our objects to successfully show animations in them. Then, we have to create the animation in Unity using multiple image assets by dragging them together to the hierarchy. Finally, we drag and drop the animation itself to the animator component and set the display mode to `always` to make our objects always switch back and forth, createing an animation effect.

- **Kinematic Body Type:**

- **Dynamically Getting Components of the Same Object in C# Script:**

- **Dynamically Getting Components of a Different Object in C# Script:**
