Get started with Unity game development with this 30 minute project. Using version 2022.3.9f1 available to download here - https://unity.com/releases/editor/whats-new/2022.3.9

- Create a terrain
- Add in a capsule with a "CharacterController" component and make sure there is a collider, set the Main Camera as a child to this and align your perspective
- Assign the CharacterController script to the capsule, you should now be able to move around the terrain so this is your Player. Remember, if you move the main camera (keep it as a child to the player) you can experiment with different camera angles!
- Create a small mesh - such as a cube - and assign it as a child to the player, scale as appropriate. This will be our trigger object. We will select the mesh collider in the inspector and assign the IsTrigger bool to True (tick it)
- Create some cubes or other mesh objects around the scene and assign the Rigidbody component. Disable gravity and move the mesh above the terrain a fixed height. Leave one cube on the floor, this will be our trigger area.
- Create a new script called TriggerGravity, paste the example in the repo and assign it to the trigger object you created under your player. Drag and drop each of the floating cube objects you created and under the event function select GameObject > Rigidbody > Gravity. Set the bool to true (again its a tick)

- Press play and enjoy your now interactive scene!
