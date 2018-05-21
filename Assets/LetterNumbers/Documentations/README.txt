*upon opening you might have blank scripts with name "nothing selected" in the Main Camera under any scene (this is due to Post Processing Stack not imported yet) or better yet Pink Meshes. 
Pink Meshes is due to not having the Unity Standard Asset Shader imported yet. These assets need to be download seperately due to the Asset Store Guidelines. Dont worry, this is a very easy Fix.

To get the same effects I had, kindly download these assets first.
Unity Standard Asset: https://www.assetstore.unity3d.com/en/#!/content/32351 (make sure to uncheck everything but Toon Shading - Toon Shading is all you need to import)
Post Processing Stack: https://www.assetstore.unity3d.com/en/#!/content/83912

Assuming you're done downloading and importing, the Pink meshes should be gone now and the Post Processing Profile should be automatically added.
If the Post Processing Profile isnt automatically added and theres a Nothing Selected Attach to your Main Camera, delete it and follow guides below:

Scene: AllAssets
-Click Main Camera under Hierarchy, make sure under Post Processing Behaviour the Post Processing Profile named "Profile 1" is in the slot.
-If you dont have Post Processing Behaviour, click Add Component and type Post Processing Behaviour and add the script. "Profile 1" is under the folder "PP Profile"
-Also dont forget to change Gamma lighting to Linear (File-Build Settings-Player Settings-Color Space to Linear)
_______________________________________________________________________________________________________________________________________________________________________________________________

Prefab is at Default "Toon Lighted Shader" To change the Shader of the prefabs on batch,
-Go to prefabs folder under folder YN
-Left Mouse Click YN_0 Prefab
-Scroll all the way down to Z (make sure YN_0 is still selected)
-Hold shift and Left Mouse Click YN_Z Prefab
-On the Inspector, click the material and Change Toon Basic to Any of the 5 Shader under Toon
-Right click the Prefabs that is selected right now and hit Reimport to apply those changes.
Keep In Mind: By default the prefabs are still on Toon Lighted Shader, it wont change until you click reimport.

To Change Hierarchy Example Colors and Shader:
-Click either Gradients Analogous Colors, Color Blocks Warm Colors, Gradients Cool Colors or Color Blocks Complimentary Colors Shader Example (whichever you want modified)
-Say you click Color Blocks Complimentary Colors Shader Example, Click the subfolder and hightlight YN_0 to YN_Z (just like how to highlight prefabs on above instructions)
-Pay attention to the Inspector on the right
-Under the material, you can change how you change the Shader on the prefabs (like you did before)
-Or you can change the Color by dragging a material. (The matrial folder is under YN-Materials-Texture_materials) you can edit these materials and apply them however you want. 

Difference between Lit and Lighten Shader
-Unity Lit shader can be affected by any light (directional, point lightm ect skybox etc) but it wont cast a shadow. This is where Lighten Shader comes in.

You can change how the light affects these mesh by:
-Changing the Ramp/Cubemap under each material (there is only two variation of Cubemap right now (one under Unity Standard assets and one is Toon Texture Folder) but you can make your own in photoshop, 
just make sure you export it as PSD(for cubemap) and PNG(for Ramp gradients) and you copy the same import settings under the Unity Standard Assets. (click the files already there to see the import settings)
Ive made 7 variations of Ramp Gradients that you can apply on Lighten or any Lit Shader if you choose to experiment (its under YN-Texture-Toon Texture).

There are tons of Colors, Singular, Gradients, and even Palettes. Mix and Match~ There's tons of colors to choose from!


Enjoy~


Any problems, questions or remarks on how to improve this package, you can reach me here: 
-yumeofficial24@gmail.com
-https://discordapp.com/invite/etX2zJB [@LeFluff]
-https://connect.unity.com/u/581f502b32b306001b44485a
